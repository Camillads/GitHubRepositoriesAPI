using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteTakeBot.Domain.Models.Components;
using TesteTakeBot.Domain.Models.GitHub;
using TesteTakeBot.Infra.CrossCutting.GitHub.Interfaces;
using TesteTakeBot.Service.Services.Interfaces;

namespace TesteTakeBot.Service.Services
{
  public class GitHubService : IGitHubService
  {
    private readonly IGitHubAgent _gitHubAgent;

    public GitHubService(IGitHubAgent gitHubAgent)
    {
      _gitHubAgent = gitHubAgent;
    }

    public async Task<CarrosselDinamic> GetDataGitHubRepositoryAsync(string accountName)
    {
      try
      {
        var repositories = await _gitHubAgent.GetDataGitHubRepositoryAsync(accountName);

        var filter = GetRepositoriesCSharpTake(repositories);

        return FormatCarouselOutput(filter);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }

    private List<ReposGitHub> GetRepositoriesCSharpTake(List<ReposGitHub> repositories)
    {
      return repositories.FindAll(repo => !string.IsNullOrEmpty(repo.Language) && repo.Language.Equals("C#"))
        .OrderBy(repo => repo.CreatedAt)
        .Take(5)
        .ToList();
    }

    private CarrosselDinamic FormatCarouselOutput(List<ReposGitHub> repositories)
    {
      var carousel = new CarrosselDinamic();
      carousel.Items = new List<Item>();

      foreach (var repo in repositories)
      {
        var newCarousel = new Item
        {
          Header = new Header
          {
            Type = "application/vnd.lime.media-link+json",
            Value = new Val
            {
              Title = repo.Name,
              Text = repo.Description,
              Uri = repo.Owner.AvatarUrl
            }
          }
        };

        carousel.Items.Add(newCarousel);
      }

      return carousel;
    }
  }
}

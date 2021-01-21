using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

    public async Task<List<ReposGitHub>> GetDataGitHubRepositoryAsync(string accountName)
    {
      try
      {
        var repositories = await _gitHubAgent.GetDataGitHubRepositoryAsync(accountName);

        return GetRepositoriesCSharpTake(repositories);
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
  }
}

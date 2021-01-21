using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteTakeBot.Domain.Models.GitHub;
using TesteTakeBot.Infra.CrossCutting.GitHub.Interfaces;
using TesteTakeBot.Shared.Util.Constants;
using TesteTakeBot.Shared.Util.Interfaces;

namespace TesteTakeBot.Infra.CrossCutting.GitHub
{
  public class GitHubAgent : IGitHubAgent
  {
    private readonly IAppSettings _appSettings;

    public GitHubAgent(IAppSettings appSettings)
    {
      _appSettings = appSettings;
    }

    public async Task<List<ReposGitHub>> GetDataGitHubRepositoryAsync(string accountName)
    {
      return await _appSettings.UrlBaseGitHub
          .AppendPathSegment(string.Format(Constants.URL_REPOS_TAKE_BLIP, accountName))
          .SetQueryParam("access_token=", _appSettings.AccessTokenGitHub)
          .WithOAuthBearerToken(_appSettings.AccessTokenGitHub)
          .WithHeader("User-Agent", "request")
          .GetJsonAsync<List<ReposGitHub>>();
    }

  }
}

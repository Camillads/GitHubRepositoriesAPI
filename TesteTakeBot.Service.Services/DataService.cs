using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTakeBot.Domain.Models.Components;
using TesteTakeBot.Domain.Models.GitHub;
using TesteTakeBot.Service.Services.Interfaces;
using TesteTakeBot.Shared.Util.Constants;

namespace TesteTakeBot.Service.Services
{
  public class DataService : IDataService
  {
    private readonly IGitHubService _gitHubService;

    public DataService(IGitHubService gitHubService)
    {
      _gitHubService = gitHubService;
    }

    public Task<CarrosselDinamic> GetDataGitHubRepositoryTakeBlipAsync()
    {
      try
      {
        var accountName = Constants.ACCOUNT_NAME_TAKE_BLIP;
        return _gitHubService.GetDataGitHubRepositoryAsync(accountName);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}

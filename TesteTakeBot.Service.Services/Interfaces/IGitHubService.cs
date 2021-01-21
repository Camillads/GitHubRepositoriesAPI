using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTakeBot.Domain.Models.GitHub;

namespace TesteTakeBot.Service.Services.Interfaces
{
  public interface IGitHubService
  {
    Task<List<ReposGitHub>> GetDataGitHubRepositoryAsync(string accountName);
  }
}

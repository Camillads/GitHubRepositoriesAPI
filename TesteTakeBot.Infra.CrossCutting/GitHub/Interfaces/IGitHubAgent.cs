using System.Collections.Generic;
using System.Threading.Tasks;
using TesteTakeBot.Domain.Models.GitHub;

namespace TesteTakeBot.Infra.CrossCutting.GitHub.Interfaces
{
  public interface IGitHubAgent
  {
    Task<List<ReposGitHub>> GetDataGitHubRepositoryAsync(string accountName);
  }
}

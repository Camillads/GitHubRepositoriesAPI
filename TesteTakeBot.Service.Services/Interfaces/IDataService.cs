using System.Threading.Tasks;
using TesteTakeBot.Domain.Models.Components;

namespace TesteTakeBot.Service.Services.Interfaces
{
  public interface IDataService
  {
    Task<CarrosselDinamic> GetDataGitHubRepositoryTakeBlipAsync();
  }
}

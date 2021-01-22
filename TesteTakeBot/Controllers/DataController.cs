using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteTakeBot.Domain.Models.Components;
using TesteTakeBot.Domain.Models.GitHub;
using TesteTakeBot.Service.Services.Interfaces;

namespace TesteTakeBot.Controllers
{
  [ApiController]
  [Route("api/Data")]
  public class DataController : ControllerBase
  {
    private readonly IDataService _dataService;
    public DataController(IDataService dataService)
    {
      _dataService = dataService;
    }

    [Produces("application/json")]
    [Consumes("application/json")]
    [HttpGet]
    public async Task<ActionResult<CarrosselDinamic>> GetDataApiGitHub()
    {
      try
      {
        return await _dataService.GetDataGitHubRepositoryTakeBlipAsync();
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }
  }
}

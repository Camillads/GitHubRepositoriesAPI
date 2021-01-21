using Microsoft.Extensions.DependencyInjection;
using System;
using TesteTakeBot.Infra.CrossCutting.GitHub;
using TesteTakeBot.Infra.CrossCutting.GitHub.Interfaces;
using TesteTakeBot.Service.Services;
using TesteTakeBot.Service.Services.Interfaces;

namespace TesteTakeBot.Infra.Ioc
{
  public static class IocConfig
  {
    public static IServiceProvider ConfigureService(IServiceCollection services)
    {
      ConfigureServices(services);
      ConfigureAgents(services);

      return services.BuildServiceProvider();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
      services
        .AddSingleton<IDataService, DataService>()
        .AddSingleton<IGitHubService, GitHubService>();
    }

    private static void ConfigureAgents(IServiceCollection services)
    {
      services
        .AddSingleton<IGitHubAgent, GitHubAgent>();
    }
  }
}

using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TesteTakeBot.Infra.Ioc;
using TesteTakeBot.Shared.Util;
using TesteTakeBot.Shared.Util.Interfaces;

namespace TesteTakeBot
{
  public class Startup
  {
    public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
    {
      Configuration = configuration;
      _webHostEnvironment = webHostEnvironment;
      _appSettings = new AppSettings(Configuration);
    }

    public IConfiguration Configuration { get; }
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly AppSettings _appSettings;

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddSingleton<IAppSettings>(_appSettings);

      services.AddMvc()
          .AddFluentValidation(
              fvc => fvc.RegisterValidatorsFromAssemblyContaining<Startup>());

      IocConfig.ConfigureService(services);

      services.AddControllers()
        .AddNewtonsoftJson();

      services.AddMemoryCache();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}

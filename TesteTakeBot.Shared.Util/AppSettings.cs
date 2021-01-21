using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTakeBot.Shared.Util.Interfaces;

namespace TesteTakeBot.Shared.Util
{
  public class AppSettings : IAppSettings
  {
    private readonly IConfigurationSection _configurationApp;

    public AppSettings(IConfiguration configuration)
    {
      _configurationApp = configuration.GetSection("AppConfiguration");
    }

    public string AccessTokenGitHub => _configurationApp.GetValue<string>("AccessTokenGitHub");
    public string UrlBaseGitHub => _configurationApp.GetValue<string>("UrlBaseGitHub");
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTakeBot.Shared.Util.Interfaces
{
  public interface IAppSettings
  {
    string AccessTokenGitHub { get; }
    string UrlBaseGitHub { get; }
  }
}

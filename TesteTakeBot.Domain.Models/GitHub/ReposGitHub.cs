using Newtonsoft.Json;
using System;

namespace TesteTakeBot.Domain.Models.GitHub
{
  public class Owner
  {
    [JsonProperty("avatar_url", NullValueHandling = NullValueHandling.Ignore)]
    public string AvatarUrl { get; set; }
  }

  public class ReposGitHub
  {
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public int id { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("full_name ", NullValueHandling = NullValueHandling.Ignore)]
    public string FullName { get; set; }

    [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
    public Owner Owner { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime UpdatedAt { get; set; }

    [JsonProperty("pushed_at", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime PushedAt { get; set; }

    [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
    public string Language { get; set; }
  }
}

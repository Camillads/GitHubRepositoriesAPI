using Newtonsoft.Json;
using System.Collections.Generic;

namespace TesteTakeBot.Domain.Models.Components
{
  public class CarrosselDinamic
  {
    [JsonProperty("itemType", NullValueHandling = NullValueHandling.Ignore)]
    public string ItemType { get; set; }

    [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
    public List<Item> Items { get; set; }

    public CarrosselDinamic()
    {
      ItemType = "application/vnd.lime.document-select+json";
    }
  }

  public class Val
  {
    [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
    public string Title { get; set; }

    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text { get; set; }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
    public string Uri { get; set; }

    [JsonProperty("key1", NullValueHandling = NullValueHandling.Ignore)]
    public string Key1 { get; set; }

    [JsonProperty("key2", NullValueHandling = NullValueHandling.Ignore)]
    public string Key2 { get; set; }

    [JsonProperty("key3", NullValueHandling = NullValueHandling.Ignore)]
    public string Key3 { get; set; }

    [JsonProperty("key4", NullValueHandling = NullValueHandling.Ignore)]
    public string Key4 { get; set; }

    [JsonProperty("key5", NullValueHandling = NullValueHandling.Ignore)]
    public string Key5 { get; set; }

    [JsonProperty("key6", NullValueHandling = NullValueHandling.Ignore)]
    public string Key6 { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public Val Value { get; set; }
  }

  public class Header
  {
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public Val Value { get; set; }
  }

  public class Label
  {
    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public object Value { get; set; }
  }

  public class Option
  {
    [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
    public Label Label { get; set; }

    [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
    public Val Value { get; set; }
  }

  public class Item
  {
    [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
    public Header Header { get; set; }

    [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
    public List<Option> Options { get; set; }
  }
}

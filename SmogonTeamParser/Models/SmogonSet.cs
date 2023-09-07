using System.Text.Json.Serialization;

namespace SmogonTeamParser;

public class SmogonSet
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("ability")]
    public string Ability { get; set; }

    [JsonPropertyName("item")]
    public string Item { get; set; }

    [JsonPropertyName("nature")]
    public string Nature { get; set; }

    [JsonPropertyName("ivs")]
    public StatValues Ivs { get; set; }

    [JsonPropertyName("evs")]
    public StatValues Evs { get; set; }

    [JsonPropertyName("moves")]
    public string[] Moves { get; set; }
}
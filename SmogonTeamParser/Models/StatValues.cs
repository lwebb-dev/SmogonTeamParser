using System.Text.Json.Serialization;

namespace SmogonTeamParser
{
    public class StatValues
    {
        [JsonPropertyName("hp")]
        public int Health { get; set; }

        [JsonPropertyName("at")]
        public int Attack { get; set; }

        [JsonPropertyName("df")]
        public int Defense { get; set; }

        [JsonPropertyName("sa")]
        public int SpecialAttack { get; set; }

        [JsonPropertyName("sd")]
        public int SpecialDefense { get; set; }

        [JsonPropertyName("sp")]
        public int Speed { get; set; }
    }
}
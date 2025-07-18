using System.Text.Json.Serialization;

namespace BlazorChallenges.Models 
{
    public class Pokemon
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("base_experience")]
        public int BaseExperience { get; set; }

        public Sprites? Sprites { get; set; }
    }

    public class Sprites
    {
        [JsonPropertyName("front_default")]
        public string? Front_Default { get; set; }
    }
}
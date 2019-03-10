using Newtonsoft.Json;
using System.Collections.Generic;

namespace PubgNet.Model.Players
{
    public class PlayerData
    {
        [JsonProperty("data")]
        public List<Player> Players { get; set; }
    }

    public class Player
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("relationships")]
        public Relationships Relationships { get; set; }
    }

    public class Attributes
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shardId")]
        public string ShardId { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("patchVersion")]
        public string PatchVersion { get; set; }

        [JsonProperty("titleId")]
        public string TitleId { get; set; }
    }

    public class Stats
    {
        // null
    }

    public class Relationships
    {
        [JsonProperty("matches")]
        public Matches Matches { get; set; }
    }

    public class Assets
    {
        // null
    }

    public class Matches
    {
        [JsonProperty("data")]
        public List<MatchData> Data { get; set; }
    }

    public class MatchData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

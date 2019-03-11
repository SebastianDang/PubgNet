using Newtonsoft.Json;
using System.Collections.Generic;

namespace PubgNet.Model
{
    public class PlayersRoot
    {
        [JsonProperty("data")]
        public List<PlayerObject> Players { get; set; }
    }

    public class PlayerObject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public PlayerAttributes Attributes { get; set; }

        [JsonProperty("relationships")]
        public PlayerRelationships Relationships { get; set; }
    }

    public class PlayerAttributes
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shardId")]
        public string ShardId { get; set; }

        [JsonProperty("stats")]
        public PlayerStats Stats { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("patchVersion")]
        public string PatchVersion { get; set; }

        [JsonProperty("titleId")]
        public string TitleId { get; set; }
    }

    public class PlayerStats
    {
        // null
    }

    public class PlayerRelationships
    {
        [JsonProperty("assets")]
        public PlayerAssets Assets { get; set;}

        [JsonProperty("matches")]
        public PlayerMatches Matches { get; set; }
    }

    public class PlayerAssets
    {
        [JsonProperty("data")]
        public List<PlayerAssetsData> Data { get; set; }
    }

    public class PlayerAssetsData
    {
        // null
    }

    public class PlayerMatches
    {
        [JsonProperty("data")]
        public List<PlayerMatchData> Data { get; set; }
    }

    public class PlayerMatchData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

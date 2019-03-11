using Newtonsoft.Json;
using System.Collections.Generic;

namespace PubgNet.Model
{
    public class SeasonsRoot
    {
        [JsonProperty("data")]
        public List<SeasonObject> Seasons { get; set; }
    }

    public class SeasonObject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public SeasonAttributes Attributes { get; set; }
    }

    public class SeasonAttributes
    {
        [JsonProperty("isCurrentSeason")]
        public bool IsCurrentSeason { get; set; }

        [JsonProperty("isOffSeason")]
        public bool IsOffSeason { get; set; }
    }
}

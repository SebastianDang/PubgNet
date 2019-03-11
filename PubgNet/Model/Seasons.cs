using Newtonsoft.Json;
using System.Collections.Generic;

namespace PubgNet.Model
{
    public class SeasonsRoot
    {
        [JsonProperty]
        public List<SeasonData> Data { get; set; }
        [JsonProperty]
        public SeasonLinks Links { get; set; }
    }

    public class SeasonData
    {
        [JsonProperty]
        public string Type { get; set; }
        [JsonProperty]
        public string Id { get; set; }
        [JsonProperty]
        public SeasonAttributes Attributes { get; set; }
    }

    public class SeasonAttributes
    {
        [JsonProperty]
        public bool IsCurrentSeason { get; set; }
        [JsonProperty]
        public bool IsOffSeason { get; set; }
    }

    public class SeasonLinks
    {
        [JsonProperty]
        public string Self { get; set; }
    }
}

using Newtonsoft.Json;

namespace PubgNet.Model.Base
{
    public class Base
    {
        [JsonProperty]
        string Type { get; set; }

        [JsonProperty]
        string Id { get; set; }
    }
}

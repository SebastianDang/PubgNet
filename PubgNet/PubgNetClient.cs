#define DEBUG_CLIENT // Use this to print http requests and responses to console

using Newtonsoft.Json;
using PubgNet.Http;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PubgNet
{
    // Entry point for PubgNet client.
    // Creates a http client using your api key.
    public class PubgNetClient
    {
        // Private variables.
        private readonly HttpHandler m_HttpHandler;
        private readonly string m_Platform = "steam"; // By default, steam

        // Checks if the api key exists, then constructs a http handler to manage requests.
        public PubgNetClient(string api_key)
        {
            if (string.IsNullOrEmpty(api_key)) throw new ArgumentException("Client : Api Key cannot be empty.");
            m_HttpHandler = new HttpHandler("https://api.pubg.com/", api_key, "application/vnd.api+json");
        }

        // Gets a list of players by username(s).
        // According to the api, this can only get data for up to 6 players.
        public async Task<PubgNet.Model.Players.PlayersRoot> GetPlayersByUsernames(string[] playerNames)
        {
#if DEBUG_CLIENT
            if (playerNames.Length >= 6)
            {
                string valid_playerNames = string.Join(",", playerNames.Take(6).ToArray());
                Console.WriteLine($"Client: (Warning) This will only return data for {valid_playerNames}");
            }
#endif
            string input_playerNames = string.Join(",", playerNames);
            string request = $"shards/{m_Platform}/players?filter[playerNames]={input_playerNames}";
            string response = await m_HttpHandler.RequestAsync(request);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.Players.PlayersRoot>(response);
            return json_object;
        }

        // Gets a list of players by id(s).
        // According to the api, this can only get data for up to 6 players.
        public async Task<PubgNet.Model.Players.PlayersRoot> GetPlayersByIds(string[] playerIds)
        {
#if DEBUG_CLIENT
            if (playerIds.Length >= 6)
            {
                string valid_playerIds = string.Join(",", playerIds.Take(6).ToArray());
                Console.WriteLine($"Client: (Warning) This will only return data for {valid_playerIds}");
            }
#endif
            string input_playerIds = string.Join(",", playerIds);
            string request = $"shards/{m_Platform}/players?filter[playerIds]={input_playerIds}";
            string response = await m_HttpHandler.RequestAsync(request);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.Players.PlayersRoot>(response);
            return json_object;
        }

        // Gets a list of all seasons.
        public async Task<PubgNet.Model.Seasons.SeasonsRoot> GetSeasons()
        {
            string request = $"shards/{m_Platform}/seasons";
            string response = await m_HttpHandler.RequestAsync(request);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.Seasons.SeasonsRoot>(response);
            return json_object;
        }

        // Get seasons stats for a specific player and seasons.
        public async Task<PubgNet.Model.SeasonStats.SeasonStatsRoot> GetSeasonStatsForPlayer(string accountId, string seasonId)
        {
            string request = $"shards/{m_Platform}/players/{accountId}/seasons/{seasonId}";
            string response = await m_HttpHandler.RequestAsync(request);
            var json_object = JsonConvert.DeserializeObject<PubgNet.Model.SeasonStats.SeasonStatsRoot>(response);
            return json_object;
        }
    }
}

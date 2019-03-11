using Newtonsoft.Json;
using System.Collections.Generic;

namespace PubgNet.Model
{
    public class StatsRoot
    {
        [JsonProperty("data")]
        public StatsObject Stats { get; set; }
    }

    public class StatsObject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public StatsAttributes Attributes { get; set; }

        [JsonProperty("relationships")]
        public StatsRelationships Relationships { get; set; }
    }

    public class StatsAttributes
    {
        [JsonProperty("gameModeStats")]
        public GameModeObject GameModeStats { get; set; }
    }

    public class GameModeObject
    {
        [JsonProperty("solo")]
        public GameModeData Solo { get; set; }

        [JsonProperty("solo-fpp")]
        public GameModeData SoloFpp { get; set; }

        [JsonProperty("duo")]
        public GameModeData Duo { get; set; }

        [JsonProperty("duo-fpp")]
        public GameModeData DuoFpp { get; set; }

        [JsonProperty("squad")]
        public GameModeData Squad { get; set; }

        [JsonProperty("squad-fpp")]
        public GameModeData SquadFpp { get; set; }
    }

    public class GameModeData
    {
        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("bestRankPoint")]
        public float BestRankPoints { get; set; }

        [JsonProperty("boosts")]
        public int Boosts { get; set; }

        [JsonProperty("dBNOs")]
        public int DBNOs { get; set; }

        [JsonProperty("dailyKills")]
        public int DailyKills { get; set; }

        [JsonProperty("damageDealt")]
        public float DamageDealt { get; set; }

        [JsonProperty("days")]
        public int Days { get; set; }

        [JsonProperty("dailyWins")]
        public int DailyWins { get; set; }

        [JsonProperty("headshotKills")]
        public int HeadshotKills { get; set; }

        [JsonProperty("heals")]
        public int Heals { get; set; }

        [JsonProperty("killPoints")]
        public float KillPoints { get; set; }

        [JsonProperty("kills")]
        public int Kills { get; set; }

        [JsonProperty("longestKill")]
        public float LongestKill { get; set; }

        [JsonProperty("longestTimeSurvived")]
        public float LongestTimeSurvived { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("maxKillStreaks")]
        public int MaxKillStreaks { get; set; }

        [JsonProperty("mostSurvivalTime")]
        public float MostSurvivalTime { get; set; }

        [JsonProperty("RankPoints")]
        public float RankPoints { get; set; }

        [JsonProperty("RankPointsTitle")]
        public string RankPointsTitle { get; set; }

        [JsonProperty("revives")]
        public int Revives { get; set; }

        [JsonProperty("rideDistance")]
        public float RideDistance { get; set; }

        [JsonProperty("roadKills")]
        public int RoadKills { get; set; }

        [JsonProperty("roundMostKills")]
        public int RoundMostKills { get; set; }

        [JsonProperty("roundsPlayed")]
        public int RoundsPlayed { get; set; }

        [JsonProperty("suicides")]
        public int Suicides { get; set; }

        [JsonProperty("swimDistance")]
        public float SwimDistance { get; set; }

        [JsonProperty("teamKills")]
        public int TeamKills { get; set; }

        [JsonProperty("timeSurvived")]
        public float TimeSurvived { get; set; }

        [JsonProperty("top10s")]
        public int Top10s { get; set; }

        [JsonProperty("vehicleDestroys")]
        public int VehicleDestroys { get; set; }

        [JsonProperty("walkDistance")]
        public float WalkDistance { get; set; }

        [JsonProperty("weaponAcquired")]
        public int WeaponAcquired { get; set; }

        [JsonProperty("weeklyKills")]
        public int WeeklyKills { get; set; }

        [JsonProperty("weeklyWins")]
        public int WeeklyWins { get; set; }

        [JsonProperty("winPoints")]
        public float WinPoints { get; set; }

        [JsonProperty("winRatio")]
        public float WinRatio { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }

    public class StatsRelationships
    {
        [JsonProperty("player")]
        public StatsPlayer Player { get; set; }

        [JsonProperty("matchesSolo")]
        public StatsMatches MatchesSolo { get; set; }

        [JsonProperty("matchesSoloFpp")]
        public StatsMatches MatchesSoloFpp { get; set; }

        [JsonProperty("matchesDuo")]
        public StatsMatches MatchesDuo { get; set; }

        [JsonProperty("matchesDuoFpp")]
        public StatsMatches MatchesDuoFpp { get; set; }

        [JsonProperty("matchesSquad")]
        public StatsMatches MatchesSquad { get; set; }

        [JsonProperty("matchesSquadFpp")]
        public StatsMatches MatchesSquadFpp { get; set; }
    }

    public class StatsPlayer
    {
        [JsonProperty("data")]
        public StatsPlayerData Data { get; set; }
    }

    public class StatsPlayerData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class StatsMatches
    {
        [JsonProperty("data")]
        public List<StatsMatch> Matches { get; set; }
    }

    public class StatsMatch
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

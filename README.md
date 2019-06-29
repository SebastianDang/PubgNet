# PubgNet
.Net wrapper for the official PUBG Developer API.
Documentation can be found at https://documentation.pubg.com/.

## Usage

### PubgNetClient

Create a pubg net client by supplying the `api key` and `platform`. By default, the platform is 'steam'.

``PubgNetClient('your-api-key', 'steam')``

* Note : The functions below will only return available information from the specified platform.

### Players

Get a collection of up to 6 players using either `player names` or `player ids`.

``GetPlayersByUsernames(player1, ...)``
``GetPlayersByIds(playerId, ... )``

### Season Stats

Get a list of available seasons.

``GetSeasons()``

Get season information for a single player using `player id` and `season id`.

``GetSeasonStatsForPlayer(playerId, seasonId)``

### Lifetime Stats

Get lifetime stats for a single player using `player id`.

``GetLifetimeStatsForPlayer(playerId)``

### Matches

Get a single match using `id`.

``GetMatch(id)``

### Leaderboards

Get the leaderboard for the specified game mode using `game mode`. To view a specific page, use `page`.

``GetLeaderboards(gameMode)``
``GetLeaderboards(gameMode,page)``

### Tournaments

Get the list of available tournaments.

``GetTournaments()``

Get information for a single tournament using `id`.

``GetTournament(id)``

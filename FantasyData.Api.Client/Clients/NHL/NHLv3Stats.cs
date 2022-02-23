using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NHL;

namespace FantasyData.Api.Client;

public class NHLv3StatsClient : BaseClient
{
    public NHLv3StatsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Are Games In Progress Asynchronous
    /// </summary>
    public Task<bool> GetAreAnyGamesInProgressAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<bool>("/v3/nhl/stats/{format}/AreAnyGamesInProgress", parameters);
    }

    /// <summary>
    /// Get Box Score Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
    public Task<BoxScore> GetBoxScoreAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<BoxScore>("/v3/nhl/stats/{format}/BoxScore/{gameid}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BoxScore>>("/v3/nhl/stats/{format}/BoxScores/{date}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Delta Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresDeltaAsync(string date, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date), new("minutes", minutes)};
        return this.GetAsync<List<BoxScore>>("/v3/nhl/stats/{format}/BoxScoresDelta/{date}/{minutes}", parameters);
    }

    /// <summary>
    /// Get Current Season Asynchronous
    /// </summary>
    public Task<Season> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<Season>("/v3/nhl/stats/{format}/CurrentSeason", parameters);
    }

    /// <summary>
    /// Get DFS Slates by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-DEC-01</code>, <code>2018-FEB-15</code>.</param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/nhl/stats/{format}/DfsSlatesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/nhl/stats/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Line Combinations by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
    public Task<List<TeamLine>> GetLinesBySeasonAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<TeamLine>>("/v3/nhl/stats/{format}/LinesBySeason/{season}", parameters);
    }

    /// <summary>
    /// Get News Asynchronous
    /// </summary>
    public Task<List<News>> GetNewsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<News>>("/v3/nhl/stats/{format}/News", parameters);
    }

    /// <summary>
    /// Get News by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the news. Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
    public Task<List<News>> GetNewsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<News>>("/v3/nhl/stats/{format}/NewsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get News by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
    public Task<List<News>> GetNewsByPlayerIDAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<News>>("/v3/nhl/stats/{format}/NewsByPlayerID/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Details by Active Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/nhl/stats/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Player Details by Free Agent Asynchronous
    /// </summary>
    public Task<List<Player>> GetFreeAgentsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/nhl/stats/{format}/FreeAgents", parameters);
    }

    /// <summary>
    /// Get Player Details by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000007</code>.</param>
    public Task<Player> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<Player>("/v3/nhl/stats/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-OCT-31</code>, <code>2018-FEB-15</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGame>>("/v3/nhl/stats/{format}/PlayerGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Player Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code>.</param>
    public Task<PlayerGame> GetPlayerGameStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerGame>("/v3/nhl/stats/{format}/PlayerGameStatsByPlayer/{date}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeason>>("/v3/nhl/stats/{format}/PlayerSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Player Season Stats By Player Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code>.</param>
    public Task<PlayerSeason> GetPlayerSeasonStatsByPlayerAsync(string season, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerSeason>("/v3/nhl/stats/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Stats by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("team", team)};
        return this.GetAsync<List<PlayerSeason>>("/v3/nhl/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}",
            parameters);
    }

    /// <summary>
    /// Get Players by Team Asynchronous
    /// </summary>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
    public Task<List<Player>> GetPlayersAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<Player>>("/v3/nhl/stats/{format}/Players/{team}", parameters);
    }

    /// <summary>
    /// Get Schedules Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
    public Task<List<Game>> GetGamesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Game>>("/v3/nhl/stats/{format}/Games/{season}", parameters);
    }

    /// <summary>
    /// Get Stadiums Asynchronous
    /// </summary>
    public Task<List<Stadium>> GetStadiumsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Stadium>>("/v3/nhl/stats/{format}/Stadiums", parameters);
    }

    /// <summary>
    /// Get Standings Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
    public Task<List<Standing>> GetStandingsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Standing>>("/v3/nhl/stats/{format}/Standings/{season}", parameters);
    }

    /// <summary>
    /// Get Team Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
    public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<TeamGame>>("/v3/nhl/stats/{format}/TeamGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<TeamSeason>>("/v3/nhl/stats/{format}/TeamSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Team Stats Allowed by Position Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
    public Task<List<TeamSeason>> GetTeamStatsAllowedByPositionAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<TeamSeason>>("/v3/nhl/stats/{format}/TeamStatsAllowedByPosition/{season}",
            parameters);
    }

    /// <summary>
    /// Get Teams (Active) Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/nhl/stats/{format}/teams", parameters);
    }

    /// <summary>
    /// Get Teams (All) Asynchronous
    /// </summary>
    public Task<List<Team>> GetAllTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/nhl/stats/{format}/AllTeams", parameters);
    }

    /// <summary>
    /// Get Player Game Logs By Season Asynchronous
    /// </summary>
    /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000651</code>.</param>
    /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
    public Task<List<PlayerGame>> GetPlayerGameStatsBySeasonAsync(string season, int playerid, string numberofgames)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("playerid", playerid.ToString()), new("numberofgames", numberofgames)
        };
        return this.GetAsync<List<PlayerGame>>(
            "/v3/nhl/stats/{format}/PlayerGameStatsBySeason/{season}/{playerid}/{numberofgames}", parameters);
    }
}
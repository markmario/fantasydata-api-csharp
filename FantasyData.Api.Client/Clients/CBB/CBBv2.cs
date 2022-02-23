using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CBB;

namespace FantasyData.Api.Client;

public class CBBv2Client : BaseClient
{
    public CBBv2Client(string apiKey, HttpClient client) : base(apiKey, client)
    {
    }

    /// <summary>
    /// Get Are Games In Progress Asynchronous
    /// </summary>
    public Task<bool> GetAreAnyGamesInProgressAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<bool>("/cbb/v2/{format}/AreAnyGamesInProgress", parameters);
    }

    /// <summary>
    /// Get Box Score Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>14620</code> or <code>16905</code></param>
    public Task<BoxScore> GetBoxScoreAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<BoxScore>("/cbb/v2/{format}/BoxScore/{gameid}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BoxScore>>("/cbb/v2/{format}/BoxScores/{date}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Delta Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresDeltaAsync(string date, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date), new("minutes", minutes)};
        return this.GetAsync<List<BoxScore>>("/cbb/v2/{format}/BoxScoresDelta/{date}/{minutes}", parameters);
    }

    /// <summary>
    /// Get Current Season Asynchronous
    /// </summary>
    public Task<Season> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<Season>("/cbb/v2/{format}/CurrentSeason", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/cbb/v2/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get League Hierarchy Asynchronous
    /// </summary>
    public Task<List<Conference>> GetLeagueHierarchyAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Conference>>("/cbb/v2/{format}/LeagueHierarchy", parameters);
    }

    /// <summary>
    /// Get Player Details by Active Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/cbb/v2/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Player Details by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
    public Task<Player> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<Player>("/cbb/v2/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Details by Team Asynchronous
    /// </summary>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
    public Task<List<Player>> GetPlayersAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<Player>>("/cbb/v2/{format}/Players/{team}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGame>>("/cbb/v2/{format}/PlayerGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Player Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
    public Task<PlayerGame> GetPlayerGameStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerGame>("/cbb/v2/{format}/PlayerGameStatsByPlayer/{date}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeason>>("/cbb/v2/{format}/PlayerSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Player Season Stats By Player Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
    public Task<PlayerSeason> GetPlayerSeasonStatsByPlayerAsync(string season, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerSeason>("/cbb/v2/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Stats by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("team", team)};
        return this.GetAsync<List<PlayerSeason>>("/cbb/v2/{format}/PlayerSeasonStatsByTeam/{season}/{team}",
            parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>("/cbb/v2/{format}/PlayerGameProjectionStatsByDate/{date}",
            parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Player Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
    public Task<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerGameProjection>(
            "/cbb/v2/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Schedules Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
    public Task<List<Game>> GetGamesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Game>>("/cbb/v2/{format}/Games/{season}", parameters);
    }

    /// <summary>
    /// Get Team Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-FEB-27</code>, <code>2015-SEP-01</code>.</param>
    public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<TeamGame>>("/cbb/v2/{format}/TeamGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<TeamSeason>>("/cbb/v2/{format}/TeamSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/cbb/v2/{format}/teams", parameters);
    }

    /// <summary>
    /// Get Tournament Hierarchy Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
    public Task<Tournament> GetTournamentAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<Tournament>("/cbb/v2/{format}/Tournament/{season}", parameters);
    }
}
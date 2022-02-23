using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client;

public class NBAv3ProjectionsClient : BaseClient
{
    public NBAv3ProjectionsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get DFS Slates by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-DEC-01</code>, <code>2018-FEB-15</code>.</param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/nba/projections/{format}/DfsSlatesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Date (w/ Injuries, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/nba/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Player (w/ Injuries, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
    public Task<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerGameProjection>(
            "/v3/nba/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Projected Player Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
    public Task<List<PlayerSeasonProjection>> GetPlayerSeasonProjectionStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeasonProjection>>(
            "/v3/nba/projections/{format}/PlayerSeasonProjectionStats/{season}", parameters);
    }

    /// <summary>
    /// Get Projected Player Season Stats by Player Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>20000571</code>.</param>
    public Task<PlayerSeasonProjection> GetPlayerSeasonProjectionStatsByPlayerAsync(string season, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerSeasonProjection>(
            "/v3/nba/projections/{format}/PlayerSeasonProjectionStatsByPlayer/{season}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Projected Player Season Stats by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2019</code>, etc.</param>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>MIA</code>, <code>PHI</code>.</param>
    public Task<List<PlayerSeasonProjection>> GetPlayerSeasonProjectionStatsByTeamAsync(string season, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("team", team)};
        return this.GetAsync<List<PlayerSeasonProjection>>(
            "/v3/nba/projections/{format}/PlayerSeasonProjectionStatsByTeam/{season}/{team}", parameters);
    }

    /// <summary>
    /// Get Starting Lineups by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2021-OCT-12</code>, <code>2021-DEC-09</code>.</param>
    public Task<List<StartingLineups>> GetStartingLineupsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<StartingLineups>>("/v3/nba/projections/{format}/StartingLineupsByDate/{date}",
            parameters);
    }
}
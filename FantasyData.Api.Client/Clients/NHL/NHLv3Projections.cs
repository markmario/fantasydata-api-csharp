using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NHL;

namespace FantasyData.Api.Client;

public class NHLv3ProjectionsClient : BaseClient
{
    public NHLv3ProjectionsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get DFS Slates by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-DEC-01</code>, <code>2018-FEB-15</code>.</param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/nhl/projections/{format}/DfsSlatesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Date (w/ Injuries, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/nhl/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Player (w/ Injuries, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-JAN-31</code>, <code>2017-OCT-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code>.</param>
    public Task<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerGameProjection>(
            "/v3/nhl/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Starting Goaltenders by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2021-OCT-12</code>, <code>2021-DEC-09</code>.</param>
    public Task<List<StartingGoaltenders>> GetStartingGoaltendersByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<StartingGoaltenders>>("/v3/nhl/projections/{format}/StartingGoaltendersByDate/{date}",
            parameters);
    }
}
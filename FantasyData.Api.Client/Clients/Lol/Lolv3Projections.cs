using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Lol;

namespace FantasyData.Api.Client;

public class Lolv3ProjectionsClient : BaseClient
{
    public Lolv3ProjectionsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Projected Player Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Example: <code>2019-01-20</code></param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/lol/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Player Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Example: <code>2019-01-20</code></param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100001500</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date),
            new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/lol/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Dfs Slates By Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/lol/projections/{format}/DfsSlatesByDate/{date}", parameters);
    }
}
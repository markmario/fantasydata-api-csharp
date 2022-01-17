using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Csgo;

namespace FantasyData.Api.Client;

public partial class Csgov3ProjectionsClient : BaseClient
{
    public Csgov3ProjectionsClient(string apiKey) : base(apiKey)
    {
    }

    public Csgov3ProjectionsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Projected Player Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/csgo/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Player Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100000576</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date),
            new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/csgo/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Dfs Slates By Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</br></param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/csgo/projections/{format}/DfsSlatesByDate/{date}", parameters);
    }
}
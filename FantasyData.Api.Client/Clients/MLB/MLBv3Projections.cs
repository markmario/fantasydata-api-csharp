using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client;

public partial class MLBv3ProjectionsClient : BaseClient
{
    public MLBv3ProjectionsClient(string apiKey) : base(apiKey)
    {
    }

    public MLBv3ProjectionsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get DFS Slates by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the slates. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/mlb/projections/{format}/DfsSlatesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Date (w/ Injuries, Lineups, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/mlb/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date),
            new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/mlb/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Projected Player Season Stats (with ADP) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>.</param>
    public Task<List<PlayerSeasonProjection>> GetPlayerSeasonProjectionStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeasonProjection>>(
            "/v3/mlb/projections/{format}/PlayerSeasonProjectionStats/{season}", parameters);
    }
}
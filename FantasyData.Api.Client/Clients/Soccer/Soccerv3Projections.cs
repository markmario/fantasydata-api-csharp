using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client;

public class Soccerv3ProjectionsClient : BaseClient
{
    public Soccerv3ProjectionsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Projected Player Game Stats by Competition (w/ DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByCompetitionAsync(string competition,
        string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition), new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/soccer/projections/{format}/PlayerGameProjectionStatsByCompetition/{competition}/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Date (w/ DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/soccer/projections/{format}/PlayerGameProjectionStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Player (w/ DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/soccer/projections/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Dfs Slates By Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2020-02-18</code></param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/soccer/projections/{format}/DfsSlatesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Upcoming Dfs Slates By Competition Asynchronous
    /// </summary>
    /// <param name="competitionId">The Competition Id. Examples: <code>3</code></param>
    public Task<List<DfsSlate>> GetUpcomingDfsSlatesByCompetitionAsync(string competitionId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competitionId", competitionId)};
        return this.GetAsync<List<DfsSlate>>(
            "/v3/soccer/projections/{format}/UpcomingDfsSlatesByCompetition/{competitionId}", parameters);
    }
}
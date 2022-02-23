using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CWBB;

namespace FantasyData.Api.Client;

public class CWBBv3ScoresClient : BaseClient
{
    public CWBBv3ScoresClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Are Any Games In Progress Asynchronous
    /// </summary>
    public Task<bool> GetAreAnyGamesInProgressAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<bool>("/v3/cwbb/scores/{format}/AreAnyGamesInProgress", parameters);
    }

    /// <summary>
    /// Get Current Season Asynchronous
    /// </summary>
    public Task<Season> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<Season>("/v3/cwbb/scores/{format}/CurrentSeason", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2020-FEB-27</code>, <code>2019-DEC-01</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/cwbb/scores/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get League Hierarchy (Conferences and Teams) Asynchronous
    /// </summary>
    public Task<List<Conference>> GetLeagueHierarchyAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Conference>>("/v3/cwbb/scores/{format}/LeagueHierarchy", parameters);
    }

    /// <summary>
    /// Get Schedules Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2020</code>, <code>2020PRE</code>, <code>2020POST</code>, <code>2019</code>, etc.</param>
    public Task<List<Game>> GetGamesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Game>>("/v3/cwbb/scores/{format}/Games/{season}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/cwbb/scores/{format}/Teams", parameters);
    }
}
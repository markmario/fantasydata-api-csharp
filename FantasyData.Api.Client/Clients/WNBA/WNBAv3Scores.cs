using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.WNBA;

namespace FantasyData.Api.Client;

public class WNBAv3ScoresClient : BaseClient
{
    public WNBAv3ScoresClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Are Games In Progress Asynchronous
    /// </summary>
    public Task<bool> GetAreAnyGamesInProgressAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<bool>("/v3/wnba/scores/{format}/AreAnyGamesInProgress", parameters);
    }


    /// <summary>
    /// Get Current Season Asynchronous
    /// </summary>
    public Task<Season> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<Season>("/v3/wnba/scores/{format}/CurrentSeason", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2019-MAY-16</code>, <code>2019-MAY-25</code>, etc.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/wnba/scores/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    /// <param name="Season">Year of the season (with optional season type). Examples: <code>2019</code>, <code>2019PRE</code>, <code>2019POST</code>, <code>2019REG</code>, etc.</param>
    public Task<List<Game>> GetGamesAsync(string Season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("Season", Season)};
        return this.GetAsync<List<Game>>("/v3/wnba/scores/{format}/Games/{Season}", parameters);
    }

    /// <summary>
    /// Get Stadiums Asynchronous
    /// </summary>
    public Task<List<Stadium>> GetStadiumsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Stadium>>("/v3/wnba/scores/{format}/Stadiums", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/wnba/scores/{format}/Teams", parameters);
    }
}
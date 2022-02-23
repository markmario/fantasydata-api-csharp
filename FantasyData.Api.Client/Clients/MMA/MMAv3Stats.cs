using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MMA;

namespace FantasyData.Api.Client;

public class MMAv3StatsClient : BaseClient
{
    public MMAv3StatsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Event Asynchronous
    /// </summary>
    /// <param name="eventid">The unique ID of this event. Examples: <code>51</code>, <code>52</code>, etc.</param>
    public Task<EventDetail> GetEventAsync(string eventid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("eventid", eventid)};
        return this.GetAsync<EventDetail>("/v3/mma/stats/{format}/Event/{eventid}", parameters);
    }

    /// <summary>
    /// Get Fight Asynchronous
    /// </summary>
    /// <param name="fightid">The unique ID of this fight. Examples: <code>1100</code>, etc.</param>
    public Task<FightDetail> GetFightAsync(string fightid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("fightid", fightid)};
        return this.GetAsync<FightDetail>("/v3/mma/stats/{format}/Fight/{fightid}", parameters);
    }

    /// <summary>
    /// Get Fighter Asynchronous
    /// </summary>
    /// <param name="fighterid">Each fighter has a unique ID assigned by FantasyData. Fighter IDs can be determined by pulling player related data. Example: <code>140000098</code></param>
    public Task<Fighter> GetFighterAsync(string fighterid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("fighterid", fighterid)};
        return this.GetAsync<Fighter>("/v3/mma/stats/{format}/Fighter/{fighterid}", parameters);
    }

    /// <summary>
    /// Get Fighters Asynchronous
    /// </summary>
    public Task<List<Fighter>> GetFightersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Fighter>>("/v3/mma/stats/{format}/Fighters", parameters);
    }

    /// <summary>
    /// Get Leagues Asynchronous
    /// </summary>
    public Task<List<League>> GetLeaguesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<League>>("/v3/mma/stats/{format}/Leagues", parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    /// <param name="league">The name of the league. Examples: <code>UFC</code>, etc</param>
    /// <param name="season">Year of the season. Examples: <code>2019</code>, <code>2020</code>, etc.</param>
    public Task<List<Event>> GetScheduleAsync(string league, string season)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("league", league),
            new("season", season)
        };
        return this.GetAsync<List<Event>>("/v3/mma/stats/{format}/Schedule/{league}/{season}", parameters);
    }
}
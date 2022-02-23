using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client;

public class NFLv3PlayByPlayClient : NFLv3StatsClient
{
    public NFLv3PlayByPlayClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }
    /// <summary>
    /// Get Play By Play Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="hometeam">Abbreviation of the home team. Example: <code>WAS</code>.</param>
    public Task<PlayByPlay> GetPlayByPlayAsync(string season, int week, string hometeam)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("hometeam", hometeam)
        };
        return this.GetAsync<PlayByPlay>("/v3/nfl/pbp/{format}/PlayByPlay/{season}/{week}/{hometeam}", parameters);
    }

    /// <summary>
    /// Get Play By Play Simulation Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
    /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
    public Task<List<PlayByPlay>> GetSimulatedPlayByPlayAsync(string season, int week, string minutes,
        string numberofplays)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("week", week.ToString()),
            new("minutes", minutes),
            new("numberofplays", numberofplays)
        };
        return this.GetAsync<List<PlayByPlay>>("/v3/nfl/pbp/{format}/SimulatedPlayByPlay/{numberofplays}", parameters);
    }

    /// <summary>
    /// Get Play By Play Delta Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
    public Task<List<PlayByPlay>> GetPlayByPlayDeltaAsync(string season, int week, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("minutes", minutes)
        };
        return this.GetAsync<List<PlayByPlay>>("/v3/nfl/pbp/{format}/PlayByPlayDelta/{season}/{week}/{minutes}",
            parameters);
    }
}
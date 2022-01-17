using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client;

public class SampleClient : BaseClient
{
    public SampleClient(string apiKey) : base(apiKey) { }
    public SampleClient(Guid apiKey) : base(apiKey) { }

    public async Task<IList<Team>> GetTeamsAync()
    {
        return await this.GetAsync<IList<Team>>("/v3/nfl/stats/json/teams");
    }

    /// <summary>
    /// Summary description
    /// </summary>
    /// <param name="season">season description 1</param>
    /// <param name="week">week description 2</param>
    public Task<IList<Score>> GetScoresByWeekAsync(string season, string week)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("format", "json"),
            new("season", season),
            new("week", week)
        };
        return
            this.GetAsync<IList<Score>>("/v3/nfl/stats/{format}/ScoresByWeek/{season}/{week}", parameters);
    }
}
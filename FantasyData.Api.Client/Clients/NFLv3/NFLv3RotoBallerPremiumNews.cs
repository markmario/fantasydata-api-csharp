using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client;

public partial class NFLv3RotoBallerPremiumNewsClient : BaseClient
{
    public NFLv3RotoBallerPremiumNewsClient(string apiKey) : base(apiKey)
    {
    }

    public NFLv3RotoBallerPremiumNewsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Premium News Asynchronous
    /// </summary>
    public Task<List<News>> GetRotoBallerPremiumNewsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNews", parameters);
    }

    /// <summary>
    /// Get Premium News by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
    public Task<List<News>> GetRotoBallerPremiumNewsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByDate/{date}",
            parameters);
    }

    /// <summary>
    /// Get Premium News by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
    public Task<List<News>> GetRotoBallerPremiumNewsByPlayerIDAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByPlayerID/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Premium News by Team Asynchronous
    /// </summary>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<News>> GetRotoBallerPremiumNewsByTeamAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<News>>("/v3/nfl/news-rotoballer/{format}/RotoBallerPremiumNewsByTeam/{team}",
            parameters);
    }
}
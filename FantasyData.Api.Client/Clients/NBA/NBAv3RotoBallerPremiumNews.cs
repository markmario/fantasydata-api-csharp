﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client;

public partial class NBAv3RotoBallerPremiumNewsClient : BaseClient
{
    public NBAv3RotoBallerPremiumNewsClient(string apiKey) : base(apiKey)
    {
    }

    public NBAv3RotoBallerPremiumNewsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Premium News Asynchronous
    /// </summary>
    public Task<List<News>> GetRotoBallerPremiumNewsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<News>>("/v3/nba/news-rotoballer/{format}/RotoBallerPremiumNews", parameters);
    }

    /// <summary>
    /// Get Premium News by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
    public Task<List<News>> GetRotoBallerPremiumNewsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<News>>("/v3/nba/news-rotoballer/{format}/RotoBallerPremiumNewsByDate/{date}",
            parameters);
    }

    /// <summary>
    /// Get Premium News by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
    public Task<List<News>> GetRotoBallerPremiumNewsByPlayerIDAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<News>>("/v3/nba/news-rotoballer/{format}/RotoBallerPremiumNewsByPlayerID/{playerid}",
            parameters);
    }
}
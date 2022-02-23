using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client;

public class NFLv3RotoBallerArticlesClient : BaseClient
{
    public NFLv3RotoBallerArticlesClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get RotoBaller Articles Asynchronous
    /// </summary>
    public Task<List<Article>> GetRotoBallerArticlesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Article>>("/v3/nfl/articles-rotoballer/{format}/RotoBallerArticles", parameters);
    }

    /// <summary>
    /// Get RotoBaller Articles by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
    public Task<List<Article>> GetRotoBallerArticlesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Article>>("/v3/nfl/articles-rotoballer/{format}/RotoBallerArticlesByDate/{date}",
            parameters);
    }

    /// <summary>
    /// Get RotoBaller Articles by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>10000507</code>.</param>
    public Task<List<Article>> GetRotoBallerArticlesByPlayerIDAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<Article>>(
            "/v3/nfl/articles-rotoballer/{format}/RotoBallerArticlesByPlayerID/{playerid}", parameters);
    }
}
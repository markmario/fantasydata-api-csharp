using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NBA;

namespace FantasyData.Api.Client;

public class NBAv3HeadshotsClient : BaseClient
{
    public NBAv3HeadshotsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Headshots Asynchronous
    /// </summary>
    public Task<List<Headshot>> GetHeadshotsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Headshot>>("/v3/nba/headshots/{format}/Headshots", parameters);
    }
}
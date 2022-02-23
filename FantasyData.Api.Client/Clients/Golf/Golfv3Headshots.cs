using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Golf;

namespace FantasyData.Api.Client;

public class Golfv3HeadshotsClient : BaseClient
{
    public Golfv3HeadshotsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Headshots Asynchronous
    /// </summary>
    public Task<List<Headshot>> GetHeadshotsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Headshot>>("/v3/golf/headshots/{format}/Headshots", parameters);
    }
}
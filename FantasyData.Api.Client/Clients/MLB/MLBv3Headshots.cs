using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.MLB;

namespace FantasyData.Api.Client;

public partial class MLBv3HeadshotsClient : BaseClient
{
    public MLBv3HeadshotsClient(string apiKey) : base(apiKey)
    {
    }

    public MLBv3HeadshotsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Headshots Asynchronous
    /// </summary>
    public Task<List<Headshot>> GetHeadshotsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Headshot>>("/v3/mlb/headshots/{format}/Headshots", parameters);
    }
}
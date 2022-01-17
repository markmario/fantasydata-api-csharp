using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client;

public partial class NFLv3HeadshotsClient : BaseClient
{
    public NFLv3HeadshotsClient(string apiKey) : base(apiKey)
    {
    }

    public NFLv3HeadshotsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Headshots Asynchronous
    /// </summary>
    public Task<List<Headshot>> GetHeadshotsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Headshot>>("/v3/nfl/headshots/{format}/Headshots", parameters);
    }
}
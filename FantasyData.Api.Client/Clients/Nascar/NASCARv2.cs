using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Nascar;

namespace FantasyData.Api.Client;

public partial class NASCARv2Client : BaseClient
{
    public NASCARv2Client(string apiKey) : base(apiKey)
    {
    }

    public NASCARv2Client(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Driver Race Projections (Entry List) Asynchronous
    /// </summary>
    /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
    public Task<List<DriverRaceProjection>> GetDriverRaceProjectionsAsync(int raceid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("raceid", raceid.ToString())};
        return this.GetAsync<List<DriverRaceProjection>>("/nascar/v2/{format}/DriverRaceProjections/{raceid}",
            parameters);
    }

    /// <summary>
    /// Get Drivers Asynchronous
    /// </summary>
    public Task<List<Driver>> GetDriversAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Driver>>("/nascar/v2/{format}/drivers", parameters);
    }

    /// <summary>
    /// Get Race Results Asynchronous
    /// </summary>
    /// <param name="raceid">Unique FantasyData Race ID. Example:<code>1</code>, <code>2</code>, etc.</param>
    public Task<RaceResult> GetRaceresultAsync(int raceid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("raceid", raceid.ToString())};
        return this.GetAsync<RaceResult>("/nascar/v2/{format}/raceresult/{raceid}", parameters);
    }

    /// <summary>
    /// Get Races / Schedule Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
    public Task<List<Race>> GetRacesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Race>>("/nascar/v2/{format}/races/{season}", parameters);
    }

    /// <summary>
    /// Get Series Asynchronous
    /// </summary>
    public Task<List<Series>> GetSeriesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Series>>("/nascar/v2/{format}/series", parameters);
    }
}
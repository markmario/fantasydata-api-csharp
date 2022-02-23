using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CBB;

namespace FantasyData.Api.Client;

public class CBBv3ScoresClient : BaseClient
{
    public CBBv3ScoresClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Are Games In Progress Asynchronous
    /// </summary>
    public Task<bool> GetAreAnyGamesInProgressAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<bool>("/v3/cbb/scores/{format}/AreAnyGamesInProgress", parameters);
    }

    /// <summary>
    /// Get Current Season Asynchronous
    /// </summary>
    public Task<Season> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<Season>("/v3/cbb/scores/{format}/CurrentSeason", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/cbb/scores/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get League Hierarchy Asynchronous
    /// </summary>
    public Task<List<Conference>> GetLeagueHierarchyAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Conference>>("/v3/cbb/scores/{format}/LeagueHierarchy", parameters);
    }

    /// <summary>
    /// Get Player Details by Active Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/cbb/scores/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Player Details by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>60003802</code>.</param>
    public Task<Player> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<Player>("/v3/cbb/scores/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Details by Team Asynchronous
    /// </summary>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
    public Task<List<Player>> GetPlayersAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<Player>>("/v3/cbb/scores/{format}/Players/{team}", parameters);
    }

    /// <summary>
    /// Get Schedules Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
    public Task<List<Game>> GetGamesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Game>>("/v3/cbb/scores/{format}/Games/{season}", parameters);
    }

    /// <summary>
    /// Get Team Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-FEB-27</code>, <code>2017-DEC-01</code>.</param>
    public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<TeamGame>>("/v3/cbb/scores/{format}/TeamGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<TeamSeason>>("/v3/cbb/scores/{format}/TeamSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/cbb/scores/{format}/teams", parameters);
    }

    /// <summary>
    /// Get Tournament Hierarchy Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018POST</code>, <code>2019</code>.</param>
    public Task<Tournament> GetTournamentAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<Tournament>("/v3/cbb/scores/{format}/Tournament/{season}", parameters);
    }

    /// <summary>
    /// Get Stadiums Asynchronous
    /// </summary>
    public Task<List<Stadium>> GetStadiumsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Stadium>>("/v3/cbb/scores/{format}/Stadiums", parameters);
    }

    /// <summary>
    /// Get Team Schedule Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
    public Task<List<Game>> GetTeamScheduleAsync(string season, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("team", team)};
        return this.GetAsync<List<Game>>("/v3/cbb/scores/{format}/TeamSchedule/{season}/{team}", parameters);
    }
}
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client;

public class CFBv3ScoresClient : BaseClient
{
    public CFBv3ScoresClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Are Games In Progress Asynchronous
    /// </summary>
    public Task<bool> GetAreAnyGamesInProgressAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<bool>("/v3/cfb/scores/{format}/AreAnyGamesInProgress", parameters);
    }

    /// <summary>
    /// Get Conference Hierarchy (with Teams) Asynchronous
    /// </summary>
    public Task<List<Conference>> GetLeagueHierarchyAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Conference>>("/v3/cfb/scores/{format}/LeagueHierarchy", parameters);
    }

    /// <summary>
    /// Get Current Season Asynchronous
    /// </summary>
    public Task<int> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int>("/v3/cfb/scores/{format}/CurrentSeason", parameters);
    }

    /// <summary>
    /// Get Current Week Asynchronous
    /// </summary>
    public Task<int?> GetCurrentWeekAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/cfb/scores/{format}/CurrentWeek", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/cfb/scores/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Games by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
    /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
    public Task<List<Game>> GetGamesByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("week", week.ToString())
        };
        return this.GetAsync<List<Game>>("/v3/cfb/scores/{format}/GamesByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Schedules Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
    public Task<List<Game>> GetGamesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Game>>("/v3/cfb/scores/{format}/Games/{season}", parameters);
    }

    /// <summary>
    /// Get Stadiums Asynchronous
    /// </summary>
    public Task<List<Stadium>> GetStadiumsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Stadium>>("/v3/cfb/scores/{format}/Stadiums", parameters);
    }

    /// <summary>
    /// Get Team Game Stats by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
    /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
    public Task<List<TeamGame>> GetTeamGameStatsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("week", week.ToString())
        };
        return this.GetAsync<List<TeamGame>>("/v3/cfb/scores/{format}/TeamGameStatsByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats & Standings Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<TeamSeason>>("/v3/cfb/scores/{format}/TeamSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/cfb/scores/{format}/Teams", parameters);
    }

    /// <summary>
    /// Get Current SeasonType Asynchronous
    /// </summary>
    public Task<string> GetCurrentSeasonTypeAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<string>("/v3/cfb/scores/{format}/CurrentSeasonType", parameters);
    }

    /// <summary>
    /// Get Current Season Details Asynchronous
    /// </summary>
    public Task<Season> GetCurrentSeasonDetailsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<Season>("/v3/cfb/scores/{format}/CurrentSeasonDetails", parameters);
    }

    /// <summary>
    /// Get Player Details By Active Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/cfb/scores/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Player Details By Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
    public Task<List<Player>> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<Player>>("/v3/cfb/scores/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Details by Team Asynchronous
    /// </summary>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
    public Task<List<Player>> GetPlayersAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<Player>>("/v3/cfb/scores/{format}/Players/{team}", parameters);
    }
}
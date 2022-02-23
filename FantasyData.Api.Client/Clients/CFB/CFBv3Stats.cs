using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CFB;

namespace FantasyData.Api.Client;

public class CFBv3StatsClient : BaseClient
{
    public CFBv3StatsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Are Games In Progress Asynchronous
    /// </summary>
    public Task<bool> GetAreAnyGamesInProgressAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<bool>("/v3/cfb/stats/{format}/AreAnyGamesInProgress", parameters);
    }

    /// <summary>
    /// Get Box Score Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of an CFB game. GameIDs can be found in the Games API. Valid entries are <code>1148</code> or <code>1149</code></param>
    public Task<List<BoxScore>> GetBoxScoreAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScore/{gameid}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-JAN-01</code>, <code>2017-JAN-01</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2017</code>, <code>2018</code>, etc.</param>
    /// <param name="week">The week of the game(s). Examples: <code>2</code>, <code>3</code>, etc.</param>
    public Task<List<BoxScore>> GetBoxScoresByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("week", week.ToString())
        };
        return this.GetAsync<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Week Delta Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>, etc.</param>
    /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresByWeekDeltaAsync(string season, int week, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("week", week.ToString()),
            new("minutes", minutes)
        };
        return this.GetAsync<List<BoxScore>>("/v3/cfb/stats/{format}/BoxScoresByWeekDelta/{season}/{week}/{minutes}",
            parameters);
    }

    /// <summary>
    /// Get Conference Hierarchy (with Teams) Asynchronous
    /// </summary>
    public Task<List<Conference>> GetLeagueHierarchyAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Conference>>("/v3/cfb/stats/{format}/LeagueHierarchy", parameters);
    }

    /// <summary>
    /// Get Current Season Asynchronous
    /// </summary>
    public Task<int> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int>("/v3/cfb/stats/{format}/CurrentSeason", parameters);
    }

    /// <summary>
    /// Get Current Week Asynchronous
    /// </summary>
    public Task<int?> GetCurrentWeekAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/cfb/stats/{format}/CurrentWeek", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-SEP-01</code>, <code>2017-SEP-10</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/cfb/stats/{format}/GamesByDate/{date}", parameters);
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
        return this.GetAsync<List<Game>>("/v3/cfb/stats/{format}/GamesByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Player Details by Active Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/cfb/stats/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Player Details by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
    public Task<List<Player>> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<Player>>("/v3/cfb/stats/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Details by Team Asynchronous
    /// </summary>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
    public Task<List<Player>> GetPlayersAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<Player>>("/v3/cfb/stats/{format}/Players/{team}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Player Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
    /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByPlayerAsync(string season, int week, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("week", week.ToString()),
            new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerGame>>(
            "/v3/cfb/stats/{format}/PlayerGameStatsByPlayer/{season}/{week}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2015</code>, <code>2016</code>.</param>
    /// <param name="week">The week of the game(s). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("week", week.ToString())
        };
        return this.GetAsync<List<PlayerGame>>("/v3/cfb/stats/{format}/PlayerGameStatsByWeek/{season}/{week}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeason>>("/v3/cfb/stats/{format}/PlayerSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Player Season Stats By Player Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50002016</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsByPlayerAsync(string season, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerSeason>>("/v3/cfb/stats/{format}/PlayerSeasonStatsByPlayer/{season}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Stats by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>SF</code>, <code>NYY</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("team", team)
        };
        return this.GetAsync<List<PlayerSeason>>("/v3/cfb/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}",
            parameters);
    }

    /// <summary>
    /// Get Schedules Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
    public Task<List<Game>> GetGamesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Game>>("/v3/cfb/stats/{format}/Games/{season}", parameters);
    }

    /// <summary>
    /// Get Stadiums Asynchronous
    /// </summary>
    public Task<List<Stadium>> GetStadiumsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Stadium>>("/v3/cfb/stats/{format}/Stadiums", parameters);
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
        return this.GetAsync<List<TeamGame>>("/v3/cfb/stats/{format}/TeamGameStatsByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats & Standings Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2017</code>, <code>2017POST</code>, <code>2018</code>.</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<TeamSeason>>("/v3/cfb/stats/{format}/TeamSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/cfb/stats/{format}/Teams", parameters);
    }

    /// <summary>
    /// Get Current SeasonType Asynchronous
    /// </summary>
    public Task<string> GetCurrentSeasonTypeAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<string>("/v3/cfb/stats/{format}/CurrentSeasonType", parameters);
    }

    /// <summary>
    /// Get Current Season Details Asynchronous
    /// </summary>
    public Task<Season> GetCurrentSeasonDetailsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<Season>("/v3/cfb/stats/{format}/CurrentSeasonDetails", parameters);
    }

    /// <summary>
    /// Get Player Game Logs By Season Asynchronous
    /// </summary>
    /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>50036283</code>.</param>
    /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
    public Task<List<PlayerGame>> GetPlayerGameStatsBySeasonAsync(string season, int playerid, string numberofgames)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("playerid", playerid.ToString()),
            new("numberofgames", numberofgames)
        };
        return this.GetAsync<List<PlayerGame>>(
            "/v3/cfb/stats/{format}/PlayerGameStatsBySeason/{season}/{playerid}/{numberofgames}", parameters);
    }
}
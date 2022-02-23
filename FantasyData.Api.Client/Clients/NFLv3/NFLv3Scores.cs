using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client;

public class NFLv3ScoresClient : BaseClient
{
    public NFLv3ScoresClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Are Games In Progress
    /// </summary>
    public Task<bool> GetAreAnyGamesInProgressAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<bool>("/v3/nfl/scores/{format}/AreAnyGamesInProgress", parameters);
    }

    /// <summary>
    /// Get Bye Weeks Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<Bye>> GetByesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Bye>>("/v3/nfl/scores/{format}/Byes/{season}", parameters);
    }

    /// <summary>
    /// Get Game Stats by Season (Deprecated, use Team Game Stats instead) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<Game>> GetGameStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Game>>("/v3/nfl/scores/{format}/GameStats/{season}", parameters);
    }

    /// <summary>
    /// Get Game Stats by Week (Deprecated, use Team Game Stats instead) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<Game>> GetGameStatsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<Game>>("/v3/nfl/scores/{format}/GameStatsByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get News Asynchronous
    /// </summary>
    public Task<List<News>> GetNewsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<News>>("/v3/nfl/scores/{format}/News", parameters);
    }

    /// <summary>
    /// Get News by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
    public Task<List<News>> GetNewsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<News>>("/v3/nfl/scores/{format}/NewsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get News by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
    public Task<List<News>> GetNewsByPlayerIDAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<News>>("/v3/nfl/scores/{format}/NewsByPlayerID/{playerid}", parameters);
    }

    /// <summary>
    /// Get News by Team Asynchronous
    /// </summary>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<News>> GetNewsByTeamAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<News>>("/v3/nfl/scores/{format}/NewsByTeam/{team}", parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
    public Task<List<Schedule>> GetSchedulesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Schedule>>("/v3/nfl/scores/{format}/Schedules/{season}", parameters);
    }

    /// <summary>
    /// Get Scores by Season  Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
    public Task<List<Score>> GetScoresAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Score>>("/v3/nfl/scores/{format}/Scores/{season}", parameters);
    }

    /// <summary>
    /// Get Season Current Asynchronous
    /// </summary>
    public Task<int?> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/scores/{format}/CurrentSeason", parameters);
    }

    /// <summary>
    /// Get Season Last Completed Asynchronous
    /// </summary>
    public Task<int?> GetLastCompletedSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/scores/{format}/LastCompletedSeason", parameters);
    }

    /// <summary>
    /// Get Season Upcoming Asynchronous
    /// </summary>
    public Task<int?> GetUpcomingSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/scores/{format}/UpcomingSeason", parameters);
    }

    /// <summary>
    /// Get Stadiums Asynchronous
    /// </summary>
    public Task<List<Stadium>> GetStadiumsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Stadium>>("/v3/nfl/scores/{format}/Stadiums", parameters);
    }

    /// <summary>
    /// Get Standings Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<Standing>> GetStandingsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Standing>>("/v3/nfl/scores/{format}/Standings/{season}", parameters);
    }

    /// <summary>
    /// Get Team Game Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<TeamGame>> GetTeamGameStatsAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<TeamGame>>("/v3/nfl/scores/{format}/TeamGameStats/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<TeamSeason>>("/v3/nfl/scores/{format}/TeamSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Teams (Active) Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/nfl/scores/{format}/Teams", parameters);
    }

    /// <summary>
    /// Get Teams (All) Asynchronous
    /// </summary>
    public Task<List<Team>> GetAllTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/nfl/scores/{format}/AllTeams", parameters);
    }

    /// <summary>
    /// Get Teams by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<Team>> GetTeamsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Team>>("/v3/nfl/scores/{format}/Teams/{season}", parameters);
    }

    /// <summary>
    /// Get Timeframes Asynchronous
    /// </summary>
    /// <param name="type">The type of timeframes to return. Valid entries are <code>current</code> or <code>upcoming</code> or <code>completed</code> or <code>recent</code> or <code>all</code>.</param>
    public Task<List<Timeframe>> GetTimeframesAsync(string type)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("type", type)};
        return this.GetAsync<List<Timeframe>>("/v3/nfl/scores/{format}/Timeframes/{type}", parameters);
    }

    /// <summary>
    /// Get Week Current Asynchronous
    /// </summary>
    public Task<int?> GetCurrentWeekAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/scores/{format}/CurrentWeek", parameters);
    }

    /// <summary>
    /// Get Week Last Completed Asynchronous
    /// </summary>
    public Task<int?> GetLastCompletedWeekAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/scores/{format}/LastCompletedWeek", parameters);
    }

    /// <summary>
    /// Get Week Upcoming Asynchronous
    /// </summary>
    public Task<int?> GetUpcomingWeekAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/scores/{format}/UpcomingWeek", parameters);
    }

    /// <summary>
    /// Get Scores by Week Simulation Asynchronous
    /// </summary>
    /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
    public Task<List<Score>> GetSimulatedScoresAsync(string numberofplays)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("numberofplays", numberofplays)};
        return this.GetAsync<List<Score>>("/v3/nfl/scores/{format}/SimulatedScores/{numberofplays}", parameters);
    }

    /// <summary>
    /// Get Player Details by Available Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/nfl/scores/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Player Details by Free Agents Asynchronous
    /// </summary>
    public Task<List<Player>> GetFreeAgentsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/nfl/scores/{format}/FreeAgents", parameters);
    }

    /// <summary>
    /// Get Player Details by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
    public Task<PlayerDetail> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<PlayerDetail>("/v3/nfl/scores/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Details by Team Asynchronous
    /// </summary>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<PlayerDetail>> GetPlayersAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<PlayerDetail>>("/v3/nfl/scores/{format}/Players/{team}", parameters);
    }

    /// <summary>
    /// Get Player Details by Rookie Draft Year Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
    public Task<List<Player>> GetRookiesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Player>>("/v3/nfl/scores/{format}/Rookies/{season}", parameters);
    }

    /// <summary>
    /// Get Referees Asynchronous
    /// </summary>
    public Task<List<Referee>> GetRefereesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Referee>>("/v3/nfl/scores/{format}/Referees", parameters);
    }

    /// <summary>
    /// Get Scores by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the games. Examples: <code>2021-SEP-12</code>, <code>2021-NOV-28</code>.</param>
    public Task<List<Score>> GetScoresByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Score>>("/v3/nfl/scores/{format}/ScoresByDate/{date}", parameters);
    }
}
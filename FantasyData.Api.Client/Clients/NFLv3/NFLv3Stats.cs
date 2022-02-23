using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client;

public class NFLv3StatsClient : BaseClient
{
    public NFLv3StatsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Are Games In Progress Asynchronous
    /// </summary>
    public Task<bool> GetAreAnyGamesInProgressAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<bool>("/v3/nfl/stats/{format}/AreAnyGamesInProgress", parameters);
    }

    /// <summary>
    /// Get Box Score by ScoreID V3 Asynchronous
    /// </summary>
    /// <param name="scoreid">The ScoreID of the game. Possible values include: <code>16247</code>, <code>16245</code>, etc.</param>
    public Task<BoxScoreV3> GetBoxScoreByScoreIDV3Async(int scoreid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("scoreid", scoreid.ToString())};
        return this.GetAsync<BoxScoreV3>("/v3/nfl/stats/{format}/BoxScoreByScoreIDV3/{scoreid}", parameters);
    }

    /// <summary>
    /// Get Box Score V3 Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="hometeam">Abbreviation of a team playing in this game. Example: <code>WAS</code>.</param>
    public Task<BoxScoreV3> GetBoxScoreV3Async(string season, int week, string hometeam)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("hometeam", hometeam)
        };
        return this.GetAsync<BoxScoreV3>("/v3/nfl/stats/{format}/BoxScoreV3/{season}/{week}/{hometeam}", parameters);
    }

    /// <summary>
    /// Get Box Scores Delta V3 Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="playerstoinclude">The subcategory of players to include in the returned PlayerGame records. Possible values include: <code>all</code> Returns all players <code>fantasy</code> Returns traditional fantasy players (QB, RB, WR, TE, K, DST) <code>idp</code> Returns traditional fantasy players and IDP players.</param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code>, etc.</param>
    public Task<List<BoxScoreV3>> GetBoxScoresDeltaV3Async(string season, int week, string playerstoinclude,
        string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season),
            new("week", week.ToString()),
            new("playerstoinclude", playerstoinclude),
            new("minutes", minutes)
        };
        return this.GetAsync<List<BoxScoreV3>>(
            "/v3/nfl/stats/{format}/BoxScoresDeltaV3/{season}/{week}/{playerstoinclude}/{minutes}", parameters);
    }

    /// <summary>
    /// Get Bye Weeks Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<Bye>> GetByesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Bye>>("/v3/nfl/stats/{format}/Byes/{season}", parameters);
    }

    /// <summary>
    /// Get Daily Fantasy Players Asynchronous
    /// </summary>
    /// <param name="date">The date of the contest for which you're pulling players <code>2014-SEP-21</code>, <code>2014-NOV-15</code>, etc</param>
    public Task<List<DailyFantasyPlayer>> GetDailyFantasyPlayersAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DailyFantasyPlayer>>("/v3/nfl/stats/{format}/DailyFantasyPlayers/{date}", parameters);
    }

    /// <summary>
    /// Get Daily Fantasy Scoring Asynchronous
    /// </summary>
    /// <param name="date">The date of the contest for which you're pulling players <code>2014-SEP-21</code>, <code>2014-NOV-15</code>, etc</param>
    public Task<List<DailyFantasyScoring>> GetDailyFantasyPointsAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DailyFantasyScoring>>("/v3/nfl/stats/{format}/DailyFantasyPoints/{date}", parameters);
    }

    /// <summary>
    /// Get DFS Slates by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the slates. Examples: <code>2017-SEP-25</code>, <code>2017-10-31</code>.</param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/nfl/stats/{format}/DfsSlatesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get DFS Slates by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<DfsSlate>> GetDfsSlatesByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<DfsSlate>>("/v3/nfl/stats/{format}/DfsSlatesByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Fantasy Defense Game Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<FantasyDefenseGame>> GetFantasyDefenseByGameAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<FantasyDefenseGame>>("/v3/nfl/stats/{format}/FantasyDefenseByGame/{season}/{week}",
            parameters);
    }

    /// <summary>
    /// Get Fantasy Defense Game Stats by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<FantasyDefenseGame> GetFantasyDefenseByGameByTeamAsync(string season, int week, string team)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("team", team)
        };
        return this.GetAsync<FantasyDefenseGame>(
            "/v3/nfl/stats/{format}/FantasyDefenseByGameByTeam/{season}/{week}/{team}", parameters);
    }

    /// <summary>
    /// Get Fantasy Defense Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<FantasyDefenseSeason>> GetFantasyDefenseBySeasonAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<FantasyDefenseSeason>>("/v3/nfl/stats/{format}/FantasyDefenseBySeason/{season}",
            parameters);
    }

    /// <summary>
    /// Get Fantasy Defense Season Stats by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<FantasyDefenseSeason> GetFantasyDefenseBySeasonByTeamAsync(string season, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("team", team)};
        return this.GetAsync<FantasyDefenseSeason>(
            "/v3/nfl/stats/{format}/FantasyDefenseBySeasonByTeam/{season}/{team}", parameters);
    }

    /// <summary>
    /// Get Fantasy Player Ownership Percentages (Season-Long) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<PlayerOwnership>> GetPlayerOwnershipAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<PlayerOwnership>>("/v3/nfl/stats/{format}/PlayerOwnership/{season}/{week}",
            parameters);
    }

    /// <summary>
    /// Get Fantasy Players with ADP Asynchronous
    /// </summary>
    public Task<List<FantasyPlayer>> GetFantasyPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<FantasyPlayer>>("/v3/nfl/stats/{format}/FantasyPlayers", parameters);
    }

    /// <summary>
    /// Get Game Stats by Season (Deprecated, use Team Game Stats instead) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<Game>> GetGameStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Game>>("/v3/nfl/stats/{format}/GameStats/{season}", parameters);
    }

    /// <summary>
    /// Get Game Stats by Week (Deprecated, use Team Game Stats instead) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<Game>> GetGameStatsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<Game>>("/v3/nfl/stats/{format}/GameStatsByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get IDP Fantasy Players with ADP Asynchronous
    /// </summary>
    public Task<List<FantasyPlayer>> GetFantasyPlayersIDPAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<FantasyPlayer>>("/v3/nfl/stats/{format}/FantasyPlayersIDP", parameters);
    }

    /// <summary>
    /// Get Injuries Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<Injury>> GetInjuriesAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<Injury>>("/v3/nfl/stats/{format}/Injuries/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Injuries by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<Injury>> GetInjuriesAsync(string season, int week, string team)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("team", team)
        };
        return this.GetAsync<List<Injury>>("/v3/nfl/stats/{format}/Injuries/{season}/{week}/{team}", parameters);
    }

    /// <summary>
    /// Get League Leaders by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="position">Player’s position that you would like to filter by.</param>
    /// <param name="column">Response member you would like results sorted by.</param>
    public Task<List<PlayerSeason>> GetSeasonLeagueLeadersAsync(string season, string position, string column)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("position", position), new("column", column)
        };
        return this.GetAsync<List<PlayerSeason>>(
            "/v3/nfl/stats/{format}/SeasonLeagueLeaders/{season}/{position}/{column}", parameters);
    }

    /// <summary>
    /// Get League Leaders by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="position">Player’s position that you would like to filter by.</param>
    /// <param name="column">Response member you would like results sorted by.</param>
    public Task<List<PlayerGame>> GetGameLeagueLeadersAsync(string season, int week, string position, string column)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("position", position), new("column", column)
        };
        return this.GetAsync<List<PlayerGame>>(
            "/v3/nfl/stats/{format}/GameLeagueLeaders/{season}/{week}/{position}/{column}", parameters);
    }

    /// <summary>
    /// Get Legacy Box Score Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="hometeam">Abbreviation of the home team. Example: <code>WAS</code>.</param>
    public Task<BoxScore> GetBoxScoreAsync(string season, int week, string hometeam)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("hometeam", hometeam)
        };
        return this.GetAsync<BoxScore>("/v3/nfl/stats/{format}/BoxScore/{season}/{week}/{hometeam}", parameters);
    }

    /// <summary>
    /// Get Legacy Box Scores Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<BoxScore>> GetBoxScoresAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<BoxScore>>("/v3/nfl/stats/{format}/BoxScores/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Legacy Box Scores Active Asynchronous
    /// </summary>
    public Task<List<BoxScore>> GetActiveBoxScoresAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<BoxScore>>("/v3/nfl/stats/{format}/ActiveBoxScores", parameters);
    }

    /// <summary>
    /// Get Legacy Box Scores Delta Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresDeltaAsync(string season, string week, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("minutes", minutes)
        };
        return this.GetAsync<List<BoxScore>>("/v3/nfl/stats/{format}/BoxScoresDelta/{season}/{week}/{minutes}",
            parameters);
    }

    public Task<(List<BoxScore>, string)> GetBoxScoresDeltaRawAsync(string season, string week, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("minutes", minutes)
        };
        return this.GetRawAsync<List<BoxScore>>("/v3/nfl/stats/{format}/BoxScoresDelta/{season}/{week}/{minutes}",
            parameters);
    }

    /// <summary>
    /// Get Legacy Box Scores Delta (Current Week) Asynchronous
    /// </summary>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
    public Task<List<BoxScore>> GetRecentlyUpdatedBoxScoresAsync(string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("minutes", minutes)};
        return this.GetAsync<List<BoxScore>>("/v3/nfl/stats/{format}/RecentlyUpdatedBoxScores/{minutes}", parameters);
    }

    /// <summary>
    /// Get Legacy Box Scores Final Asynchronous
    /// </summary>
    public Task<List<BoxScore>> GetFinalBoxScoresAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<BoxScore>>("/v3/nfl/stats/{format}/FinalBoxScores", parameters);
    }

    /// <summary>
    /// Get Legacy Box Scores Live Asynchronous
    /// </summary>
    public Task<List<BoxScore>> GetLiveBoxScoresAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<BoxScore>>("/v3/nfl/stats/{format}/LiveBoxScores", parameters);
    }

    /// <summary>
    /// Get News Asynchronous
    /// </summary>
    public Task<List<News>> GetNewsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<News>>("/v3/nfl/stats/{format}/News", parameters);
    }

    /// <summary>
    /// Get News by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the news. Examples: <code>2017-JUL-31</code>, <code>2017-SEP-01</code>.</param>
    public Task<List<News>> GetNewsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<News>>("/v3/nfl/stats/{format}/NewsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get News by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
    public Task<List<News>> GetNewsByPlayerIDAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<News>>("/v3/nfl/stats/{format}/NewsByPlayerID/{playerid}", parameters);
    }

    /// <summary>
    /// Get News by Team Asynchronous
    /// </summary>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<News>> GetNewsByTeamAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<News>>("/v3/nfl/stats/{format}/NewsByTeam/{team}", parameters);
    }

    /// <summary>
    /// Get Player Details by Available Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/nfl/stats/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Player Details by Free Agents Asynchronous
    /// </summary>
    public Task<List<Player>> GetFreeAgentsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/nfl/stats/{format}/FreeAgents", parameters);
    }

    /// <summary>
    /// Get Player Details by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
    public Task<PlayerDetail> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<PlayerDetail>("/v3/nfl/stats/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Details by Team Asynchronous
    /// </summary>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<PlayerDetail>> GetPlayersAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<List<PlayerDetail>>("/v3/nfl/stats/{format}/Players/{team}", parameters);
    }

    /// <summary>
    /// Get Player Game Red Zone Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<PlayerGameRedZone>> GetPlayerGameRedZoneStatsAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<PlayerGameRedZone>>("/v3/nfl/stats/{format}/PlayerGameRedZoneStats/{season}/{week}",
            parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Player Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
    public Task<PlayerGame> GetPlayerGameStatsByPlayerIDAsync(string season, int week, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerGame>("/v3/nfl/stats/{format}/PlayerGameStatsByPlayerID/{season}/{week}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByTeamAsync(string season, int week, string team)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("team", team)
        };
        return this.GetAsync<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByTeam/{season}/{week}/{team}",
            parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsByWeek/{season}/{week}",
            parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Week Delta Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByWeekDeltaAsync(string season, int week, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("minutes", minutes)
        };
        return this.GetAsync<List<PlayerGame>>(
            "/v3/nfl/stats/{format}/PlayerGameStatsByWeekDelta/{season}/{week}/{minutes}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats Delta Asynchronous
    /// </summary>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code> or <code>2</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsDeltaAsync(string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("minutes", minutes)};
        return this.GetAsync<List<PlayerGame>>("/v3/nfl/stats/{format}/PlayerGameStatsDelta/{minutes}", parameters);
    }

    /// <summary>
    /// Get Player Season Red Zone Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<PlayerSeasonRedZone>> GetPlayerSeasonRedZoneStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeasonRedZone>>("/v3/nfl/stats/{format}/PlayerSeasonRedZoneStats/{season}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeason>>("/v3/nfl/stats/{format}/PlayerSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Player Season Stats by Player Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>732</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsByPlayerIDAsync(string season, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerSeason>>(
            "/v3/nfl/stats/{format}/PlayerSeasonStatsByPlayerID/{season}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Season Stats by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(string season, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("team", team)};
        return this.GetAsync<List<PlayerSeason>>("/v3/nfl/stats/{format}/PlayerSeasonStatsByTeam/{season}/{team}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Third Down Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<PlayerSeasonThirdDown>> GetPlayerSeasonThirdDownStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeasonThirdDown>>("/v3/nfl/stats/{format}/PlayerSeasonThirdDownStats/{season}",
            parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
    public Task<List<Schedule>> GetSchedulesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Schedule>>("/v3/nfl/stats/{format}/Schedules/{season}", parameters);
    }

    /// <summary>
    /// Get Scores by Season  Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2018</code>, <code>2018PRE</code>, <code>2018POST</code>, <code>2018STAR</code>, <code>2019</code>, etc.</param>
    public Task<List<Score>> GetScoresAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Score>>("/v3/nfl/stats/{format}/Scores/{season}", parameters);
    }

    /// <summary>
    /// Get Scores by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<Score>> GetScoresByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<Score>>("/v3/nfl/stats/{format}/ScoresByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Season Current Asynchronous
    /// </summary>
    public Task<int?> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/stats/{format}/CurrentSeason", parameters);
    }

    /// <summary>
    /// Get Season Last Completed Asynchronous
    /// </summary>
    public Task<int?> GetLastCompletedSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/stats/{format}/LastCompletedSeason", parameters);
    }

    /// <summary>
    /// Get Season Upcoming Asynchronous
    /// </summary>
    public Task<int?> GetUpcomingSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/stats/{format}/UpcomingSeason", parameters);
    }

    /// <summary>
    /// Get Stadiums Asynchronous
    /// </summary>
    public Task<List<Stadium>> GetStadiumsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Stadium>>("/v3/nfl/stats/{format}/Stadiums", parameters);
    }

    /// <summary>
    /// Get Standings Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<Standing>> GetStandingsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Standing>>("/v3/nfl/stats/{format}/Standings/{season}", parameters);
    }

    /// <summary>
    /// Get Team Game Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<TeamGame>> GetTeamGameStatsAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<TeamGame>>("/v3/nfl/stats/{format}/TeamGameStats/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<TeamSeason>>("/v3/nfl/stats/{format}/TeamSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Teams (Active) Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/nfl/stats/{format}/Teams", parameters);
    }

    /// <summary>
    /// Get Teams (All) Asynchronous
    /// </summary>
    public Task<List<Team>> GetAllTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/nfl/stats/{format}/AllTeams", parameters);
    }

    /// <summary>
    /// Get Teams by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<Team>> GetTeamsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Team>>("/v3/nfl/stats/{format}/Teams/{season}", parameters);
    }

    /// <summary>
    /// Get Timeframes Asynchronous
    /// </summary>
    /// <param name="type">The type of timeframes to return. Valid entries are <code>current</code> or <code>upcoming</code> or <code>completed</code> or <code>recent</code> or <code>all</code>.</param>
    public Task<List<Timeframe>> GetTimeframesAsync(string type)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("type", type)};
        return this.GetAsync<List<Timeframe>>("/v3/nfl/stats/{format}/Timeframes/{type}", parameters);
    }

    /// <summary>
    /// Get Week Current Asynchronous
    /// </summary>
    public Task<int?> GetCurrentWeekAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/stats/{format}/CurrentWeek", parameters);
    }

    /// <summary>
    /// Get Week Last Completed Asynchronous
    /// </summary>
    public Task<int?> GetLastCompletedWeekAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/stats/{format}/LastCompletedWeek", parameters);
    }

    /// <summary>
    /// Get Week Upcoming Asynchronous
    /// </summary>
    public Task<int?> GetUpcomingWeekAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<int?>("/v3/nfl/stats/{format}/UpcomingWeek", parameters);
    }

    /// <summary>
    /// Get Pro Bowlers Asynchronous
    /// </summary>
    /// <param name="season">Year of the season Examples: <code>2016</code>, <code>2017</code></param>
    public Task<List<PlayerInfo>> GetProBowlersAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerInfo>>("/v3/nfl/stats/{format}/ProBowlers/{season}", parameters);
    }

    /// <summary>
    /// Get Box Scores V3 Simulation Asynchronous
    /// </summary>
    /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
    public Task<List<BoxScoreV3>> GetSimulatedBoxScoresV3Async(string numberofplays)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("numberofplays", numberofplays)};
        return this.GetAsync<List<BoxScoreV3>>("/v3/nfl/stats/{format}/SimulatedBoxScoresV3/{numberofplays}",
            parameters);
    }

    /// <summary>
    /// Get Scores by Week Simulation Asynchronous
    /// </summary>
    /// <param name="numberofplays">The number of plays to progress in this NFL live game simulation. Example entries are <code>0</code>, <code>1</code>, <code>2</code>, <code>3</code>, <code>150</code>, <code>200</code>, etc.</param>
    public Task<List<Score>> GetSimulatedScoresAsync(string numberofplays)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("numberofplays", numberofplays)};
        return this.GetAsync<List<Score>>("/v3/nfl/stats/{format}/SimulatedScores/{numberofplays}", parameters);
    }

    /// <summary>
    /// Get Player Game Red Zone Stats Inside Five Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<PlayerGameRedZone>> GetPlayerGameRedZoneInsideFiveStatsAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<PlayerGameRedZone>>(
            "/v3/nfl/stats/{format}/PlayerGameRedZoneInsideFiveStats/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Player Game Red Zone Stats Inside Ten Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<PlayerGameRedZone>> GetPlayerGameRedZoneInsideTenStatsAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<PlayerGameRedZone>>(
            "/v3/nfl/stats/{format}/PlayerGameRedZoneInsideTenStats/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Player Season Red Zone Stats Inside Five Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<PlayerSeasonRedZone>> GetPlayerSeasonRedZoneInsideFiveStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeasonRedZone>>(
            "/v3/nfl/stats/{format}/PlayerSeasonRedZoneInsideFiveStats/{season}", parameters);
    }

    /// <summary>
    /// Get Player Season Red Zone Stats Inside Ten Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<PlayerSeasonRedZone>> GetPlayerSeasonRedZoneInsideTenStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeasonRedZone>>(
            "/v3/nfl/stats/{format}/PlayerSeasonRedZoneInsideTenStats/{season}", parameters);
    }

    /// <summary>
    /// Get Player Details by Rookie Draft Year Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2018</code>, <code>2019</code>, etc.</param>
    public Task<List<Player>> GetRookiesAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Player>>("/v3/nfl/stats/{format}/Rookies/{season}", parameters);
    }

    /// <summary>
    /// Get Player Game Logs By Season Asynchronous
    /// </summary>
    /// <param name="season">Season to get games from. Example <code>2019POST</code>, <code>2020</code></param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>17920</code>.</param>
    /// <param name="numberofgames">How many games to return. Example <code>all</code>, <code>10</code>, <code>25</code></param>
    public Task<List<PlayerGame>> GetPlayerGameStatsBySeasonAsync(string season, int playerid, string numberofgames)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("playerid", playerid.ToString()), new("numberofgames", numberofgames)
        };
        return this.GetAsync<List<PlayerGame>>(
            "/v3/nfl/stats/{format}/PlayerGameStatsBySeason/{season}/{playerid}/{numberofgames}", parameters);
    }

    /// <summary>
    /// Get Scores by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the games. Examples: <code>2021-SEP-12</code>, <code>2021-NOV-28</code>.</param>
    public Task<List<Score>> GetScoresByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Score>>("/v3/nfl/stats/{format}/ScoresByDate/{date}", parameters);
    }
}
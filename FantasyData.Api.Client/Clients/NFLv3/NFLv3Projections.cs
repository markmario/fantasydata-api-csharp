using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client;

public class NFLv3ProjectionsClient : BaseClient
{
    public NFLv3ProjectionsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get DFS Slates by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the slates. Examples: <code>2017-SEP-25</code>, <code>2017-10-31</code>.</param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/nfl/projections/{format}/DfsSlatesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get DFS Slates by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code></param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<DfsSlate>> GetDfsSlatesByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<DfsSlate>>("/v3/nfl/projections/{format}/DfsSlatesByWeek/{season}/{week}",
            parameters);
    }

    /// <summary>
    /// Get Projected Fantasy Defense Game Stats (w/ DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<FantasyDefenseGameProjection>> GetFantasyDefenseProjectionsByGameAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<FantasyDefenseGameProjection>>(
            "/v3/nfl/projections/{format}/FantasyDefenseProjectionsByGame/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Projected Fantasy Defense Season Stats (w/ Bye Week, ADP) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<FantasyDefenseSeasonProjection>> GetFantasyDefenseProjectionsBySeasonAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<FantasyDefenseSeasonProjection>>(
            "/v3/nfl/projections/{format}/FantasyDefenseProjectionsBySeason/{season}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
    public Task<PlayerGameProjection> GetPlayerGameProjectionStatsByPlayerIDAsync(string season, int week, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerGameProjection>(
            "/v3/nfl/projections/{format}/PlayerGameProjectionStatsByPlayerID/{season}/{week}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Team (w/ Injuries, Lineups, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByTeamAsync(string season, int week,
        string team)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("team", team)
        };
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/nfl/projections/{format}/PlayerGameProjectionStatsByTeam/{season}/{week}/{team}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Week (w/ Injuries, Lineups, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/nfl/projections/{format}/PlayerGameProjectionStatsByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Projected Player Season Stats (w/ Bye Week, ADP) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    public Task<List<PlayerSeasonProjection>> GetPlayerSeasonProjectionStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeasonProjection>>(
            "/v3/nfl/projections/{format}/PlayerSeasonProjectionStats/{season}", parameters);
    }

    /// <summary>
    /// Get Projected Player Season Stats by Player (w/ Bye Week, ADP) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
    public Task<PlayerSeasonProjection> GetPlayerSeasonProjectionStatsByPlayerIDAsync(string season, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerSeasonProjection>(
            "/v3/nfl/projections/{format}/PlayerSeasonProjectionStatsByPlayerID/{season}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Projected Player Season Stats by Team (w/ Bye Week, ADP) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<PlayerSeasonProjection>> GetPlayerSeasonProjectionStatsByTeamAsync(string season, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("team", team)};
        return this.GetAsync<List<PlayerSeasonProjection>>(
            "/v3/nfl/projections/{format}/PlayerSeasonProjectionStatsByTeam/{season}/{team}", parameters);
    }

    /// <summary>
    /// Get IDP Projected Player Game Stats by Player (w/ Injuries, Lineups, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example:<code>14257</code>.</param>
    public Task<PlayerGameProjection> GetIdpPlayerGameProjectionStatsByPlayerIDAsync(string season, int week,
        int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerGameProjection>(
            "/v3/nfl/projections/{format}/IdpPlayerGameProjectionStatsByPlayerID/{season}/{week}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get IDP Projected Player Game Stats by Team (w/ Injuries, Lineups, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    /// <param name="team">Abbreviation of the team. Example: <code>WAS</code>.</param>
    public Task<List<PlayerGameProjection>> GetIdpPlayerGameProjectionStatsByTeamAsync(string season, int week,
        string team)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("team", team)
        };
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/nfl/projections/{format}/IdpPlayerGameProjectionStatsByTeam/{season}/{week}/{team}", parameters);
    }

    /// <summary>
    /// Get IDP Projected Player Game Stats by Week (w/ Injuries, Lineups, DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2015REG</code>, <code>2015PRE</code>, <code>2015POST</code>.</param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code></param>
    public Task<List<PlayerGameProjection>> GetIdpPlayerGameProjectionStatsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/v3/nfl/projections/{format}/IdpPlayerGameProjectionStatsByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get DFS Slate Ownership Projections by SlateID Asynchronous
    /// </summary>
    /// <param name="slateId">SlateID of the DFS Slate you wish to get ownership projections for. Will have an empty SlateOwnershipProjections if this slate was not projected</param>
    public Task<DfsSlateWithOwnershipProjection> GetDfsSlateOwnershipProjectionsBySlateIDAsync(string slateId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("slateId", slateId)};
        return this.GetAsync<DfsSlateWithOwnershipProjection>(
            "/v3/nfl/projections/{format}/DfsSlateOwnershipProjectionsBySlateID/{slateId}", parameters);
    }

    /// <summary>
    /// Get Upcoming DFS Slate Ownership Projections Asynchronous
    /// </summary>
    public Task<List<DfsSlateWithOwnershipProjection>> GetUpcomingDfsSlateOwnershipProjectionsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<DfsSlateWithOwnershipProjection>>(
            "/v3/nfl/projections/{format}/UpcomingDfsSlateOwnershipProjections", parameters);
    }
}
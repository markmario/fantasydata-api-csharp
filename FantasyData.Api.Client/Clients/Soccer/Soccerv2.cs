using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client;

public partial class Soccerv2Client : BaseClient
{
    public Soccerv2Client(string apiKey) : base(apiKey)
    {
    }

    public Soccerv2Client(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Areas (Countries) Asynchronous
    /// </summary>
    public Task<List<Area>> GetAreasAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Area>>("/soccer/v2/{format}/Areas", parameters);
    }

    /// <summary>
    /// Get Box Score Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>702</code>, <code>1274</code>, etc.</param>
    public Task<BoxScore> GetBoxScoreAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<BoxScore>("/soccer/v2/{format}/BoxScore/{gameid}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BoxScore>>("/soccer/v2/{format}/BoxScores/{date}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date by Competition Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresByCompetitionAsync(string competition, string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition), new("date", date)};
        return this.GetAsync<List<BoxScore>>("/soccer/v2/{format}/BoxScoresByCompetition/{competition}/{date}",
            parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Delta Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresDeltaAsync(string date, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date), new("minutes", minutes)};
        return this.GetAsync<List<BoxScore>>("/soccer/v2/{format}/BoxScoresDelta/{date}/{minutes}", parameters);
    }

    /// <summary>
    /// Get Box Scores Delta by Date by Competition Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresDeltaByCompetitionAsync(string competition, string date, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("competition", competition), new("date", date), new("minutes", minutes)
        };
        return this.GetAsync<List<BoxScore>>(
            "/soccer/v2/{format}/BoxScoresDeltaByCompetition/{competition}/{date}/{minutes}", parameters);
    }

    /// <summary>
    /// Get Competition Fixtures (League Details) Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    public Task<CompetitionDetail> GetCompetitionDetailsAsync(string competition)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition)};
        return this.GetAsync<CompetitionDetail>("/soccer/v2/{format}/CompetitionDetails/{competition}", parameters);
    }

    /// <summary>
    /// Get Competition Hierarchy (League Hierarchy) Asynchronous
    /// </summary>
    public Task<List<Area>> GetCompetitionHierarchyAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Area>>("/soccer/v2/{format}/CompetitionHierarchy", parameters);
    }

    /// <summary>
    /// Get Competitions (Leagues) Asynchronous
    /// </summary>
    public Task<List<Competition>> GetCompetitionsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Competition>>("/soccer/v2/{format}/Competitions", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/soccer/v2/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Memberships (Active) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetActiveMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/soccer/v2/{format}/ActiveMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships (Historical) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetHistoricalMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/soccer/v2/{format}/HistoricalMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Active) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<Membership>> GetMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/soccer/v2/{format}/MembershipsByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Historical) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<Membership>> GetHistoricalMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/soccer/v2/{format}/HistoricalMembershipsByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<Player> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<Player>("/soccer/v2/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGame>>("/soccer/v2/{format}/PlayerGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Player Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerGame>>("/soccer/v2/{format}/PlayerGameStatsByPlayer/{date}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Stats Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<PlayerSeason>>("/soccer/v2/{format}/PlayerSeasonStats/{roundid}", parameters);
    }

    /// <summary>
    /// Get Player Season Stats by Player Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsByPlayerAsync(int roundid, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("roundid", roundid.ToString()), new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerSeason>>("/soccer/v2/{format}/PlayerSeasonStatsByPlayer/{roundid}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Stats by Team Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    /// <param name="team">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(int roundid, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString()), new("team", team)};
        return this.GetAsync<List<PlayerSeason>>("/soccer/v2/{format}/PlayerSeasonStatsByTeam/{roundid}/{team}",
            parameters);
    }

    /// <summary>
    /// Get Players Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/soccer/v2/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Players by Team Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<Player>> GetPlayersByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Player>>("/soccer/v2/{format}/PlayersByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Competition (w/ DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByCompetitionAsync(string competition,
        string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition), new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>(
            "/soccer/v2/{format}/PlayerGameProjectionStatsByCompetition/{competition}/{date}", parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Date (w/ DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGameProjection>>("/soccer/v2/{format}/PlayerGameProjectionStatsByDate/{date}",
            parameters);
    }

    /// <summary>
    /// Get Projected Player Game Stats by Player (w/ DFS Salaries) Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<List<PlayerGameProjection>> GetPlayerGameProjectionStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerGameProjection>>(
            "/soccer/v2/{format}/PlayerGameProjectionStatsByPlayer/{date}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<Game>> GetScheduleAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Game>>("/soccer/v2/{format}/Schedule/{roundid}", parameters);
    }

    /// <summary>
    /// Get Season Teams Asynchronous
    /// </summary>
    /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<SeasonTeam>> GetSeasonTeamsAsync(int seasonid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("seasonid", seasonid.ToString())};
        return this.GetAsync<List<SeasonTeam>>("/soccer/v2/{format}/SeasonTeams/{seasonid}", parameters);
    }

    /// <summary>
    /// Get Standings Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<Standing>> GetStandingsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Standing>>("/soccer/v2/{format}/Standings/{roundid}", parameters);
    }

    /// <summary>
    /// Get Team Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2016-02-27</code>, <code>2016-09-01</code>.</param>
    public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<TeamGame>>("/soccer/v2/{format}/TeamGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<TeamSeason>>("/soccer/v2/{format}/TeamSeasonStats/{roundid}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/soccer/v2/{format}/Teams", parameters);
    }

    /// <summary>
    /// Get Venues Asynchronous
    /// </summary>
    public Task<List<Venue>> GetVenuesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Venue>>("/soccer/v2/{format}/Venues", parameters);
    }
}
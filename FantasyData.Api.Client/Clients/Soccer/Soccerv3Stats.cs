using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client;

public partial class Soccerv3StatsClient : BaseClient
{
    public Soccerv3StatsClient(string apiKey) : base(apiKey)
    {
    }

    public Soccerv3StatsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Areas (Countries) Asynchronous
    /// </summary>
    public Task<List<Area>> GetAreasAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Area>>("/v3/soccer/stats/{format}/Areas", parameters);
    }

    /// <summary>
    /// Get Box Score Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of a Soccer game. GameIDs can be found in the Games API. Valid entries are <code>702</code>, <code>1274</code>, etc.</param>
    public Task<BoxScore> GetBoxScoreAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<BoxScore>("/v3/soccer/stats/{format}/BoxScore/{gameid}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BoxScore>>("/v3/soccer/stats/{format}/BoxScores/{date}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date by Competition Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresByCompetitionAsync(string competition, string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition), new("date", date)};
        return this.GetAsync<List<BoxScore>>("/v3/soccer/stats/{format}/BoxScoresByCompetition/{competition}/{date}",
            parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Delta Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresDeltaAsync(string date, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date), new("minutes", minutes)};
        return this.GetAsync<List<BoxScore>>("/v3/soccer/stats/{format}/BoxScoresDelta/{date}/{minutes}", parameters);
    }

    /// <summary>
    /// Get Box Scores Delta by Date by Competition Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    /// <param name="minutes">Only returns player statistics that have changed in the last X minutes. You specify how many minutes in time to go back. Valid entries are: <code>1</code>, <code>2</code> ... <code>all</code>.</param>
    public Task<List<BoxScore>> GetBoxScoresDeltaByCompetitionAsync(string competition, string date, string minutes)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("competition", competition), new("date", date), new("minutes", minutes)
        };
        return this.GetAsync<List<BoxScore>>(
            "/v3/soccer/stats/{format}/BoxScoresDeltaByCompetition/{competition}/{date}/{minutes}", parameters);
    }

    /// <summary>
    /// Get Competition Fixtures (League Details) Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    public Task<CompetitionDetail> GetCompetitionDetailsAsync(string competition)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition)};
        return this.GetAsync<CompetitionDetail>("/v3/soccer/stats/{format}/CompetitionDetails/{competition}",
            parameters);
    }

    /// <summary>
    /// Get Competition Hierarchy (League Hierarchy) Asynchronous
    /// </summary>
    public Task<List<Area>> GetCompetitionHierarchyAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Area>>("/v3/soccer/stats/{format}/CompetitionHierarchy", parameters);
    }

    /// <summary>
    /// Get Competitions (Leagues) Asynchronous
    /// </summary>
    public Task<List<Competition>> GetCompetitionsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Competition>>("/v3/soccer/stats/{format}/Competitions", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/soccer/stats/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Memberships (Active) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetActiveMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/v3/soccer/stats/{format}/ActiveMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships (Historical) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetHistoricalMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/v3/soccer/stats/{format}/HistoricalMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Active) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<Membership>> GetMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/v3/soccer/stats/{format}/MembershipsByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Historical) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<Membership>> GetHistoricalMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/v3/soccer/stats/{format}/HistoricalMembershipsByTeam/{teamid}",
            parameters);
    }

    /// <summary>
    /// Get Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<Player> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<Player>("/v3/soccer/stats/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerGame>>("/v3/soccer/stats/{format}/PlayerGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Player Game Stats by Player Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<List<PlayerGame>> GetPlayerGameStatsByPlayerAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerGame>>("/v3/soccer/stats/{format}/PlayerGameStatsByPlayer/{date}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Player Season Stats Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<PlayerSeason>>("/v3/soccer/stats/{format}/PlayerSeasonStats/{roundid}", parameters);
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
        return this.GetAsync<List<PlayerSeason>>(
            "/v3/soccer/stats/{format}/PlayerSeasonStatsByPlayer/{roundid}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Season Stats by Team Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    /// <param name="team">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsByTeamAsync(int roundid, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString()), new("team", team)};
        return this.GetAsync<List<PlayerSeason>>("/v3/soccer/stats/{format}/PlayerSeasonStatsByTeam/{roundid}/{team}",
            parameters);
    }

    /// <summary>
    /// Get Players Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/soccer/stats/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Players by Team Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<Player>> GetPlayersByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Player>>("/v3/soccer/stats/{format}/PlayersByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<Game>> GetScheduleAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Game>>("/v3/soccer/stats/{format}/Schedule/{roundid}", parameters);
    }

    /// <summary>
    /// Get Season Teams Asynchronous
    /// </summary>
    /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<SeasonTeam>> GetSeasonTeamsAsync(int seasonid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("seasonid", seasonid.ToString())};
        return this.GetAsync<List<SeasonTeam>>("/v3/soccer/stats/{format}/SeasonTeams/{seasonid}", parameters);
    }

    /// <summary>
    /// Get Standings Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<Standing>> GetStandingsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Standing>>("/v3/soccer/stats/{format}/Standings/{roundid}", parameters);
    }

    /// <summary>
    /// Get Team Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<TeamGame>>("/v3/soccer/stats/{format}/TeamGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<TeamSeason>>("/v3/soccer/stats/{format}/TeamSeasonStats/{roundid}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/soccer/stats/{format}/Teams", parameters);
    }

    /// <summary>
    /// Get Venues Asynchronous
    /// </summary>
    public Task<List<Venue>> GetVenuesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Venue>>("/v3/soccer/stats/{format}/Venues", parameters);
    }

    /// <summary>
    /// Get Upcoming Schedule By Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<List<Game>> GetUpcomingScheduleByPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<Game>>("/v3/soccer/stats/{format}/UpcomingScheduleByPlayer/{playerid}", parameters);
    }

    /// <summary>
    /// Get Memberships (Recently Changed) Asynchronous
    /// </summary>
    /// <param name="days">The number of days since memberships were updated. For example, if you pass <code>3</code>, you'll receive all memberships that have been updated in the past 3 days. Valid entries are: <code>1</code>, <code>2</code> ... <code>30</code></param>
    public Task<List<Membership>> GetRecentlyChangedMembershipsAsync(string days)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("days", days)};
        return this.GetAsync<List<Membership>>("/v3/soccer/stats/{format}/RecentlyChangedMemberships/{days}",
            parameters);
    }

    /// <summary>
    /// Get Memberships by Competition (Active) Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    public Task<List<Membership>> GetMembershipsByCompetitionAsync(string competition)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition)};
        return this.GetAsync<List<Membership>>("/v3/soccer/stats/{format}/MembershipsByCompetition/{competition}",
            parameters);
    }

    /// <summary>
    /// Get Memberships by Competition (Historical) Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    public Task<List<Membership>> GetHistoricalMembershipsByCompetitionAsync(string competition)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition)};
        return this.GetAsync<List<Membership>>(
            "/v3/soccer/stats/{format}/HistoricalMembershipsByCompetition/{competition}", parameters);
    }

    /// <summary>
    /// Get Dfs Slates By Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2020-02-18</code>.</param>
    public Task<List<DfsSlate>> GetDfsSlatesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<DfsSlate>>("/v3/soccer/stats/{format}/DfsSlatesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Upcoming Dfs Slates By Competition Asynchronous
    /// </summary>
    /// <param name="competitionId">The id of the competition. Examples: <code>3</code></param>
    public Task<List<DfsSlate>> GetUpcomingDfsSlatesByCompetitionAsync(string competitionId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competitionId", competitionId)};
        return this.GetAsync<List<DfsSlate>>("/v3/soccer/stats/{format}/UpcomingDfsSlatesByCompetition/{competitionId}",
            parameters);
    }
}
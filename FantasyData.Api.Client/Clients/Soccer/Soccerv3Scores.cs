using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Soccer;

namespace FantasyData.Api.Client;

public class Soccerv3ScoresClient : BaseClient
{
    public Soccerv3ScoresClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get Competition Fixtures (League Details) Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    public Task<CompetitionDetail> GetCompetitionDetailsAsync(string competition)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition)};
        return this.GetAsync<CompetitionDetail>("/v3/soccer/scores/{format}/CompetitionDetails/{competition}",
            parameters);
    }

    /// <summary>
    /// Get Competition Hierarchy (League Hierarchy) Asynchronous
    /// </summary>
    public Task<List<Area>> GetCompetitionHierarchyAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Area>>("/v3/soccer/scores/{format}/CompetitionHierarchy", parameters);
    }

    /// <summary>
    /// Get Competitions (Leagues) Asynchronous
    /// </summary>
    public Task<List<Competition>> GetCompetitionsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Competition>>("/v3/soccer/scores/{format}/Competitions", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/soccer/scores/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Memberships (Active) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetActiveMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/v3/soccer/scores/{format}/ActiveMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships (Historical) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetHistoricalMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/v3/soccer/scores/{format}/HistoricalMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Active) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<Membership>> GetMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/v3/soccer/scores/{format}/MembershipsByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Historical) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<Membership>> GetHistoricalMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/v3/soccer/scores/{format}/HistoricalMembershipsByTeam/{teamid}",
            parameters);
    }

    /// <summary>
    /// Get Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<Player> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<Player>("/v3/soccer/scores/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Players Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/soccer/scores/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Players by Team Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>516</code>.</param>
    public Task<List<Player>> GetPlayersByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Player>>("/v3/soccer/scores/{format}/PlayersByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<Game>> GetScheduleAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Game>>("/v3/soccer/scores/{format}/Schedule/{roundid}", parameters);
    }

    /// <summary>
    /// Get Season Teams Asynchronous
    /// </summary>
    /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<SeasonTeam>> GetSeasonTeamsAsync(int seasonid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("seasonid", seasonid.ToString())};
        return this.GetAsync<List<SeasonTeam>>("/v3/soccer/scores/{format}/SeasonTeams/{seasonid}", parameters);
    }

    /// <summary>
    /// Get Standings Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<Standing>> GetStandingsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Standing>>("/v3/soccer/scores/{format}/Standings/{roundid}", parameters);
    }

    /// <summary>
    /// Get Team Game Stats by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2017-02-27</code>, <code>2017-09-01</code>.</param>
    public Task<List<TeamGame>> GetTeamGameStatsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<TeamGame>>("/v3/soccer/scores/{format}/TeamGameStatsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Team Season Stats Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competition Hierarchy (League Hierarchy). Examples: <code>1</code>, <code>2</code>, <code>3</code>, etc</param>
    public Task<List<TeamSeason>> GetTeamSeasonStatsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<TeamSeason>>("/v3/soccer/scores/{format}/TeamSeasonStats/{roundid}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/soccer/scores/{format}/Teams", parameters);
    }

    /// <summary>
    /// Get Venues Asynchronous
    /// </summary>
    public Task<List<Venue>> GetVenuesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Venue>>("/v3/soccer/scores/{format}/Venues", parameters);
    }

    /// <summary>
    /// Get Upcoming Schedule By Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>90026231</code>.</param>
    public Task<List<Game>> GetUpcomingScheduleByPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<Game>>("/v3/soccer/scores/{format}/UpcomingScheduleByPlayer/{playerid}", parameters);
    }

    /// <summary>
    /// Get Memberships (Recently Changed) Asynchronous
    /// </summary>
    /// <param name="days">The number of days since memberships were updated. For example, if you pass <code>3</code>, you'll receive all memberships that have been updated in the past 3 days. Valid entries are: <code>1</code>, <code>2</code> ... <code>30</code></param>
    public Task<List<Membership>> GetRecentlyChangedMembershipsAsync(string days)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("days", days)};
        return this.GetAsync<List<Membership>>("/v3/soccer/scores/{format}/RecentlyChangedMemberships/{days}",
            parameters);
    }

    /// <summary>
    /// Get Memberships by Competition (Active) Asynchronous
    /// </summary>
    /// <param name="competition">An indication of a soccer competition/league. This value can be the CompetitionId or the Competition Key. Possible values include: <code>EPL</code>, <code>1</code>, <code>MLS</code>, <code>8</code>, etc.</param>
    public Task<List<Membership>> GetMembershipsByCompetitionAsync(string competition)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competition", competition)};
        return this.GetAsync<List<Membership>>("/v3/soccer/scores/{format}/MembershipsByCompetition/{competition}",
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
            "/v3/soccer/scores/{format}/HistoricalMembershipsByCompetition/{competition}", parameters);
    }

    /// <summary>
    /// Get Canceled Memberships Asynchronous
    /// </summary>
    public Task<CanceledMembership> GetCanceledMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<CanceledMembership>("/v3/soccer/scores/{format}/CanceledMemberships", parameters);
    }
}
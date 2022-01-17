using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Csgo;

namespace FantasyData.Api.Client;

public partial class Csgov3ScoresClient : BaseClient
{
    public Csgov3ScoresClient(string apiKey) : base(apiKey)
    {
    }

    public Csgov3ScoresClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Areas (Countries) Asynchronous
    /// </summary>
    public Task<List<Area>> GetAreasAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Area>>("/v3/csgo/scores/{format}/Areas", parameters);
    }

    /// <summary>
    /// Get Competition Fixtures (League Details) Asynchronous
    /// </summary>
    /// <param name="competitionid">A CS:GO competition/league unique CompetitionId. Possible values include: <code>100000009</code>, etc.</param>
    public Task<CompetitionDetail> GetCompetitionDetailsAsync(string competitionid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competitionid", competitionid)};
        return this.GetAsync<CompetitionDetail>("/v3/csgo/scores/{format}/CompetitionDetails/{competitionid}",
            parameters);
    }

    /// <summary>
    /// Get Competitions (Leagues) Asynchronous
    /// </summary>
    public Task<List<Competition>> GetCompetitionsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Competition>>("/v3/csgo/scores/{format}/Competitions", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-01-13</code>, <code>2018-06-13</code>.</param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/csgo/scores/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Memberships (Active) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetActiveMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/v3/csgo/scores/{format}/ActiveMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships (Historical) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetHistoricalMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/v3/csgo/scores/{format}/HistoricalMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Active) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000001</code>.</param>
    public Task<List<Membership>> GetMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/v3/csgo/scores/{format}/MembershipsByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Historical) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000001</code>.</param>
    public Task<List<Membership>> GetHistoricalMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/v3/csgo/scores/{format}/HistoricalMembershipsByTeam/{teamid}",
            parameters);
    }

    /// <summary>
    /// Get Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100000576</code>.</param>
    public Task<Player> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<Player>("/v3/csgo/scores/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Players Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/csgo/scores/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Players by Team Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000001</code>.</param>
    public Task<List<Player>> GetPlayersByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Player>>("/v3/csgo/scores/{format}/PlayersByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Examples: <code>100000138</code>, <code>1000001412</code>, etc</param>
    public Task<List<Game>> GetScheduleAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Game>>("/v3/csgo/scores/{format}/Schedule/{roundid}", parameters);
    }

    /// <summary>
    /// Get Season Teams Asynchronous
    /// </summary>
    /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competitions and Competition Details endpoints. Examples: <code>100000023</code>, <code>100000024</code>, etc</param>
    public Task<List<SeasonTeam>> GetSeasonTeamsAsync(int seasonid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("seasonid", seasonid.ToString())};
        return this.GetAsync<List<SeasonTeam>>("/v3/csgo/scores/{format}/SeasonTeams/{seasonid}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/csgo/scores/{format}/Teams", parameters);
    }

    /// <summary>
    /// Get Venues Asynchronous
    /// </summary>
    public Task<List<Venue>> GetVenuesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Venue>>("/v3/csgo/scores/{format}/Venues", parameters);
    }

    /// <summary>
    /// Get Standings Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Example: <code>100000138</code>, etc</param>
    public Task<List<Standing>> GetStandingsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Standing>>("/v3/csgo/scores/{format}/Standings/{roundid}", parameters);
    }
}
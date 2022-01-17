using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Lol;

namespace FantasyData.Api.Client;

public partial class Lolv3StatsClient : BaseClient
{
    public Lolv3StatsClient(string apiKey) : base(apiKey)
    {
    }

    public Lolv3StatsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Areas (Countries) Asynchronous
    /// </summary>
    public Task<List<Area>> GetAreasAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Area>>("/v3/lol/stats/{format}/Areas", parameters);
    }

    /// <summary>
    /// Get Box Score Asynchronous
    /// </summary>
    /// <param name="gameid">Unique FantasyData Game ID. Example:<code>100002649</code>.</param>
    public Task<List<BoxScore>> GetBoxScoreAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<List<BoxScore>>("/v3/lol/stats/{format}/BoxScore/{gameid}", parameters);
    }

    /// <summary>
    /// Get Box Scores by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2019-01-20</code></param>
    public Task<List<BoxScore>> GetBoxScoresAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BoxScore>>("/v3/lol/stats/{format}/BoxScores/{date}", parameters);
    }

    /// <summary>
    /// Get Champions Asynchronous
    /// </summary>
    public Task<List<Champion>> GetChampionsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Champion>>("/v3/lol/stats/{format}/Champions", parameters);
    }

    /// <summary>
    /// Get Competition Fixtures (League Details) Asynchronous
    /// </summary>
    /// <param name="competitionid">A LoL competition/league unique CompetitionId. Possible values include: <code>100000019</code>, etc.</param>
    public Task<CompetitionDetail> GetCompetitionDetailsAsync(string competitionid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("competitionid", competitionid)};
        return this.GetAsync<CompetitionDetail>("/v3/lol/stats/{format}/CompetitionDetails/{competitionid}",
            parameters);
    }

    /// <summary>
    /// Get Competitions (Leagues) Asynchronous
    /// </summary>
    public Task<List<Competition>> GetCompetitionsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Competition>>("/v3/lol/stats/{format}/Competitions", parameters);
    }

    /// <summary>
    /// Get Games by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2019-01-20</code></param>
    public Task<List<Game>> GetGamesByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<Game>>("/v3/lol/stats/{format}/GamesByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Items Asynchronous
    /// </summary>
    public Task<List<Item>> GetItemsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Item>>("/v3/lol/stats/{format}/Items", parameters);
    }

    /// <summary>
    /// Get Memberships (Active) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetActiveMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/v3/lol/stats/{format}/ActiveMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships (Historical) Asynchronous
    /// </summary>
    public Task<List<Membership>> GetHistoricalMembershipsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Membership>>("/v3/lol/stats/{format}/HistoricalMemberships", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Active) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000165</code>.</param>
    public Task<List<Membership>> GetMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/v3/lol/stats/{format}/MembershipsByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Memberships by Team (Historical) Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000165</code>.</param>
    public Task<List<Membership>> GetHistoricalMembershipsByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Membership>>("/v3/lol/stats/{format}/HistoricalMembershipsByTeam/{teamid}",
            parameters);
    }

    /// <summary>
    /// Get Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>100001500</code>.</param>
    public Task<Player> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<Player>("/v3/lol/stats/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Players Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/v3/lol/stats/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Players by Team Asynchronous
    /// </summary>
    /// <param name="teamid">Unique FantasyData Team ID. Example:<code>100000165</code>.</param>
    public Task<List<Player>> GetPlayersByTeamAsync(int teamid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("teamid", teamid.ToString())};
        return this.GetAsync<List<Player>>("/v3/lol/stats/{format}/PlayersByTeam/{teamid}", parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Example: <code>100000278</code>, etc</param>
    public Task<List<Game>> GetScheduleAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Game>>("/v3/lol/stats/{format}/Schedule/{roundid}", parameters);
    }

    /// <summary>
    /// Get Season Teams Asynchronous
    /// </summary>
    /// <param name="seasonid">Unique FantasyData Season ID. SeasonIDs can be found in the Competitions and Competition Details endpoints. Examples: <code>100000057</code>, etc</param>
    public Task<List<SeasonTeam>> GetSeasonTeamsAsync(int seasonid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("seasonid", seasonid.ToString())};
        return this.GetAsync<List<SeasonTeam>>("/v3/lol/stats/{format}/SeasonTeams/{seasonid}", parameters);
    }

    /// <summary>
    /// Get Spells Asynchronous
    /// </summary>
    public Task<List<Spell>> GetSpellsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Spell>>("/v3/lol/stats/{format}/Spells", parameters);
    }

    /// <summary>
    /// Get Standings Asynchronous
    /// </summary>
    /// <param name="roundid">Unique FantasyData Round ID. RoundIDs can be found in the Competitions and Competition Details endpoints. Example: <code>100000278</code>, etc</param>
    public Task<List<Standing>> GetStandingsAsync(int roundid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("roundid", roundid.ToString())};
        return this.GetAsync<List<Standing>>("/v3/lol/stats/{format}/Standings/{roundid}", parameters);
    }

    /// <summary>
    /// Get Teams Asynchronous
    /// </summary>
    public Task<List<Team>> GetTeamsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Team>>("/v3/lol/stats/{format}/Teams", parameters);
    }

    /// <summary>
    /// Get Venues Asynchronous
    /// </summary>
    public Task<List<Venue>> GetVenuesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Venue>>("/v3/lol/stats/{format}/Venues", parameters);
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.Golf;

namespace FantasyData.Api.Client;

public partial class Golfv2Client : BaseClient
{
    public Golfv2Client(string apiKey) : base(apiKey)
    {
    }

    public Golfv2Client(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get Injuries Asynchronous
    /// </summary>
    public Task<List<Injury>> GetInjuriesAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Injury>>("/golf/v2/{format}/Injuries", parameters);
    }

    /// <summary>
    /// Get Injuries (Historical) Asynchronous
    /// </summary>
    public Task<List<Injury>> GetInjuriesByHistoricalAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Injury>>("/golf/v2/{format}/InjuriesByHistorical", parameters);
    }

    /// <summary>
    /// Get Leaderboard Asynchronous
    /// </summary>
    /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
    public Task<Leaderboard> GetLeaderboardAsync(int tournamentid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("tournamentid", tournamentid.ToString())};
        return this.GetAsync<Leaderboard>("/golf/v2/{format}/Leaderboard/{tournamentid}", parameters);
    }

    /// <summary>
    /// Get News Asynchronous
    /// </summary>
    public Task<List<News>> GetNewsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<News>>("/golf/v2/{format}/News", parameters);
    }

    /// <summary>
    /// Get News by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2015-JUL-31</code>, <code>2015-SEP-01</code>.</param>
    public Task<List<News>> GetNewsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<News>>("/golf/v2/{format}/NewsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get News by Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
    public Task<List<News>> GetNewsByPlayerIDAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<List<News>>("/golf/v2/{format}/NewsByPlayerID/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Asynchronous
    /// </summary>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
    public Task<Player> GetPlayerAsync(int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("playerid", playerid.ToString())};
        return this.GetAsync<Player>("/golf/v2/{format}/Player/{playerid}", parameters);
    }

    /// <summary>
    /// Get Player Season Stats (w/ World Golf Rankings) Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
    public Task<List<PlayerSeason>> GetPlayerSeasonStatsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<PlayerSeason>>("/golf/v2/{format}/PlayerSeasonStats/{season}", parameters);
    }

    /// <summary>
    /// Get Player Tournament Projected Stats (w/ DraftKings Salaries) Asynchronous
    /// </summary>
    /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>78</code>, <code>79</code>, <code>80</code>, etc.</param>
    public Task<List<PlayerTournamentProjection>> GetPlayerTournamentProjectionStatsAsync(int tournamentid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("tournamentid", tournamentid.ToString())};
        return this.GetAsync<List<PlayerTournamentProjection>>(
            "/golf/v2/{format}/PlayerTournamentProjectionStats/{tournamentid}", parameters);
    }

    /// <summary>
    /// Get Player Tournament Stats By Player Asynchronous
    /// </summary>
    /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>40000019</code>.</param>
    public Task<PlayerTournament> GetPlayerTournamentStatsByPlayerAsync(int tournamentid, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("tournamentid", tournamentid.ToString()),
            new("playerid", playerid.ToString())
        };
        return this.GetAsync<PlayerTournament>(
            "/golf/v2/{format}/PlayerTournamentStatsByPlayer/{tournamentid}/{playerid}", parameters);
    }

    /// <summary>
    /// Get Players Asynchronous
    /// </summary>
    public Task<List<Player>> GetPlayersAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Player>>("/golf/v2/{format}/Players", parameters);
    }

    /// <summary>
    /// Get Schedule Asynchronous
    /// </summary>
    public Task<List<Tournament>> GetTournamentsAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Tournament>>("/golf/v2/{format}/Tournaments", parameters);
    }

    /// <summary>
    /// Get DFS Slates Asynchronous
    /// </summary>
    /// <param name="tournamentid">The TournamentID of a tournament. TournamentIDs can be found in the Tournaments API. Valid entries are <code>58</code>, <code>61</code>, etc.</param>
    public Task<List<DfsSlate>> GetDfsSlatesByTournamentAsync(int tournamentid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("tournamentid", tournamentid.ToString())};
        return this.GetAsync<List<DfsSlate>>("/golf/v2/{format}/DfsSlatesByTournament/{tournamentid}", parameters);
    }

    /// <summary>
    /// Get Schedule by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season. Examples: <code>2016</code>, <code>2017</code>.</param>
    public Task<List<Tournament>> GetTournamentsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<Tournament>>("/golf/v2/{format}/Tournaments/{season}", parameters);
    }

    /// <summary>
    /// Get Current Season Asynchronous
    /// </summary>
    public Task<Season> GetCurrentSeasonAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<Season>("/golf/v2/{format}/CurrentSeason", parameters);
    }
}
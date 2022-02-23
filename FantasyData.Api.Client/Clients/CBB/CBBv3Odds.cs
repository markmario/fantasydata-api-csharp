using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.CBB;

namespace FantasyData.Api.Client;

public class CBBv3OddsClient : BaseClient
{
    public CBBv3OddsClient(string apiKey, HttpClient client) : base(apiKey, client)
    {

    }

    /// <summary>
    /// Get In-Game Odds by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    public Task<List<GameInfo>> GetLiveGameOddsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<GameInfo>>("/v3/cbb/odds/{format}/LiveGameOddsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get In-Game Odds Line Movement Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>17775</code> or <code>17776</code></param>
    public Task<List<GameInfo>> GetLiveGameOddsLineMovementAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/cbb/odds/{format}/LiveGameOddsLineMovement/{gameid}", parameters);
    }

    /// <summary>
    /// Get Pre-Game Odds by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    public Task<List<GameInfo>> GetGameOddsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<GameInfo>>("/v3/cbb/odds/{format}/GameOddsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Pre-Game Odds Line Movement Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>17775</code> or <code>17776</code></param>
    public Task<List<GameInfo>> GetGameOddsLineMovementAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/cbb/odds/{format}/GameOddsLineMovement/{gameid}", parameters);
    }

    /// <summary>
    /// Get Alternate Market Pre-Game Odds by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    public Task<List<GameInfo>> GetAlternateMarketGameOddsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<GameInfo>>("/v3/cbb/odds/{format}/AlternateMarketGameOddsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Alternate Market Pre-Game Odds Line Movement Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of an CBB game. GameIDs can be found in the Games API. Valid entries are <code>17775</code> or <code>17776</code></param>
    public Task<List<GameInfo>> GetAlternateMarketGameOddsLineMovementAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/cbb/odds/{format}/AlternateMarketGameOddsLineMovement/{gameid}",
            parameters);
    }

    /// <summary>
    /// Get Betting Trends By Matchup Asynchronous
    /// </summary>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>OU</code>, <code>UK</code>.</param>
    /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>OU</code>, <code>UK</code>.</param>
    public Task<MatchupTrends> GetMatchupTrendsAsync(string team, string opponent)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("team", team),
            new("opponent", opponent)
        };
        return this.GetAsync<MatchupTrends>("/v3/cbb/odds/{format}/MatchupTrends/{team}/{opponent}", parameters);
    }

    /// <summary>
    /// Get Betting Trends By Team Asynchronous
    /// </summary>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>OU</code>, <code>UK</code>.</param>
    public Task<TeamTrends> GetTeamTrendsAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<TeamTrends>("/v3/cbb/odds/{format}/TeamTrends/{team}", parameters);
    }

    /// <summary>
    /// Get Betting Events by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BettingEvent>>("/v3/cbb/odds/{format}/BettingEventsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Betting Events by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
    public Task<List<BettingEvent>> GetBettingEventsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<BettingEvent>>("/v3/cbb/odds/{format}/BettingEvents/{season}", parameters);
    }

    /// <summary>
    /// Get Betting Futures by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
    public Task<List<BettingEvent>> GetBettingFuturesBySeasonAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<BettingEvent>>("/v3/cbb/odds/{format}/BettingFuturesBySeason/{season}", parameters);
    }

    /// <summary>
    /// Get Betting Market Asynchronous
    /// </summary>
    /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
    public Task<BettingMarket> GetBettingMarketAsync(string marketId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("marketId", marketId)};
        return this.GetAsync<BettingMarket>("/v3/cbb/odds/{format}/BettingMarket/{marketId}", parameters);
    }

    /// <summary>
    /// Get Betting Markets by Event Asynchronous
    /// </summary>
    /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
    public Task<List<BettingMarket>> GetBettingMarketsAsync(string eventId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("eventId", eventId)};
        return this.GetAsync<List<BettingMarket>>("/v3/cbb/odds/{format}/BettingMarkets/{eventId}", parameters);
    }

    /// <summary>
    /// Get Betting Markets by GameID Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets).</param>
    public Task<List<BettingMarket>> GetBettingMarketsByGameIDAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<List<BettingMarket>>("/v3/cbb/odds/{format}/BettingMarketsByGameID/{gameid}", parameters);
    }

    /// <summary>
    /// Get Betting Markets by Market Type Asynchronous
    /// </summary>
    /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
    /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for Game Lines, <code>2</code> for Player Props, <code>3</code> for Team Props, <code>6</code> for Game Props</param>
    public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventId, string marketTypeID)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("eventId", eventId),
            new("marketTypeID", marketTypeID)
        };
        return this.GetAsync<List<BettingMarket>>(
            "/v3/cbb/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}", parameters);
    }

    /// <summary>
    /// Get Betting Player Props by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2020-10-17</code></param>
    public Task<List<BettingEvent>> GetBettingPlayerPropsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BettingEvent>>("/v3/cbb/odds/{format}/BettingPlayerPropsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Betting Metadata Asynchronous
    /// </summary>
    public Task<List<BettingEntityMetadata>> GetBettingMetadataAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<BettingEntityMetadata>>("/v3/cbb/odds/{format}/BettingMetadata", parameters);
    }

    /// <summary>
    /// Get Sportsbooks (Active) Asynchronous
    /// </summary>
    public Task<List<Sportsbook>> GetActiveSportsbooksAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Sportsbook>>("/v3/cbb/odds/{format}/ActiveSportsbooks", parameters);
    }

    /// <summary>
    /// Get Betting Splits By BettingMarketId Asynchronous
    /// </summary>
    /// <param name="marketId">The MarketId of the desired market for which to pull splits. MarketIds are pulled from the Betting Markets endpoints.</param>
    public Task<BettingMarketSplit> GetBettingSplitsByMarketIdAsync(string marketId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("marketId", marketId)};
        return this.GetAsync<BettingMarketSplit>("/v3/cbb/odds/{format}/BettingSplitsByMarketId/{marketId}",
            parameters);
    }

    /// <summary>
    /// Get Betting Splits By GameID Asynchronous
    /// </summary>
    /// <param name="gameId">The ID of the game for which you want to receive splits for. GameIds are pulled from the Schedules and Games by Date endpoints.</param>
    public Task<GameBettingSplit> GetBettingSplitsByGameIdAsync(int gameId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameId", gameId.ToString())};
        return this.GetAsync<GameBettingSplit>("/v3/cbb/odds/{format}/BettingSplitsByGameId/{gameId}", parameters);
    }

    /// <summary>
    /// Get Betting Player Props by GameID Asynchronous
    /// </summary>
    /// <param name="gameId">The unique GameID of the game in question.</param>
    public Task<List<BettingMarket>> GetBettingPlayerPropsByGameIDAsync(int gameId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameId", gameId.ToString())};
        return this.GetAsync<List<BettingMarket>>("/v3/cbb/odds/{format}/BettingPlayerPropsByGameID/{gameId}",
            parameters);
    }

    /// <summary>
    /// Get Betting Resulting By Market Asynchronous
    /// </summary>
    /// <param name="marketId">BettingMarketID of the market for which you would like to see resulted outcomes. Valid example ID <code>96401</code>, <code>93518</code></param>
    public Task<BettingMarketResult> GetBettingMarketResultsAsync(string marketId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("marketId", marketId)};
        return this.GetAsync<BettingMarketResult>("/v3/cbb/odds/{format}/BettingMarketResults/{marketId}", parameters);
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NHL;

namespace FantasyData.Api.Client;

public partial class NHLv3OddsClient : BaseClient
{
    public NHLv3OddsClient(string apiKey) : base(apiKey)
    {
    }

    public NHLv3OddsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get In-Game Odds by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    public Task<List<GameInfo>> GetLiveGameOddsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<GameInfo>>("/v3/nhl/odds/{format}/LiveGameOddsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get In-Game Odds Line Movement Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
    public Task<List<GameInfo>> GetLiveGameOddsLineMovementAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/nhl/odds/{format}/LiveGameOddsLineMovement/{gameid}", parameters);
    }

    /// <summary>
    /// Get Pre-Game Odds by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    public Task<List<GameInfo>> GetGameOddsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<GameInfo>>("/v3/nhl/odds/{format}/GameOddsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Pre-Game Odds Line Movement Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
    public Task<List<GameInfo>> GetGameOddsLineMovementAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/nhl/odds/{format}/GameOddsLineMovement/{gameid}", parameters);
    }

    /// <summary>
    /// Get Generated Player Props by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    public Task<List<PlayerProp>> GetPlayerPropsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<PlayerProp>>("/v3/nhl/odds/{format}/PlayerPropsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Generated Player Props by Player Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    /// <param name="playerid">Unique FantasyData Player ID. Example:<code>30000378</code></param>
    public Task<List<PlayerProp>> GetPlayerPropsByPlayerIDAsync(string date, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("date", date), new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerProp>>("/v3/nhl/odds/{format}/PlayerPropsByPlayerID/{date}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Generated Player Props by Team Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
    public Task<List<PlayerProp>> GetPlayerPropsByTeamAsync(string date, string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date), new("team", team)};
        return this.GetAsync<List<PlayerProp>>("/v3/nhl/odds/{format}/PlayerPropsByTeam/{date}/{team}", parameters);
    }

    /// <summary>
    /// Get Alternate Market Pre-Game Odds by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2018-11-20</code>, <code>2018-11-23</code>.</param>
    public Task<List<GameInfo>> GetAlternateMarketGameOddsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<GameInfo>>("/v3/nhl/odds/{format}/AlternateMarketGameOddsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Alternate Market Pre-Game Odds Line Movement Asynchronous
    /// </summary>
    /// <param name="gameid">The GameID of an NHL game. GameIDs can be found in the Games API. Valid entries are <code>13096</code> or <code>13110</code></param>
    public Task<List<GameInfo>> GetAlternateMarketGameOddsLineMovementAsync(int gameid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameid", gameid.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/nhl/odds/{format}/AlternateMarketGameOddsLineMovement/{gameid}",
            parameters);
    }

    /// <summary>
    /// Get Betting Trends by Matchup Asynchronous
    /// </summary>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
    /// <param name="opponent">The abbreviation of the requested opponent. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
    public Task<MatchupTrends> GetMatchupTrendsAsync(string team, string opponent)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team), new("opponent", opponent)};
        return this.GetAsync<MatchupTrends>("/v3/nhl/odds/{format}/MatchupTrends/{team}/{opponent}", parameters);
    }

    /// <summary>
    /// Get Betting Trends by Team Asynchronous
    /// </summary>
    /// <param name="team">The abbreviation of the requested team. Examples: <code>PHI</code>, <code>MIN</code>, <code>DET</code>, etc.</param>
    public Task<TeamTrends> GetTeamTrendsAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<TeamTrends>("/v3/nhl/odds/{format}/TeamTrends/{team}", parameters);
    }

    /// <summary>
    /// Get Betting Events by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2020-02-15</code>, <code>2020-02-23</code>.</param>
    public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingEventsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Betting Events by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2020</code>, <code>2020PRE</code>, <code>2020POST</code>, <code>2020STAR</code>, <code>2021</code>, etc.</param>
    public Task<List<BettingEvent>> GetBettingEventsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingEvents/{season}", parameters);
    }

    /// <summary>
    /// Get Betting Futures by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc</param>
    public Task<List<BettingEvent>> GetBettingFuturesBySeasonAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingFuturesBySeason/{season}", parameters);
    }

    /// <summary>
    /// Get Betting Market Asynchronous
    /// </summary>
    /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets. Valid entries include: <code>421</code>, <code>1041</code>, etc.</param>
    public Task<BettingMarket> GetBettingMarketAsync(string marketId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("marketId", marketId)};
        return this.GetAsync<BettingMarket>("/v3/nhl/odds/{format}/BettingMarket/{marketId}", parameters);
    }

    /// <summary>
    /// Get Betting Markets by Event Asynchronous
    /// </summary>
    /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
    public Task<List<BettingMarket>> GetBettingMarketsAsync(string eventId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("eventId", eventId)};
        return this.GetAsync<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarkets/{eventId}", parameters);
    }

    /// <summary>
    /// Get Betting Markets by GameID Asynchronous
    /// </summary>
    /// <param name="gameID">The GameID of the desired game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>14814</code></param>
    public Task<List<BettingMarket>> GetBettingMarketsByGameIDAsync(int gameID)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameID", gameID.ToString())};
        return this.GetAsync<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingMarketsByGameID/{gameID}", parameters);
    }

    /// <summary>
    /// Get Betting Markets by Market Type Asynchronous
    /// </summary>
    /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets). Valid entries include: <code>134</code>, <code>155</code>, etc.</param>
    /// <param name="marketTypeID">The Market Type ID of the desired MarketTypes to pull. Some common types include: <code>1</code> for `Game Lines` <code>2</code> for `Player Props` <code>3</code> for `Team Props` <code>6</code> for `Game Props`</param>
    public Task<List<BettingMarket>> GetBettingMarketsByMarketTypeAsync(string eventId, string marketTypeID)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("eventId", eventId), new("marketTypeID", marketTypeID)
        };
        return this.GetAsync<List<BettingMarket>>(
            "/v3/nhl/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}", parameters);
    }

    /// <summary>
    /// Get Betting Player Props by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2020-02-15</code>, <code>2020-02-23</code>.</param>
    public Task<List<BettingEvent>> GetBettingPlayerPropsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BettingEvent>>("/v3/nhl/odds/{format}/BettingPlayerPropsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Betting Metadata Asynchronous
    /// </summary>
    public Task<List<BettingEntityMetadata>> GetBettingmetadataAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<BettingEntityMetadata>>("/v3/nhl/odds/{format}/Bettingmetadata", parameters);
    }

    /// <summary>
    /// Get Sportsbooks (Active) Asynchronous
    /// </summary>
    public Task<List<Sportsbook>> GetActiveSportsbooksAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Sportsbook>>("/v3/nhl/odds/{format}/ActiveSportsbooks", parameters);
    }

    /// <summary>
    /// Get Betting Splits By BettingMarketId Asynchronous
    /// </summary>
    /// <param name="marketId">The MarketId of the desired market for which to pull splits. MarketIds are pulled from the Betting Markets endpoints.</param>
    public Task<BettingMarketSplit> GetBettingSplitsByMarketIdAsync(string marketId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("marketId", marketId)};
        return this.GetAsync<BettingMarketSplit>("/v3/nhl/odds/{format}/BettingSplitsByMarketId/{marketId}",
            parameters);
    }

    /// <summary>
    /// Get Betting Splits By GameID Asynchronous
    /// </summary>
    /// <param name="gameId">The ID of the game for which you want to receive splits for. GameIds are pulled from the Schedules and Games by Date endpoints.</param>
    public Task<GameBettingSplit> GetBettingSplitsByGameIdAsync(int gameId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameId", gameId.ToString())};
        return this.GetAsync<GameBettingSplit>("/v3/nhl/odds/{format}/BettingSplitsByGameId/{gameId}", parameters);
    }

    /// <summary>
    /// Get Betting Player Props by GameID Asynchronous
    /// </summary>
    /// <param name="gameId">The unique GameID of the game in question.</param>
    public Task<List<BettingMarket>> GetBettingPlayerPropsByGameIDAsync(int gameId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("gameId", gameId.ToString())};
        return this.GetAsync<List<BettingMarket>>("/v3/nhl/odds/{format}/BettingPlayerPropsByGameID/{gameId}",
            parameters);
    }

    /// <summary>
    /// Get Betting Results By Market Asynchronous
    /// </summary>
    /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
    public Task<BettingMarketResult> GetBettingMarketResultsAsync(string marketId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("marketId", marketId)};
        return this.GetAsync<BettingMarketResult>("/v3/nhl/odds/{format}/BettingMarketResults/{marketId}", parameters);
    }
}
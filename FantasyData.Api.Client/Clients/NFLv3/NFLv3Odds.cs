using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyData.Api.Client.Model.NFLv3;

namespace FantasyData.Api.Client;

public partial class NFLv3OddsClient : BaseClient
{
    public NFLv3OddsClient(string apiKey) : base(apiKey)
    {
    }

    public NFLv3OddsClient(Guid apiKey) : base(apiKey)
    {
    }

    /// <summary>
    /// Get In-Game Odds by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
    /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
    public Task<List<GameInfo>> GetLiveGameOddsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/nfl/odds/{format}/LiveGameOddsByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get In-Game Odds Line Movement Asynchronous
    /// </summary>
    /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
    public Task<List<GameInfo>> GetLiveGameOddsLineMovementAsync(int scoreid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("scoreid", scoreid.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/nfl/odds/{format}/LiveGameOddsLineMovement/{scoreid}", parameters);
    }

    /// <summary>
    /// Get Pre-Game Odds by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
    /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
    public Task<List<GameInfo>> GetGameOddsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/nfl/odds/{format}/GameOddsByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Pre-Game Odds Line Movement Asynchronous
    /// </summary>
    /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
    public Task<List<GameInfo>> GetGameOddsLineMovementAsync(int scoreid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("scoreid", scoreid.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/nfl/odds/{format}/GameOddsLineMovement/{scoreid}", parameters);
    }

    /// <summary>
    /// Get Generated Player Props by Player Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code></param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code>, <code>2</code>, etc</param>
    /// <param name="playerid">Each NFL player has a unique ID assigned by FantasyData. Player IDs can be determined by pulling player related data. Example: <code>17920</code>, <code>16771</code>, etc.</param>
    public Task<List<PlayerProp>> GetPlayerPropsByPlayerIDAsync(string season, int week, int playerid)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("playerid", playerid.ToString())
        };
        return this.GetAsync<List<PlayerProp>>("/v3/nfl/odds/{format}/PlayerPropsByPlayerID/{season}/{week}/{playerid}",
            parameters);
    }

    /// <summary>
    /// Get Generated Player Props by Team Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code></param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code>, <code>2</code>, etc</param>
    /// <param name="team">Abbreviation of the team. Example: <code>PHI</code>, <code>NE</code>, etc.</param>
    public Task<List<PlayerProp>> GetPlayerPropsByTeamAsync(string season, int week, string team)
    {
        var parameters = new List<KeyValuePair<string, string>>
        {
            new("season", season), new("week", week.ToString()), new("team", team)
        };
        return this.GetAsync<List<PlayerProp>>("/v3/nfl/odds/{format}/PlayerPropsByTeam/{season}/{week}/{team}",
            parameters);
    }

    /// <summary>
    /// Get Generated Player Props by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season and the season type. If no season type is provided, then the default is regular season. Examples: <code>2018REG</code>, <code>2018PRE</code>, <code>2018POST</code></param>
    /// <param name="week">Week of the season. Valid values are as follows: Preseason 0 to 4, Regular Season 1 to 17, Postseason 1 to 4. Example: <code>1</code>, <code>2</code>, etc</param>
    public Task<List<PlayerProp>> GetPlayerPropsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<PlayerProp>>("/v3/nfl/odds/{format}/PlayerPropsByWeek/{season}/{week}", parameters);
    }

    /// <summary>
    /// Get Alternate Market Pre-Game Odds by Week Asynchronous
    /// </summary>
    /// <param name="season">Year of the season, with optional season type. Examples: <code>2018</code>, <code>2018POST</code>, etc.</param>
    /// <param name="week">The week of the scores (games). Examples: <code>1</code>, <code>2</code>, etc.</param>
    public Task<List<GameInfo>> GetAlternateMarketGameOddsByWeekAsync(string season, int week)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season), new("week", week.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/nfl/odds/{format}/AlternateMarketGameOddsByWeek/{season}/{week}",
            parameters);
    }

    /// <summary>
    /// Get Alternate Market Pre-Game Odds Line Movement  Asynchronous
    /// </summary>
    /// <param name="scoreid">The ScoreID of an NFL score (game). ScoreIDs can be found in the Scores API. Valid entries are <code>16654</code> or <code>16667</code></param>
    public Task<List<GameInfo>> GetAlternateMarketGameOddsLineMovementAsync(int scoreid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("scoreid", scoreid.ToString())};
        return this.GetAsync<List<GameInfo>>("/v3/nfl/odds/{format}/AlternateMarketGameOddsLineMovement/{scoreid}",
            parameters);
    }

    /// <summary>
    /// Get Betting Trends by Matchup Asynchronous
    /// </summary>
    /// <param name="team">Abbreviation of a team. Example: <code>PHI</code>.</param>
    /// <param name="opponent">Abbreviation of an opponent. Example: <code>NE</code>.</param>
    public Task<MatchupTrends> GetMatchupTrendsAsync(string team, string opponent)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team), new("opponent", opponent)};
        return this.GetAsync<MatchupTrends>("/v3/nfl/odds/{format}/MatchupTrends/{team}/{opponent}", parameters);
    }

    /// <summary>
    /// Get Betting Trends by Team Asynchronous
    /// </summary>
    /// <param name="team">Abbreviation of a team. Example: <code>PHI</code>.</param>
    public Task<TeamTrends> GetTeamTrendsAsync(string team)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("team", team)};
        return this.GetAsync<TeamTrends>("/v3/nfl/odds/{format}/TeamTrends/{team}", parameters);
    }

    /// <summary>
    /// Get Betting Events by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2020-09-10</code>, <code>2020-09-13</code>.</param>
    public Task<List<BettingEvent>> GetBettingEventsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BettingEvent>>("/v3/nfl/odds/{format}/BettingEventsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Betting Events by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season Examples: <code>2020</code>, <code>2021</code>, etc.</param>
    public Task<List<BettingEvent>> GetBettingEventsAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<BettingEvent>>("/v3/nfl/odds/{format}/BettingEvents/{season}", parameters);
    }

    /// <summary>
    /// Get Betting Futures by Season Asynchronous
    /// </summary>
    /// <param name="season">Year of the season (with optional season type). Examples: <code>2020REG</code>, <code>2020PRE</code>, <code>2020POST</code>, <code>2021</code>, etc.</param>
    public Task<List<BettingEvent>> GetBettingFuturesBySeasonAsync(string season)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("season", season)};
        return this.GetAsync<List<BettingEvent>>("/v3/nfl/odds/{format}/BettingFuturesBySeason/{season}", parameters);
    }

    /// <summary>
    /// Get Betting Market Asynchronous
    /// </summary>
    /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
    public Task<BettingMarket> GetBettingMarketAsync(string marketId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("marketId", marketId)};
        return this.GetAsync<BettingMarket>("/v3/nfl/odds/{format}/BettingMarket/{marketId}", parameters);
    }

    /// <summary>
    /// Get Betting Markets by Event Asynchronous
    /// </summary>
    /// <param name="eventId">The EventId of the desired event/game for which to pull all betting markets (includes outcomes/bets).</param>
    public Task<List<BettingMarket>> GetBettingMarketsAsync(string eventId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("eventId", eventId)};
        return this.GetAsync<List<BettingMarket>>("/v3/nfl/odds/{format}/BettingMarkets/{eventId}", parameters);
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
            new("eventId", eventId), new("marketTypeID", marketTypeID)
        };
        return this.GetAsync<List<BettingMarket>>(
            "/v3/nfl/odds/{format}/BettingMarketsByMarketType/{eventId}/{marketTypeID}", parameters);
    }

    /// <summary>
    /// Get Betting Markets by ScoreID Asynchronous
    /// </summary>
    /// <param name="scoreid">The ScoreID of the desired game/score for which to pull all betting markets (includes outcomes/bets).</param>
    public Task<List<BettingMarket>> GetBettingMarketsByScoreIDAsync(int scoreid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("scoreid", scoreid.ToString())};
        return this.GetAsync<List<BettingMarket>>("/v3/nfl/odds/{format}/BettingMarketsByScoreID/{scoreid}",
            parameters);
    }

    /// <summary>
    /// Get Betting Player Props by Date Asynchronous
    /// </summary>
    /// <param name="date">The date of the game(s). Examples: <code>2020-09-10</code>, <code>2020-09-13</code>.</param>
    public Task<List<BettingEvent>> GetBettingPlayerPropsByDateAsync(string date)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("date", date)};
        return this.GetAsync<List<BettingEvent>>("/v3/nfl/odds/{format}/BettingPlayerPropsByDate/{date}", parameters);
    }

    /// <summary>
    /// Get Betting Metadata Asynchronous
    /// </summary>
    public Task<List<BettingEntityMetadata>> GetBettingMetadataAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<BettingEntityMetadata>>("/v3/nfl/odds/{format}/BettingMetadata", parameters);
    }

    /// <summary>
    /// Get Sportsbooks (Active) Asynchronous
    /// </summary>
    public Task<List<Sportsbook>> GetActiveSportsbooksAsync()
    {
        var parameters = new List<KeyValuePair<string, string>>();
        return this.GetAsync<List<Sportsbook>>("/v3/nfl/odds/{format}/ActiveSportsbooks", parameters);
    }

    /// <summary>
    /// Get Betting Splits By BettingMarketId Asynchronous
    /// </summary>
    /// <param name="marketId">The BettingMarketID of the market you would like to get splits for. Note that markets we do not have split information on will return an empty response.</param>
    public Task<BettingMarketSplit> GetBettingSplitsByMarketIdAsync(string marketId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("marketId", marketId)};
        return this.GetAsync<BettingMarketSplit>("/v3/nfl/odds/{format}/BettingSplitsByMarketId/{marketId}",
            parameters);
    }

    /// <summary>
    /// Get Betting Splits By ScoreID Asynchronous
    /// </summary>
    /// <param name="scoreId">The ScoreID of the desired game to get Betting Market Splits for</param>
    public Task<GameBettingSplit> GetBettingSplitsByScoreIdAsync(int scoreId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("scoreId", scoreId.ToString())};
        return this.GetAsync<GameBettingSplit>("/v3/nfl/odds/{format}/BettingSplitsByScoreId/{scoreId}", parameters);
    }

    /// <summary>
    /// Get Betting Results By Market Asynchronous
    /// </summary>
    /// <param name="marketId">The MarketId of the desired market for which to pull all outcomes/bets.</param>
    public Task<BettingMarketResult> GetBettingMarketResultsAsync(string marketId)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("marketId", marketId)};
        return this.GetAsync<BettingMarketResult>("/v3/nfl/odds/{format}/BettingMarketResults/{marketId}", parameters);
    }

    /// <summary>
    /// Get Betting Player Props by ScoreID Asynchronous
    /// </summary>
    /// <param name="scoreid">The unique ScoreID of the game in question.</param>
    public Task<List<BettingMarket>> GetBettingPlayerPropsByScoreIDAsync(int scoreid)
    {
        var parameters = new List<KeyValuePair<string, string>> {new("scoreid", scoreid.ToString())};
        return this.GetAsync<List<BettingMarket>>("/v3/nfl/odds/{format}/BettingPlayerPropsByScoreID/{scoreid}",
            parameters);
    }
}
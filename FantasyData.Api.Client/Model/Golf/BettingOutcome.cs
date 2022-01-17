﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.Golf;

[DataContract(Namespace="", Name="BettingOutcome")]
[Serializable]
public partial class BettingOutcome
{
    /// <summary>
    /// The unique identifier of this outcome
    /// </summary>
    [Description("The unique identifier of this outcome")]
    [DataMember(Name = "BettingOutcomeID", Order = 1)]
    public int? BettingOutcomeID { get; set; }

    /// <summary>
    /// The unique identifier of the market this betting outcome exists for
    /// </summary>
    [Description("The unique identifier of the market this betting outcome exists for")]
    [DataMember(Name = "BettingMarketID", Order = 2)]
    public int? BettingMarketID { get; set; }

    /// <summary>
    /// The sportsbook offering this outcome for betting
    /// </summary>
    [Description("The sportsbook offering this outcome for betting")]
    [DataMember(Name = "SportsBook", Order = 10003)]
    public Sportsbook SportsBook { get; set; }

    /// <summary>
    /// The BettingOutcomeTypeID of this outcome
    /// </summary>
    [Description("The BettingOutcomeTypeID of this outcome")]
    [DataMember(Name = "BettingOutcomeTypeID", Order = 4)]
    public int? BettingOutcomeTypeID { get; set; }

    /// <summary>
    /// The BettingOutcomeType of this outcome
    /// </summary>
    [Description("The BettingOutcomeType of this outcome")]
    [DataMember(Name = "BettingOutcomeType", Order = 5)]
    public string BettingOutcomeType { get; set; }

    /// <summary>
    /// The american odds payout 
    /// </summary>
    [Description("The american odds payout ")]
    [DataMember(Name = "PayoutAmerican", Order = 6)]
    public int? PayoutAmerican { get; set; }

    /// <summary>
    /// The decimal odds payout
    /// </summary>
    [Description("The decimal odds payout")]
    [DataMember(Name = "PayoutDecimal", Order = 7)]
    public decimal? PayoutDecimal { get; set; }

    /// <summary>
    /// The number associated with the outcome (spread/total/etc)
    /// </summary>
    [Description("The number associated with the outcome (spread/total/etc)")]
    [DataMember(Name = "Value", Order = 8)]
    public decimal? Value { get; set; }

    /// <summary>
    /// The name of the participant (typically team or player) associated with the outcome
    /// </summary>
    [Description("The name of the participant (typically team or player) associated with the outcome")]
    [DataMember(Name = "Participant", Order = 9)]
    public string Participant { get; set; }

    /// <summary>
    /// Is this outcome available for betting as of last update
    /// </summary>
    [Description("Is this outcome available for betting as of last update")]
    [DataMember(Name = "IsAvailable", Order = 10)]
    public bool? IsAvailable { get; set; }

    /// <summary>
    /// Is this an alternate value or the core value
    /// </summary>
    [Description("Is this an alternate value or the core value")]
    [DataMember(Name = "IsAlternate", Order = 11)]
    public bool? IsAlternate { get; set; }

    /// <summary>
    /// The created date of the outcome
    /// </summary>
    [Description("The created date of the outcome")]
    [DataMember(Name = "Created", Order = 12)]
    public DateTime? Created { get; set; }

    /// <summary>
    /// The last updated date of the outcome
    /// </summary>
    [Description("The last updated date of the outcome")]
    [DataMember(Name = "Updated", Order = 13)]
    public DateTime? Updated { get; set; }

    /// <summary>
    /// The datetime the outcome was unlisted (no longer available for bets)
    /// </summary>
    [Description("The datetime the outcome was unlisted (no longer available for bets)")]
    [DataMember(Name = "Unlisted", Order = 14)]
    public DateTime? Unlisted { get; set; }

    /// <summary>
    /// The PlayerID of the player assocated with this outcome (where applicable)
    /// </summary>
    [Description("The PlayerID of the player assocated with this outcome (where applicable)")]
    [DataMember(Name = "PlayerID", Order = 15)]
    public int? PlayerID { get; set; }

    /// <summary>
    /// The URL for sportsbook event
    /// </summary>
    [Description("The URL for sportsbook event")]
    [DataMember(Name = "SportsbookUrl", Order = 16)]
    public string SportsbookUrl { get; set; }

    /// <summary>
    /// A key to identify outcomes which are related and part of the same offering at a sportsbook (for instance, with SixShooter markets, this key would identify all the options for a particular group of golfers)
    /// </summary>
    [Description("A key to identify outcomes which are related and part of the same offering at a sportsbook (for instance, with SixShooter markets, this key would identify all the options for a particular group of golfers)")]
    [DataMember(Name = "GroupKey", Order = 17)]
    public int? GroupKey { get; set; }

    /// <summary>
    /// Indicates if this outcome is considered “in-play/live” (was created after the tournament start date)
    /// </summary>
    [Description("Indicates if this outcome is considered “in-play/live” (was created after the tournament start date)")]
    [DataMember(Name = "IsInPlayTournamentOdd", Order = 18)]
    public bool? IsInPlayTournamentOdd { get; set; }

}
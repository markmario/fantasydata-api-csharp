﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.CBB;

[DataContract(Namespace="", Name="TeamGame")]
[Serializable]
public class TeamGame
{
    /// <summary>
    /// The unique ID of the stat
    /// </summary>
    [Description("The unique ID of the stat")]
    [DataMember(Name = "StatID", Order = 1)]
    public int StatID { get; set; }

    /// <summary>
    /// The unique ID of the team
    /// </summary>
    [Description("The unique ID of the team")]
    [DataMember(Name = "TeamID", Order = 2)]
    public int? TeamID { get; set; }

    /// <summary>
    /// The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).
    /// </summary>
    [Description("The type of season that this record corresponds to (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=AllStar).")]
    [DataMember(Name = "SeasonType", Order = 3)]
    public int? SeasonType { get; set; }

    /// <summary>
    /// The college basketball season of the game
    /// </summary>
    [Description("The college basketball season of the game")]
    [DataMember(Name = "Season", Order = 4)]
    public int? Season { get; set; }

    /// <summary>
    /// Team's name
    /// </summary>
    [Description("Team's name")]
    [DataMember(Name = "Name", Order = 5)]
    public string Name { get; set; }

    /// <summary>
    /// The abbreviation of the Team
    /// </summary>
    [Description("The abbreviation of the Team")]
    [DataMember(Name = "Team", Order = 6)]
    public string Team { get; set; }

    /// <summary>
    /// Total number of team wins
    /// </summary>
    [Description("Total number of team wins")]
    [DataMember(Name = "Wins", Order = 7)]
    public int? Wins { get; set; }

    /// <summary>
    /// Total number of team losses
    /// </summary>
    [Description("Total number of team losses")]
    [DataMember(Name = "Losses", Order = 8)]
    public int? Losses { get; set; }

    /// <summary>
    /// Total number of conference wins
    /// </summary>
    [Description("Total number of conference wins")]
    [DataMember(Name = "ConferenceWins", Order = 9)]
    public int? ConferenceWins { get; set; }

    /// <summary>
    /// Total number of conference losses
    /// </summary>
    [Description("Total number of conference losses")]
    [DataMember(Name = "ConferenceLosses", Order = 10)]
    public int? ConferenceLosses { get; set; }

    /// <summary>
    /// A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.
    /// </summary>
    [Description("A globally unique ID for this team. This value is guaranteed to be unique across all sports/leagues.")]
    [DataMember(Name = "GlobalTeamID", Order = 11)]
    public int? GlobalTeamID { get; set; }

    /// <summary>
    /// Total number of team possessions as defined here: http://www.basketball-reference.com/about/glossary.html
    /// </summary>
    [Description("Total number of team possessions as defined here: http://www.basketball-reference.com/about/glossary.html")]
    [DataMember(Name = "Possessions", Order = 12)]
    public decimal? Possessions { get; set; }

    /// <summary>
    /// The unique ID of this game
    /// </summary>
    [Description("The unique ID of this game")]
    [DataMember(Name = "GameID", Order = 13)]
    public int? GameID { get; set; }

    /// <summary>
    /// The unique ID of the team's opponent
    /// </summary>
    [Description("The unique ID of the team's opponent")]
    [DataMember(Name = "OpponentID", Order = 14)]
    public int? OpponentID { get; set; }

    /// <summary>
    /// The name of the opponent 
    /// </summary>
    [Description("The name of the opponent ")]
    [DataMember(Name = "Opponent", Order = 15)]
    public string Opponent { get; set; }

    /// <summary>
    /// The day of the game
    /// </summary>
    [Description("The day of the game")]
    [DataMember(Name = "Day", Order = 16)]
    public DateTime? Day { get; set; }

    /// <summary>
    /// The date and time of the game
    /// </summary>
    [Description("The date and time of the game")]
    [DataMember(Name = "DateTime", Order = 17)]
    public DateTime? DateTime { get; set; }

    /// <summary>
    /// Whether the team is home or away
    /// </summary>
    [Description("Whether the team is home or away")]
    [DataMember(Name = "HomeOrAway", Order = 18)]
    public string HomeOrAway { get; set; }

    /// <summary>
    /// Whether the game is over (true/false)
    /// </summary>
    [Description("Whether the game is over (true/false)")]
    [DataMember(Name = "IsGameOver", Order = 19)]
    public bool IsGameOver { get; set; }

    /// <summary>
    /// A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.
    /// </summary>
    [Description("A globally unique ID for this game. This value is guaranteed to be unique across all sports/leagues.")]
    [DataMember(Name = "GlobalGameID", Order = 20)]
    public int? GlobalGameID { get; set; }

    /// <summary>
    /// A globally unique ID for this team's opponent. This value is guaranteed to be unique across all sports/leagues.
    /// </summary>
    [Description("A globally unique ID for this team's opponent. This value is guaranteed to be unique across all sports/leagues.")]
    [DataMember(Name = "GlobalOpponentID", Order = 21)]
    public int? GlobalOpponentID { get; set; }

    /// <summary>
    /// The timestamp of when the record was last updated (US Eastern Time).
    /// </summary>
    [Description("The timestamp of when the record was last updated (US Eastern Time).")]
    [DataMember(Name = "Updated", Order = 22)]
    public DateTime? Updated { get; set; }

    /// <summary>
    /// The number of games played.
    /// </summary>
    [Description("The number of games played.")]
    [DataMember(Name = "Games", Order = 23)]
    public int? Games { get; set; }

    /// <summary>
    /// Total fantasy points
    /// </summary>
    [Description("Total fantasy points")]
    [DataMember(Name = "FantasyPoints", Order = 24)]
    public decimal? FantasyPoints { get; set; }

    /// <summary>
    /// Total number of minutes played
    /// </summary>
    [Description("Total number of minutes played")]
    [DataMember(Name = "Minutes", Order = 25)]
    public int? Minutes { get; set; }

    /// <summary>
    /// Total number of field goals made
    /// </summary>
    [Description("Total number of field goals made")]
    [DataMember(Name = "FieldGoalsMade", Order = 26)]
    public int? FieldGoalsMade { get; set; }

    /// <summary>
    /// Total number of field goals attempted
    /// </summary>
    [Description("Total number of field goals attempted")]
    [DataMember(Name = "FieldGoalsAttempted", Order = 27)]
    public int? FieldGoalsAttempted { get; set; }

    /// <summary>
    /// Total field goal percentage
    /// </summary>
    [Description("Total field goal percentage")]
    [DataMember(Name = "FieldGoalsPercentage", Order = 28)]
    public decimal? FieldGoalsPercentage { get; set; }

    /// <summary>
    /// Total effective field goals percentage
    /// </summary>
    [Description("Total effective field goals percentage")]
    [DataMember(Name = "EffectiveFieldGoalsPercentage", Order = 29)]
    public decimal? EffectiveFieldGoalsPercentage { get; set; }

    /// <summary>
    /// Total two pointers made
    /// </summary>
    [Description("Total two pointers made")]
    [DataMember(Name = "TwoPointersMade", Order = 30)]
    public int? TwoPointersMade { get; set; }

    /// <summary>
    /// Total two pointers attempted
    /// </summary>
    [Description("Total two pointers attempted")]
    [DataMember(Name = "TwoPointersAttempted", Order = 31)]
    public int? TwoPointersAttempted { get; set; }

    /// <summary>
    /// Total two pointers percentage
    /// </summary>
    [Description("Total two pointers percentage")]
    [DataMember(Name = "TwoPointersPercentage", Order = 32)]
    public decimal? TwoPointersPercentage { get; set; }

    /// <summary>
    /// Total three pointers made
    /// </summary>
    [Description("Total three pointers made")]
    [DataMember(Name = "ThreePointersMade", Order = 33)]
    public int? ThreePointersMade { get; set; }

    /// <summary>
    /// Total three pointers attempted
    /// </summary>
    [Description("Total three pointers attempted")]
    [DataMember(Name = "ThreePointersAttempted", Order = 34)]
    public int? ThreePointersAttempted { get; set; }

    /// <summary>
    /// Total three pointers percentage
    /// </summary>
    [Description("Total three pointers percentage")]
    [DataMember(Name = "ThreePointersPercentage", Order = 35)]
    public decimal? ThreePointersPercentage { get; set; }

    /// <summary>
    /// Total free throws made
    /// </summary>
    [Description("Total free throws made")]
    [DataMember(Name = "FreeThrowsMade", Order = 36)]
    public int? FreeThrowsMade { get; set; }

    /// <summary>
    /// Total free throws attempted
    /// </summary>
    [Description("Total free throws attempted")]
    [DataMember(Name = "FreeThrowsAttempted", Order = 37)]
    public int? FreeThrowsAttempted { get; set; }

    /// <summary>
    /// Total free throws percentage
    /// </summary>
    [Description("Total free throws percentage")]
    [DataMember(Name = "FreeThrowsPercentage", Order = 38)]
    public decimal? FreeThrowsPercentage { get; set; }

    /// <summary>
    /// Total offensive rebounds
    /// </summary>
    [Description("Total offensive rebounds")]
    [DataMember(Name = "OffensiveRebounds", Order = 39)]
    public int? OffensiveRebounds { get; set; }

    /// <summary>
    /// Total defensive rebounds
    /// </summary>
    [Description("Total defensive rebounds")]
    [DataMember(Name = "DefensiveRebounds", Order = 40)]
    public int? DefensiveRebounds { get; set; }

    /// <summary>
    /// Total rebounds
    /// </summary>
    [Description("Total rebounds")]
    [DataMember(Name = "Rebounds", Order = 41)]
    public int? Rebounds { get; set; }

    /// <summary>
    /// Total offensive rebounds percentage
    /// </summary>
    [Description("Total offensive rebounds percentage")]
    [DataMember(Name = "OffensiveReboundsPercentage", Order = 42)]
    public decimal? OffensiveReboundsPercentage { get; set; }

    /// <summary>
    /// Total defensive rebounds percentage
    /// </summary>
    [Description("Total defensive rebounds percentage")]
    [DataMember(Name = "DefensiveReboundsPercentage", Order = 43)]
    public decimal? DefensiveReboundsPercentage { get; set; }

    /// <summary>
    /// The player/team total rebounds percentage
    /// </summary>
    [Description("The player/team total rebounds percentage")]
    [DataMember(Name = "TotalReboundsPercentage", Order = 44)]
    public decimal? TotalReboundsPercentage { get; set; }

    /// <summary>
    /// Total assists
    /// </summary>
    [Description("Total assists")]
    [DataMember(Name = "Assists", Order = 45)]
    public int? Assists { get; set; }

    /// <summary>
    /// Total steals
    /// </summary>
    [Description("Total steals")]
    [DataMember(Name = "Steals", Order = 46)]
    public int? Steals { get; set; }

    /// <summary>
    /// Total blocked shots
    /// </summary>
    [Description("Total blocked shots")]
    [DataMember(Name = "BlockedShots", Order = 47)]
    public int? BlockedShots { get; set; }

    /// <summary>
    /// Total turnovers
    /// </summary>
    [Description("Total turnovers")]
    [DataMember(Name = "Turnovers", Order = 48)]
    public int? Turnovers { get; set; }

    /// <summary>
    /// Total personal fouls
    /// </summary>
    [Description("Total personal fouls")]
    [DataMember(Name = "PersonalFouls", Order = 49)]
    public int? PersonalFouls { get; set; }

    /// <summary>
    /// Total points
    /// </summary>
    [Description("Total points")]
    [DataMember(Name = "Points", Order = 50)]
    public int? Points { get; set; }

    /// <summary>
    /// The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html
    /// </summary>
    [Description("The player's true shooting attempts as defined here: http://www.basketball-reference.com/about/glossary.html")]
    [DataMember(Name = "TrueShootingAttempts", Order = 51)]
    public decimal? TrueShootingAttempts { get; set; }

    /// <summary>
    /// The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html
    /// </summary>
    [Description("The player's true shooting percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
    [DataMember(Name = "TrueShootingPercentage", Order = 52)]
    public decimal? TrueShootingPercentage { get; set; }

    /// <summary>
    /// The player's linear weight efficiency rating as defined here: http://bleacherreport.com/articles/113144-cracking-the-code-how-to-calculate-hollingers-per-without-all-the-mess
    /// </summary>
    [Description("The player's linear weight efficiency rating as defined here: http://bleacherreport.com/articles/113144-cracking-the-code-how-to-calculate-hollingers-per-without-all-the-mess")]
    [DataMember(Name = "PlayerEfficiencyRating", Order = 53)]
    public decimal? PlayerEfficiencyRating { get; set; }

    /// <summary>
    /// The player's assist percentage as defined here: http://www.basketball-reference.com/about/glossary.html
    /// </summary>
    [Description("The player's assist percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
    [DataMember(Name = "AssistsPercentage", Order = 54)]
    public decimal? AssistsPercentage { get; set; }

    /// <summary>
    /// The player's steal percentage as defined here: http://www.basketball-reference.com/about/glossary.html
    /// </summary>
    [Description("The player's steal percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
    [DataMember(Name = "StealsPercentage", Order = 55)]
    public decimal? StealsPercentage { get; set; }

    /// <summary>
    /// The player's block percentage as defined here: http://www.basketball-reference.com/about/glossary.html
    /// </summary>
    [Description("The player's block percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
    [DataMember(Name = "BlocksPercentage", Order = 56)]
    public decimal? BlocksPercentage { get; set; }

    /// <summary>
    /// The player's turnover percentage as defined here: http://www.basketball-reference.com/about/glossary.html
    /// </summary>
    [Description("The player's turnover percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
    [DataMember(Name = "TurnOversPercentage", Order = 57)]
    public decimal? TurnOversPercentage { get; set; }

    /// <summary>
    /// The player's usage rate percentage as defined here: http://www.basketball-reference.com/about/glossary.html
    /// </summary>
    [Description("The player's usage rate percentage as defined here: http://www.basketball-reference.com/about/glossary.html")]
    [DataMember(Name = "UsageRatePercentage", Order = 58)]
    public decimal? UsageRatePercentage { get; set; }

    /// <summary>
    /// Total Fan Duel daily fantasy points scored
    /// </summary>
    [Description("Total Fan Duel daily fantasy points scored")]
    [DataMember(Name = "FantasyPointsFanDuel", Order = 59)]
    public decimal? FantasyPointsFanDuel { get; set; }

    /// <summary>
    /// Total Draft Kings daily fantasy points scored
    /// </summary>
    [Description("Total Draft Kings daily fantasy points scored")]
    [DataMember(Name = "FantasyPointsDraftKings", Order = 60)]
    public decimal? FantasyPointsDraftKings { get; set; }

    /// <summary>
    /// Total Yahoo daily fantasy points scored
    /// </summary>
    [Description("Total Yahoo daily fantasy points scored")]
    [DataMember(Name = "FantasyPointsYahoo", Order = 61)]
    public decimal? FantasyPointsYahoo { get; set; }

}
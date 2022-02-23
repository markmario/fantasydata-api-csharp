using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace FantasyData.Api.Client.Model.NFLv3;

[DataContract(Namespace="", Name="Timeframe")]
[Serializable]
public class Timeframe : IEquatable<Timeframe>
{
    /// <summary>
    /// The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=All-Star)
    /// </summary>
    [Description("The season type of the timeframe (1=Regular Season, 2=Preseason, 3=Postseason, 4=Offseason, 5=All-Star)")]
    [DataMember(Name = "SeasonType", Order = 1)]
    public int SeasonType { get; set; }

    /// <summary>
    /// The league year of the timeframe (this gets incremented on the first day of the league year during free agency)
    /// </summary>
    [Description("The league year of the timeframe (this gets incremented on the first day of the league year during free agency)")]
    [DataMember(Name = "Season", Order = 2)]
    public int Season { get; set; }

    /// <summary>
    /// The week of the timeframe (Regular Season=1 to 17, Preseason=1 to 4, Postseason=1 to4, Offseason=NULL)
    /// </summary>
    [Description("The week of the timeframe (Regular Season=1 to 17, Preseason=1 to 4, Postseason=1 to4, Offseason=NULL)")]
    [DataMember(Name = "Week", Order = 3)]
    public int? Week { get; set; }

    /// <summary>
    /// The friendly name of the Timeframe
    /// </summary>
    [Description("The friendly name of the Timeframe")]
    [DataMember(Name = "Name", Order = 4)]
    public string Name { get; set; }

    /// <summary>
    /// The shorter name of the Timeframe
    /// </summary>
    [Description("The shorter name of the Timeframe")]
    [DataMember(Name = "ShortName", Order = 5)]
    public string ShortName { get; set; }

    /// <summary>
    /// The start date/time of this Timeframe
    /// </summary>
    [Description("The start date/time of this Timeframe")]
    [DataMember(Name = "StartDate", Order = 6)]
    public DateTime StartDate { get; set; }

    /// <summary>
    /// The end date/time of the Timeframe
    /// </summary>
    [Description("The end date/time of the Timeframe")]
    [DataMember(Name = "EndDate", Order = 7)]
    public DateTime EndDate { get; set; }

    /// <summary>
    /// The start date/time of the first game of the Timeframe (if no games then returns the StartDate)
    /// </summary>
    [Description("The start date/time of the first game of the Timeframe (if no games then returns the StartDate)")]
    [DataMember(Name = "FirstGameStart", Order = 8)]
    public DateTime? FirstGameStart { get; set; }

    /// <summary>
    /// The end date/time of the first game of the Timeframe (if no games then returns the EndDate)
    /// </summary>
    [Description("The end date/time of the first game of the Timeframe (if no games then returns the EndDate)")]
    [DataMember(Name = "FirstGameEnd", Order = 9)]
    public DateTime? FirstGameEnd { get; set; }

    /// <summary>
    /// The end date/time of the last game of the Timeframe (if no games then returns the EndDate)
    /// </summary>
    [Description("The end date/time of the last game of the Timeframe (if no games then returns the EndDate)")]
    [DataMember(Name = "LastGameEnd", Order = 10)]
    public DateTime? LastGameEnd { get; set; }

    /// <summary>
    /// Whether there are any games in this Timeframe
    /// </summary>
    [Description("Whether there are any games in this Timeframe")]
    [DataMember(Name = "HasGames", Order = 11)]
    public bool HasGames { get; set; }

    /// <summary>
    /// Whether this Timeframe has started
    /// </summary>
    [Description("Whether this Timeframe has started")]
    [DataMember(Name = "HasStarted", Order = 12)]
    public bool HasStarted { get; set; }

    /// <summary>
    /// Whether this Timeframe has ended
    /// </summary>
    [Description("Whether this Timeframe has ended")]
    [DataMember(Name = "HasEnded", Order = 13)]
    public bool HasEnded { get; set; }

    /// <summary>
    /// Whether the first game has started
    /// </summary>
    [Description("Whether the first game has started")]
    [DataMember(Name = "HasFirstGameStarted", Order = 14)]
    public bool HasFirstGameStarted { get; set; }

    /// <summary>
    /// Whether the first game has ended
    /// </summary>
    [Description("Whether the first game has ended")]
    [DataMember(Name = "HasFirstGameEnded", Order = 15)]
    public bool HasFirstGameEnded { get; set; }

    /// <summary>
    /// Whether the last game has ended
    /// </summary>
    [Description("Whether the last game has ended")]
    [DataMember(Name = "HasLastGameEnded", Order = 16)]
    public bool HasLastGameEnded { get; set; }

    /// <summary>
    /// The value of the Season parameter used to pass into the API.
    /// </summary>
    [Description("The value of the Season parameter used to pass into the API.")]
    [DataMember(Name = "ApiSeason", Order = 17)]
    public string ApiSeason { get; set; }

    /// <summary>
    /// The value of the Week parameter used to pass into the API.
    /// </summary>
    [Description("The value of the Week parameter used to pass into the API.")]
    [DataMember(Name = "ApiWeek", Order = 18)]
    public string ApiWeek { get; set; }

    public bool Equals(Timeframe other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return this.SeasonType == other.SeasonType && this.Season == other.Season && this.Week == other.Week && string.Equals(this.Name, other.Name, StringComparison.OrdinalIgnoreCase) && string.Equals(this.ShortName, other.ShortName, StringComparison.OrdinalIgnoreCase) && this.StartDate.Equals(other.StartDate) && this.EndDate.Equals(other.EndDate) && Nullable.Equals(this.FirstGameStart, other.FirstGameStart) && Nullable.Equals(this.FirstGameEnd, other.FirstGameEnd) && Nullable.Equals(this.LastGameEnd, other.LastGameEnd) && this.HasGames == other.HasGames && this.HasStarted == other.HasStarted && this.HasEnded == other.HasEnded && this.HasFirstGameStarted == other.HasFirstGameStarted && this.HasFirstGameEnded == other.HasFirstGameEnded && this.HasLastGameEnded == other.HasLastGameEnded && string.Equals(this.ApiSeason, other.ApiSeason, StringComparison.OrdinalIgnoreCase) && string.Equals(this.ApiWeek, other.ApiWeek, StringComparison.OrdinalIgnoreCase);
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        return Equals((Timeframe)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = this.SeasonType;
            hashCode = (hashCode * 397) ^ this.Season;
            hashCode = (hashCode * 397) ^ this.Week.GetHashCode();
            hashCode = (hashCode * 397) ^ (this.Name != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(this.Name) : 0);
            hashCode = (hashCode * 397) ^ (this.ShortName != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(this.ShortName) : 0);
            hashCode = (hashCode * 397) ^ this.StartDate.GetHashCode();
            hashCode = (hashCode * 397) ^ this.EndDate.GetHashCode();
            hashCode = (hashCode * 397) ^ this.FirstGameStart.GetHashCode();
            hashCode = (hashCode * 397) ^ this.FirstGameEnd.GetHashCode();
            hashCode = (hashCode * 397) ^ this.LastGameEnd.GetHashCode();
            hashCode = (hashCode * 397) ^ this.HasGames.GetHashCode();
            hashCode = (hashCode * 397) ^ this.HasStarted.GetHashCode();
            hashCode = (hashCode * 397) ^ this.HasEnded.GetHashCode();
            hashCode = (hashCode * 397) ^ this.HasFirstGameStarted.GetHashCode();
            hashCode = (hashCode * 397) ^ this.HasFirstGameEnded.GetHashCode();
            hashCode = (hashCode * 397) ^ this.HasLastGameEnded.GetHashCode();
            hashCode = (hashCode * 397) ^ (this.ApiSeason != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(this.ApiSeason) : 0);
            hashCode = (hashCode * 397) ^ (this.ApiWeek != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(this.ApiWeek) : 0);
            return hashCode;
        }
    }
}
using Cb.Libraries.Enums;
using FantasyData.Api.Client;
using FantasyData.Api.Client.Model.NBA;

var client = new  NBAv3PlayByPlayClient("e80d97147bc840bb9138e07d112bfb35", new HttpClient());

var times = await client.GetPlayByPlayAsync(18008);

var gameStates = times.Plays.OrderBy(s => s.Sequence).SelectMany(s => s.AsGameStateStat());

Console.ReadLine();




Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();

public static class GameStateStatExtension
{
    public static IEnumerable<Cb.Models.CherryBet.GameState> AsGameStateStat(this Play play)
    {
        // Checking if the sub on is missing
        // if (play.PlayerID.HasValue)
        // {
        //     // Checking if that player is on the bench
        //     List<int> onBenchPlayers = cache.Get<List<int>>($"FixtureLineUp{fixture.FixtureId}");
        //     if (onBenchPlayers != null && onBenchPlayers.Contains(play.PlayerID.Value))
        //     {
        //         gameStateList.Add(PopulateMissingSubstitution(fixture, play.PlayerID.Value, play, play.Team,
        //             ref errorReportItems, PlayerOnOffEventType.SubOn));
        //         onBenchPlayers.Remove(play.PlayerID.Value);
        //         cache.Add($"FixtureLineUp{fixture.FixtureId}", onBenchPlayers);
        //     }
        // }

        switch (play.Type)
        {
            case "None":
                //gameStateList.Add(null);
                break;
            case "Period":
                yield return play.PopulatePeriod();
                break;
            case "Timeout":
                //gameStateList.Add(PopulateTimeout(fixture, play));
                break;
            case "JumpBall":
                //gameStateList.Add(PopulateJumpBall(fixture, play));
                break;
            case "FieldGoalMade":
                // Populate points
                if (play.AssistedByPlayerID.HasValue && play.AssistedByPlayerID.Value > 0)
                {
                    gameStateList.Add(PopulateAssist(fixture, play, ref errorReportItems));
                }

                gameStateList.Add(PopulatePoints(fixture, play, ref errorReportItems));
                //gameStateList.Add(PopulateFieldGoalMade(fixture, play, ref errorReportItems));
                break;
            case "FieldGoalMissed":
                if (play.AssistedByPlayerID.HasValue && play.AssistedByPlayerID.Value > 0)
                {
                    gameStateList.Add(PopulateAssist(fixture, play, ref errorReportItems));
                }

                if (play.BlockedByPlayerID.HasValue && play.BlockedByPlayerID.Value > 0)
                {
                    gameStateList.Add(PopulateBlock(fixture, play, ref errorReportItems));
                }

                //gameStateList.Add(PopulateFieldGoalMissed(fixture, play, ref errorReportItems));
                break;
            case "FreeThrowMade":
                // Populate points
                if (play.AssistedByPlayerID.HasValue && play.AssistedByPlayerID.Value > 0)
                {
                    gameStateList.Add(PopulateAssist(fixture, play, ref errorReportItems));
                }

                if (play.BlockedByPlayerID.HasValue && play.BlockedByPlayerID.Value > 0)
                {
                    gameStateList.Add(PopulateBlock(fixture, play, ref errorReportItems));
                }

                gameStateList.Add(PopulatePoints(fixture, play, ref errorReportItems));
                //gameStateList.Add(PopulateFreeThrowMade(fixture, play, ref errorReportItems));
                break;
            case "FreeThrowMissed":
                if (play.BlockedByPlayerID.HasValue && play.BlockedByPlayerID.Value > 0)
                {
                    gameStateList.Add(PopulateBlock(fixture, play, ref errorReportItems));
                }

                //gameStateList.Add(PopulateFreeThrowMissed(fixture, play, ref errorReportItems));
                break;
            case "Rebound":
                gameStateList.Add(PopulateRebound(fixture, play, ref errorReportItems));
                break;
            case "Steal":
                gameStateList.Add(PopulateSteal(fixture, play, ref errorReportItems));
                break;
            case "Turnover":
                //gameStateList.Add(PopulateTurnover(fixture, play, ref errorReportItems));
                break;
            case "Foul":
                //gameStateList.Add(PopulateFoul(fixture, play, ref errorReportItems));
                break;
            case "PersonalFoul":
                //gameStateList.Add(PopulatePersonalFoul(fixture, play, ref errorReportItems));
                break;
            case "ShootingFoul":
                //gameStateList.Add(PopulateShootingFoul(fixture, play, ref errorReportItems));
                break;
            case "OffensiveFoul":
                //gameStateList.Add(PopulateOffensiveFoul(fixture, play, ref errorReportItems));
                break;
            case "LooseBallFoul":
                //gameStateList.Add(PopulateLooseBallFoul(fixture, play, ref errorReportItems));
                break;
            case "TechnicalFoul":
                //gameStateList.Add(PopulateTechnicalFoul(fixture, play, ref errorReportItems));
                break;
            case "FlagrantFoul":
                //gameStateList.Add(PopulateFlagrantFoul(fixture, play, ref errorReportItems));
                break;
            case "Traveling":
                //gameStateList.Add(PopulateTraveling(fixture, play, ref errorReportItems));
                break;
            case "Palming":
                //gameStateList.Add(PopulatePalming(fixture, play, ref errorReportItems));
                break;
            case "Goaltending":
                //gameStateList.Add(PopulateGoaltending(fixture, play, ref errorReportItems));
                break;
            case "KickedBall":
                //gameStateList.Add(PopulateKickedBall(fixture, play, ref errorReportItems));
                break;
            case "LaneViolation":
                //gameStateList.Add(PopulateLaneViolation(fixture, play, ref errorReportItems));
                break;
            case "DelayOfGame":
                //gameStateList.Add(PopulateDelayOfGame(fixture, play, ref errorReportItems));
                break;
            case "Substitution":
                if (play.SubstituteOutPlayerID.HasValue)
                {
                    gameStateList.Add(PopulateSubstitution(fixture, play, ref errorReportItems,
                        PlayerOnOffEventType.SubOff));
                }

                if (play.SubstituteInPlayerID.HasValue)
                {
                    gameStateList.Add(PopulateSubstitution(fixture, play, ref errorReportItems,
                        PlayerOnOffEventType.SubOn));
                }

                break;
            default:
                break;
        }
    }

    private static Cb.Models.CherryBet.GameState PopulatePeriod(this Play play)
    {
        // Gamestate object
        return PopulateGameStateItem(play);
    }

    private static Cb.Models.CherryBet.GameState PopulateGameStateItem(this Play play)
    {
        var gameState = new Cb.Models.CherryBet.GameState();
        //gameState.FixtureId = fixture.FixtureId;
        //gameState.LeagueId = fixture.League.LeagueId;
        gameState.Source = GameStateSource.SportsDataIO;
        gameState.Sport = Sport.Basketball;
        gameState.Basketball = new Cb.Models.CherryBet.BasketballGameState();
        gameState.Period = GetPeriod(play.QuarterName);
        gameState.Phase = play.GetPhase();
        gameState.Minute = play.TimeRemainingMinutes.GetValueOrDefault(0);
        gameState.Second = play.TimeRemainingSeconds.GetValueOrDefault(0);
        gameState.TimeStamp = DateTime.Now;
        return gameState;
    }

    private static Period GetPeriod(string apiPeriod)
    {
        return apiPeriod switch
        {
            "1" => Period.FirstQuarter,
            "2" => Period.SecondQuarter,
            "3" => Period.ThirdQuarter,
            "4" => Period.FourthQuarter,
            "OT" => Period.OverTime1,
            "OT1" => Period.OverTime1,
            "OT2" => Period.OverTime2,
            "OT3" => Period.OverTime3,
            "OT4" => Period.OverTime4,
            "OT5" => Period.OverTime5,
            _ => Period.None
        };
    }

    private static Phase GetPhase(this Play play)
    {
        return play.QuarterName switch
        {
            "0" => Phase.PreLineUp,
            "1" => Phase.InPlay,
            "2" => Phase.InPlay,
            "3" => Phase.InPlay,
            "4" => Phase.InPlay,
            "5" => Phase.InPlay,
            "6" => Phase.InPlay,
            "7" => Phase.InPlay,
            "8" => Phase.InPlay,
            "9" => Phase.InPlay,
            _ => Phase.PreMatch
        };
    }
}
using FantasyData.Api.Client;




// Connect to client and get data
var client = new  NFLv3ScoresClient("<api_key_goes_here>");
var scores = await client.GetScoresAsync("2020POST");

// Write data to console
foreach (var score in scores)
{
    Console.WriteLine($"{score.AwayTeam} @ {score.HomeTeam}");
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
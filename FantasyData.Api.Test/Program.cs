using FantasyData.Api.Client;

var client = new  NBAv3PlayByPlayClient("your-key-goes-here", new HttpClient());

var times = await client.GetBoxScoresDeltaRawAsync("2021-DEC-25", "2");
foreach (var time in times.Item1)
{
   Console.WriteLine(times.Item2);
}

Console.ReadLine();




Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
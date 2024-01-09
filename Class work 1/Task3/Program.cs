var player = new Player();
player.Name = "Ronaldo";
player.Number = 7;
player.Position = "CF";
player.Team = "Real Madrid";

System.Console.WriteLine("----------------------------------");
player.ScoreGoal();
player.AssistGoal("Marcelo");

System.Console.WriteLine(player.GetInfo());
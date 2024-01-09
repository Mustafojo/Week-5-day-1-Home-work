public class Player
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;
    public void ScoreGoal()
    {
        System.Console.WriteLine($"{Name} ki bo rakami {Number} bozi mekunad bo usuli chere sebya gol zad");
    }
    public void AssistGoal(string playerName)
    {
        System.Console.WriteLine($"{playerName} az bayni se nafar ba {Name} pass dod va {Name} boshad az bayni poyhoi darvozabon gol zad");
    }
    public string GetInfo()
    {
        return $"Name : {Name}\nNumber: {Number}\nPosition: {Position}\nTeam: {Team}";
    }
}
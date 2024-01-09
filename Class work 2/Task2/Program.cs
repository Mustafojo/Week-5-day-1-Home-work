var obw = new Rectangle();
obw.Height = 100;
obw.Width = 150;


System.Console.WriteLine($"{obw.GetArea()}");
public class Rectangle
{
    public int Width;
    public int Height;
    

    public string GetArea()
    {
        return $"{Width * Height}";
    }
    
}
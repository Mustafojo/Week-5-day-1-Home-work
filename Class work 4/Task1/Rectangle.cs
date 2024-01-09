public class Rectangle
{
    public int Width;
    public int Height;
    public string Color;
    public int GetArea() 
    {
        return Width * Height * 2;
    }
    public int GetPerimeter()
    {
        return 2 * (Width * Height);
    }

}
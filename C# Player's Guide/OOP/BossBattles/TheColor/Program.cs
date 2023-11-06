Console.Title = "The Color";

Color myColor1 = new Color(123, 255, 13);
Color myColor2 = Color.Black;

Console.WriteLine($"R: {myColor1.R} G: {myColor1.G} B: {myColor1.B}");
Console.WriteLine($"R: {myColor2.R} G: {myColor2.G} B: {myColor2.B}");
class Color
{
    public byte R { get; }
    public byte G { get; }
    public byte B { get; }

    public Color(byte red, byte green, byte blue)
    {
        R = red; 
        G = green; 
        B = blue;
    }

    public static Color White { get;  } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Purple { get; } = new Color(128, 128, 0);
}

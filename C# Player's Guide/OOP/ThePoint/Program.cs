Console.Title = "The Point";

Point myPoint = new Point(2, 3);
Point myPoint2 = new Point(-4, 0);
Point originPoint = new Point();

Console.WriteLine($"({myPoint.X}, {myPoint.Y})");
Console.WriteLine($"({myPoint2.X}, {myPoint2.Y})");
Console.WriteLine($"({originPoint.X}, {originPoint.Y})");
class Point
{
    public int X { get; }
    public int Y { get; }

    public Point()
    {
        X = 0;
        Y = 0;
    }
    public Point(int xAxis, int yAxis)
    {
        X = xAxis;
        Y = yAxis;
    }
}
// Answer this question: Are your X and Y properties immutable? Why did you choose what you did
// Mine is immutable, because i dont want my things changing through the code at this moment in my experience >.<'
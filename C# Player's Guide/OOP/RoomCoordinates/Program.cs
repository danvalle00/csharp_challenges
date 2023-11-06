Console.Title = "Room Coordinates";

Coordinate c0 = new Coordinate(0, 0);
Coordinate c1 = new Coordinate(1, 1);
Coordinate c2 = new Coordinate(2, 1);
Coordinate c3 = new Coordinate(6, 5);

Console.WriteLine(c0.IsAdjacent(c1)); // false
Console.WriteLine(c1.IsAdjacent(c3));
Console.WriteLine(c2.IsAdjacent(c1));
public struct Coordinate
{
    int Row { get; }
    int Col { get; }
    
    public Coordinate(int row, int col)
    {
        Row = row;
        Col = col;
    }
    public bool IsAdjacent(Coordinate givenCoordinate)
    {
        int rowDelta = Math.Abs(givenCoordinate.Row - Row);
        int colDelta = Math.Abs(givenCoordinate.Col - Col);
        
        // Horizontal Delta               || Vertical Delta        
        if(rowDelta <= 1 && colDelta == 0 || colDelta <= 1 && rowDelta == 0)
        {
            return true;
        }
        return false;
    }
}
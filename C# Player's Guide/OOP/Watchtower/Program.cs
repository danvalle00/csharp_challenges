Console.Title = "The Watchtower of Consolas";
Console.Write("Whats the X coordinate of the enemy? ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Whats the Y coordinate of the enemy? ");
int yCoord = Convert.ToInt32(Console.ReadLine());

if (xCoord > 0)
{
    if (yCoord > 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The enemy is to the Northeast!");
    }
    else if (yCoord < 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The enemy is to the Southeast!");
    }
    else // y == 0
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The enemy is to the East!");
    }
}
else if (xCoord < 0)
{
    if (yCoord > 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The enemy is to the Northwest!");
    }
    else if (yCoord < 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The enemy is to the Southwest!");
    }
    else // y == 0
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The enemy is to the West!");
    }
}
else 
{
    if(yCoord > 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The enemy is to the North!");
    }
    else if (yCoord < 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The enemy is to the South");
    }
    else // (x, y) == (0, 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The enemy is here!!");
        Console.Beep();
    }

}


    
       

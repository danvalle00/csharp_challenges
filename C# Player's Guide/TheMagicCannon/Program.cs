Console.Title = "The Magic Cannon";

for (int turn = 1; turn < 101;  turn++)
{
    Console.Write($"{turn}: ");
    if(turn % 3 == 0 && turn % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Eletric and Fire!");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    else if (turn % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    else if (turn % 5 == 0)
    {
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("Eletric");
        Console.ForegroundColor = ConsoleColor.White;
        continue;
    }
    else
    {
        Console.WriteLine("Normal");
    }
}
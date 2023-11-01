Console.Title = "Defense of Consolas";

Console.Write("Target Row: ");
 int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column: ");

int targetColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Attack in ({targetRow}, {targetColumn})");

Console.WriteLine("Deploy defenses to:");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"({targetRow + 1}, {targetColumn})");
Console.WriteLine($"({targetRow}, {targetColumn + 1})");
Console.WriteLine($"({targetRow - 1}, {targetColumn})");
Console.WriteLine($"({targetRow}, {targetColumn - 1})"); 
Console.Beep();

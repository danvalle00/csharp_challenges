Console.Title = "Safer Number Crunching";

Console.Write("Enter a integer, double or an boolean value: ");
string? userInput = Console.ReadLine();
while (true)
{ 
    if (int.TryParse(userInput, out int value))
    {
        Console.WriteLine($"You wrote the value of: {value}! ");
        break;
    }
    else if (bool.TryParse(userInput, out bool booleanValue))
    {
        Console.WriteLine($"You wrote the boolean value of: {booleanValue}!");
        break;
    }
    else if (double.TryParse(userInput, out double doubleValue))
    {
        Console.WriteLine($"Thats a double value of: {doubleValue}! ");
        break;
    }
    else
    {
        Console.WriteLine("That's not what i asked! ");
        continue;
    }
}
Console.Title = "The Sieve";

Console.WriteLine("Which filter do you want do use?");
Console.WriteLine("1 -> Even");
Console.WriteLine("2 -> Positive");
Console.WriteLine("3 -> Multiple of Ten");

int choice = Convert.ToInt32(Console.ReadLine());

Sieve sieve = choice switch
{
    1 => new Sieve(IsEven),
    2 => new Sieve(IsPositive),
    3 => new Sieve(IsMultipleOfTen),
};
Console.Clear();
while (true)
{
    Console.WriteLine("Enter a Number:");
    int number = Convert.ToInt32(Console.ReadLine());
    string goodNumber = sieve.IsGood(number) ? "Good Number" : "Bad Number";
    Console.WriteLine($"This number is a {goodNumber}!");
}

bool IsEven(int number) => number % 2 == 0;
bool IsPositive(int number) => number > 0;
bool IsMultipleOfTen(int number) => number % 10 == 0;

public class Sieve
{
    private Func<int, bool> filterDecision;
    
    public Sieve(Func<int, bool> filter)
    {
        filterDecision = filter;
    }
    
    public bool IsGood(int number)
    {
        return filterDecision(number);
    }
}

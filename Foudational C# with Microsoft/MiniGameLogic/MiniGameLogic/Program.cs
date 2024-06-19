Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;


Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Triples!!! +6 Points");
        total += 6;
    }
    else
    {
        Console.WriteLine("Doubles!! +2 Points");
        total += 2;
    }

    Console.WriteLine($"Dice roll with the bonus: {roll1} + {roll2} + {roll3} = {total}");
}


if (total >= 16)
{
    Console.WriteLine("You win a new Car");
}
else if (total >= 10)
{
    Console.WriteLine("You win a Laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two");
}
else
{
    Console.WriteLine("You Lose! ;p");
}



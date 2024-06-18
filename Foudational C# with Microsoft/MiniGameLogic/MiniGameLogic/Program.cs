Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("Doubles!! +2 Points");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("Triples!!! +6 Points");
    total += 6;
}
if (total >= 15)
{
    Console.WriteLine("You Win!");
}

if (total < 15)
{
    Console.WriteLine("You Lose");
}


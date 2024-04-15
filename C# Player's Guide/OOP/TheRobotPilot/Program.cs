Console.Title = "The Robot Pilot";
int manticoreHp, currentManticoreHp;
manticoreHp = currentManticoreHp = 10;
int consolasCityHp, currentConsolasCityHp;
consolasCityHp = currentConsolasCityHp = 15;

int roundCounter = 1;
// Player 1 Turn
//int manticoreDistance = AskManticoreDistanceFromCity();
Random randDistance = new Random();
int manticoreDistance = randDistance.Next(100);

// Player 2 Turn => Main Game Loop
Console.WriteLine("Player 2, it is your turn");
while (currentConsolasCityHp > 0 && currentManticoreHp > 0)
{
    DisplayStatus();
    int damageNumber = CannonDamageCalculator(roundCounter);
    Console.WriteLine($"The cannon is expected to deal {damageNumber} damage this round");

    Console.Write("Enter desired cannon range: ");
    int cannonDesiredRange = Convert.ToInt32(Console.ReadLine());
    CannonManticoreHit(cannonDesiredRange, damageNumber);

    if (currentManticoreHp > 0)
    {
        currentConsolasCityHp--;
    }
    EndgameHandler(currentManticoreHp, currentConsolasCityHp);
    roundCounter++;
}

int AskManticoreDistanceFromCity()
{
    Console.Write("Player 1, How far away from the city do you want to station the Manticore? ");
    int manticoreDistance = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    return manticoreDistance;
}

void DisplayStatus()
{
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {roundCounter} City HP: {currentConsolasCityHp}/{consolasCityHp} Manticore HP: {currentManticoreHp}/{manticoreHp} ");
}

void CannonManticoreHit(int cannonRange, int damageNumber)
{
    if (cannonRange < manticoreDistance)
    {
        Console.WriteLine("That round FELL SHORT of the target");
    }
    else if (cannonRange > manticoreDistance)
    {
        Console.WriteLine("That round OVERSHOT the target");
    }
    else
    {
        Console.WriteLine("That round was a DIRECT HIT");
        currentManticoreHp -= damageNumber;
    }
}

int CannonDamageCalculator(int roundCounter)
{
    int cannonDamage;
    if (roundCounter % 3 == 0 && roundCounter % 5 == 0)
    {
        cannonDamage = 10;
    }
    else if (roundCounter % 3 == 0 || roundCounter % 5 == 0)
    {
        cannonDamage = 3;
    }
    else
    {
        cannonDamage = 1;
    }
    return cannonDamage;
}

void EndgameHandler(int currentManticoreHp, int currentCityHp)
{
    if (currentManticoreHp <= 0 && currentCityHp > 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else if (currentCityHp <= 0 && currentManticoreHp > 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city of Consolas has been destroyed! The Manticore has been victorious!");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}

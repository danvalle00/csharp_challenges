Console.Title = "Simula's Test";

ChestState chestState = ChestState.Locked; 

while(true)
{
    Console.Write($"The chest is {chestState}. What do you want to do? ");
    string chestAction = Console.ReadLine();

    // Possible refactoring is changing to switch case.
    if (chestAction == "unlock" && chestState == ChestState.Locked)
    {
        chestState = ChestState.Closed;
        continue;
    }
    else if (chestAction == "open" && chestState == ChestState.Closed)
    {
        chestState = ChestState.Open;
        continue;
    }
    else if (chestAction == "close" && chestState == ChestState.Open)
    {
        chestState = ChestState.Closed;
        continue;
    }
    else if (chestAction == "lock" && chestState == ChestState.Closed)
    {
        chestState = ChestState.Locked;
        continue;
    }
    else
    {
        Console.WriteLine("Can't do this action, try another thing.");
        continue;
    }
};

enum ChestState {Open, Closed, Locked};

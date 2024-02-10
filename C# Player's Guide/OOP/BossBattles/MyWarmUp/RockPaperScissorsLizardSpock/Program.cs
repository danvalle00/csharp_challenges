Console.Title = "Rock Paper Scissors Lizard Spock";

new JokenpoGame().Run();

class JokenpoGame
{
    ConsoleRenderer consoleRender = new ConsoleRenderer();
    Player player1 = new Player();
    Player player2 = new Player();
    int player1Choice, player2Choice;

    public void Run()
    {
        PlayerNames();
        PlayerChoices();
        Console.WriteLine(player1.Name + player1.PlayerWeapons);
        Console.WriteLine(player2.Name + player2.PlayerWeapons);
    }
    
    public void PlayerNames()
    {
        consoleRender.InitialGameText();
        Console.Write("Player 1 Name: ");
        player1.Name = Console.ReadLine();
        Console.Write("Player 2 Name: ");
        player2.Name = Console.ReadLine();
        Console.Clear();
    }


    public void PlayerChoices()
    {
        Console.WriteLine($"{player1.Name} make your weapon choice: ");
        consoleRender.ChooseWeaponsRender();
        player1Choice = Convert.ToInt32(Console.ReadLine());
        player1.PlayerWeapons = ChoiceConverter(player1Choice);
        Console.Clear();

        Console.WriteLine($"{player2.Name} make your weapon choice: ");
        consoleRender.ChooseWeaponsRender();
        player2Choice = Convert.ToInt32(Console.ReadLine());
        player2.PlayerWeapons = ChoiceConverter(player2Choice);
        Console.Clear();
    }

    public Weapons ChoiceConverter(int numberChoice)
    {
        Weapons weaponChoice = numberChoice switch
        {
            1 => Weapons.Rock,
            2 => Weapons.Paper,
            3 => Weapons.Scissors,
            4 => Weapons.Lizard,
            5 => Weapons.Spock,
        };
        return weaponChoice;
    }
}
class Player
{
    public Weapons PlayerWeapons { get; set; }
    public string Name { get; set; }
}   
 
class LogicManager
{

}

class ConsoleRenderer
{
    public void InitialGameText()
    {
        Console.WriteLine("Welcome to Rock,Paper,Scissors,Lizard,Spock!!");
        Console.WriteLine("I'm your host, The Console.");
        Console.WriteLine("Can I have your Names? ");
    }
    public void ChooseWeaponsRender()
    {
        Console.WriteLine($"1 -> {Weapons.Rock}");
        Console.WriteLine($"2 -> {Weapons.Paper}");
        Console.WriteLine($"3 -> {Weapons.Scissors}");
        Console.WriteLine($"4 -> {Weapons.Lizard}");
        Console.WriteLine($"5 -> {Weapons.Spock}");
    }

}


enum Weapons { Rock, Paper, Scissors, Lizard, Spock};

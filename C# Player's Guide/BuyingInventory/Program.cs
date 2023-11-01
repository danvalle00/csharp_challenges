Console.Title = "Buying Inventory";
Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");    
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");    
Console.WriteLine("7 - Food Suplies");
Console.Write("What item do you want to see the price of? ");
int itemChoice = Convert.ToInt32(Console.ReadLine());

string itemName = itemChoice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Suplies",
};
    
int itemPrice = itemName switch
{
    "Rope" => 10,
    "Torches" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Suplies" => 1
};

Console.Write($"{itemName} costs {itemPrice} gold");    

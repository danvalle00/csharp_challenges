Console.Title = "Packing Inventory";

Pack myPack = new Pack(20, 20, 30); 
while(true)
{
    Console.WriteLine("\n#--------------------------------#");
    Console.WriteLine($"Pack is currently with {myPack.CurrentItens}/{myPack.PackTotalItens} itens");
    Console.WriteLine($"Weight: {myPack.CurrentWeight}/{myPack.PackTotalWeight} weight");
    Console.WriteLine($"Volume: {myPack.CurrentVolume}/{myPack.PackTotalVolume} volume");
    Console.WriteLine("#--------------------------------#\n");

    Console.WriteLine("Which item do you want to put on the pack? ");
    Console.WriteLine("1 => Arrow");
    Console.WriteLine("2 => Bow");
    Console.WriteLine("3 => Rope");
    Console.WriteLine("4 => Water");
    Console.WriteLine("5 => Food");
    Console.WriteLine("6 => Sword");
    int itemChoice = Convert.ToInt32(Console.ReadLine());
    InventoryItem newItem = itemChoice switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new FoodRation(),
        6 => new Sword(),
    };
    
    if(!myPack.AddItem(newItem))
    {
        Console.WriteLine("Couldn't add this item to the pack!");
    }
}
        
    

class Pack
{
    public int PackTotalItens { get; }
    public float PackTotalVolume { get; }
    public float PackTotalWeight { get; }
    public InventoryItem[] Inventory { get; }

    public int CurrentItens { get; private set; }
    public float CurrentVolume { get; private set; }
    public float CurrentWeight { get; private set; }

    public Pack(int totalItens, float totalWeight, float totalVolume)
    {
        PackTotalItens = totalItens;
        PackTotalVolume = totalVolume;
        PackTotalWeight = totalWeight;
        Inventory = new InventoryItem[PackTotalItens];
    }
    public bool AddItem(InventoryItem item)
    {
        if(CurrentItens < PackTotalItens && (CurrentVolume + item.ItemVolume) < PackTotalVolume && (CurrentWeight + item.ItemWeight) < PackTotalWeight)
        {
            Inventory[CurrentItens] = item;
            CurrentItens++;
            CurrentVolume += item.ItemVolume;
            CurrentWeight += item.ItemWeight;
            return true;
        }
        else
        {
            return false;
        }
    }
}


class InventoryItem
{
    public float ItemWeight { get; } 
    public float ItemVolume { get; }
    public InventoryItem(float itemWeight, float itemVolume)
    {
        ItemWeight = itemWeight;
        ItemVolume = itemVolume;
    }
}

class Arrow : InventoryItem
{
    public Arrow() : base(0.1f, 0.05f)
    {
    }
}

class Bow : InventoryItem
{
    public Bow() : base(1.0f, 4.0f)
    {
    }
}

class Rope : InventoryItem
{
    public Rope() : base (1.0f, 1.5f)
    {
    }
}

class Water : InventoryItem
{
    public Water() : base (2.0f, 3.0f)
    {
    }
}

class FoodRation : InventoryItem
{
    public FoodRation() : base(1.0f, 0.5f)
    {
    }
}

class Sword : InventoryItem
{
    public Sword() : base (5.0f, 3.0f)
    {
    }
}

/* int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (var item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin}: {item} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory"); */

string[] itemsId = { "B123", "C234", "A345", "C15", "B177", "G3003", "G235", "B179" };

foreach (string fraudulentItem in itemsId)
{
    if (fraudulentItem.StartsWith("B"))
    {
        Console.WriteLine(fraudulentItem);
    }
}

Console.Title = "Colored Items";

ColoredItem<Sword> blueSword = new ColoredItem<Sword>(ConsoleColor.Blue, new Sword());
ColoredItem<Axe> greenAxe = new ColoredItem<Axe>(ConsoleColor.Green, new Axe());
ColoredItem<Bow> redBow = new ColoredItem<Bow>(ConsoleColor.Red, new Bow());

blueSword.Display();
greenAxe.Display();
redBow.Display();

public class ColoredItem<T>
{
    public ConsoleColor Color { get; }
    public T ItemType { get; }

    public ColoredItem(ConsoleColor color, T item)
    {
        Color = color;
        ItemType = item;
    }
    
    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(ItemType);
    }
}
public class Sword
{

}
public class Bow
{

}

public class Axe
{

}



Console.Title = "Charberry Trees";
CharberryTree tree = new();
Notifier treeNotifier = new(tree);
Harvester treeHarvester = new(tree);
// fazer amanha (revisar delegates e events!!!!!!!! 20/02/2024)
while (true)
{
    tree.MaybeGrow();
}


public class CharberryTree
{
    public event Action? Ripened;

    
    private Random _random = new Random();
    public bool Ripe { get; set; }

    public void MaybeGrow()
    {
        if (_random.NextDouble() < 0.00000001 && !Ripe)
        {
            Ripe = true;
            Ripened?.Invoke();
        }
    }
}

public class Notifier
{
    public Notifier(CharberryTree tree)
    {
        tree.Ripened += OnTreeRipened;
    }

    private void OnTreeRipened()
    {
        Console.WriteLine("A charberry fruit has ripened");
    }
}

public class Harvester
{
    private CharberryTree _tree;
    public Harvester(CharberryTree tree)
    {
        tree.Ripened += OnTreeRipened;
        _tree = tree;
    }

    private void OnTreeRipened()
    {
        _tree.Ripe = false;
    }

}
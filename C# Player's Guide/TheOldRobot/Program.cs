Console.Title = "The Old Robot";

Robot robot = new Robot();
for (int i = 0; i < robot.Commands.Length; i++)
{
    Console.WriteLine("Which command the robot must do?");
    Console.WriteLine("Available Commands: On, Off, North, South, West, East");
    string? robotCommand = Console.ReadLine();
    RobotCommand newCommand = robotCommand switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "west" => new WestCommand(),
        "east" => new EastCommand(),
    };
    robot.Commands[i] = newCommand;
}
robot.Run();

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public abstract class RobotCommand
{
    public abstract void Run(Robot robot);
}

class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;   
    }
}

class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
            robot.Y++;
        }
    }
}

class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if(robot.IsPowered)
        {
            robot.Y--;
        }
    }
}

class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (robot.IsPowered) 
        {
            robot.X--;
        }
    }
}

class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if(robot.IsPowered)
        {
            robot.X++;            
        }
    }
}
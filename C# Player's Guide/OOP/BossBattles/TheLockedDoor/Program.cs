Console.Title = "The Locked Door";

Console.Write("Please, give an initial numeric passcode for the door. ");
int userPasscode = Convert.ToInt32(Console.ReadLine()); 
Door myDoor = new Door(userPasscode);

while (true)
{
    Console.WriteLine($"The door is currently {myDoor.DoorState}. What do you want to do? (open, close, unlock, lock, change passcode)");
    string? choice = Console.ReadLine();
    switch (choice)
    {
        case "open":
            myDoor.Open(); break;
        case "close":
            myDoor.Close(); break;
        case "unlock":
            int givenPasscode = GetInt("What is the current passcode?");
            myDoor.Unlock(givenPasscode); break;
        case "lock":
            myDoor.Lock(); break;
        case "change passcode":
            int initialPasscode = GetInt("What is the current passcode?");
            int newPasscode = GetInt("What do you change it to?");
            myDoor.ChangePasscode(initialPasscode, newPasscode); break;
    }
}

int GetInt(string givenText)
{
    Console.Write(givenText + " ");
    return Convert.ToInt32(Console.ReadLine());
}

class Door
{
    public int DoorPasscode { get; private set; }
    public State DoorState { get; private set; }

    public Door(int doorPasscode)
    {
        DoorPasscode = doorPasscode;
        DoorState = State.Locked;
    }

    public void ChangePasscode(int actualPasscode, int newPasscode)
    {
        if (DoorPasscode == actualPasscode) DoorPasscode = newPasscode;
        else Console.WriteLine("Wrong data was provided, try again.");
    }

    public void Unlock(int givenPasscode)
    {
        if (DoorPasscode == givenPasscode && DoorState == State.Locked) DoorState = State.Unlocked;
        else Console.WriteLine("Can't unlock the door right now");
    }
    public void Open()
    {
        if (DoorState == State.Closed || DoorState == State.Unlocked) DoorState = State.Opened;
        else Console.WriteLine("Can't open the door right now");
    }
    public void Close()
    {
        if (DoorState == State.Opened) DoorState = State.Closed;
        else Console.WriteLine("Can't close the door right now");
    }
    public void Lock() 
    {
        if (DoorState == State.Unlocked || DoorState == State.Closed) DoorState = State.Locked;
        else Console.WriteLine("Can't lock the door right now.");
    }
}

enum State {Opened, Closed, Locked, Unlocked}
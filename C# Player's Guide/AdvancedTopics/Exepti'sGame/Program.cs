Console.Title = "Exepti's Game";

Random randomCookie = new Random();
List<int> numbersChosen = new List<int>();
int randomCookieNumber = randomCookie.Next(10); // random numbers between 0 and 9.

while (true)
{ 
    Console.Write("Choose a number between 0 and 9: ");
    int inputChoice = Convert.ToInt32(Console.ReadLine());
    try
    {
        if (inputChoice == randomCookieNumber)
        {
            throw new Exception();
        }
        if (numbersChosen.Contains(inputChoice))
        {
            Console.WriteLine($"This number was already chosen: {inputChoice}");
            continue;
        }
        numbersChosen.Add(inputChoice);
    }
    catch (Exception)
    {
        Console.WriteLine($"Cookie: {randomCookieNumber} == userChoice: {inputChoice}");
        break;
    }
}
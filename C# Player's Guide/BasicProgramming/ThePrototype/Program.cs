Console.Title = "The Prototype";

int numberToGuess;
do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    numberToGuess = Convert.ToInt32(Console.ReadLine());
}
while (numberToGuess < 0 || numberToGuess > 100);

Console.Clear();

Console.Write("User 2, guess the number: ");
int guessedNumber = Convert.ToInt32(Console.ReadLine());
do
{
    if (guessedNumber > numberToGuess)
    {
        Console.WriteLine($"{guessedNumber} is to high.");
    }
    else if (guessedNumber < numberToGuess)
    {
        Console.WriteLine($"{guessedNumber} is to low.");
    }
    else 
    {
        Console.WriteLine("You guessed the number!");
        break;
    }
    Console.Write("What's your next guess? ");
    guessedNumber = Convert.ToInt32(Console.ReadLine());
}
while (guessedNumber != numberToGuess);
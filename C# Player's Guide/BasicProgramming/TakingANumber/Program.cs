int resultAsk = AskForNumber("What is the airspeed velocity of an unladen swallow? ");
Console.WriteLine(resultAsk);

int resultAskInRange = AskForNumberInRange("Guess the number in range ", 10, 100);
Console.WriteLine(resultAskInRange);
int AskForNumber(string askText)
{
    Console.Write(askText);
    int answerNumber = Convert.ToInt32(Console.ReadLine());
    return answerNumber;
}

int AskForNumberInRange(string askText, int minNumber, int maxNumber)
{
    int answerNumber;
    do
    {
        Console.Write(askText);
        answerNumber = Convert.ToInt32(Console.ReadLine());
    }
    while (answerNumber < minNumber || answerNumber > maxNumber);
    return answerNumber;
}


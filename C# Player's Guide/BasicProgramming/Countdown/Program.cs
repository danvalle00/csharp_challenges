Countdown(15);
void Countdown(int numberToCountdowm)
{
    Console.WriteLine(numberToCountdowm);
    if (numberToCountdowm == 1)
    {
        return;
    }
    Countdown(numberToCountdowm - 1);
}
        
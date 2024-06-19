Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


if (daysUntilExpiration <= 0)
{
    Console.WriteLine("Your sub has expired ;c");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your sub expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your sub will expire in {daysUntilExpiration} days");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your sub will expire soon! Renew!");
}


if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

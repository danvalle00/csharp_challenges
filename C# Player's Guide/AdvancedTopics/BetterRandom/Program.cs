Console.Title = "Better Random";

public static class RandomExtensions
{
    public static double NextDoubleExtended(this Random random, double max) 
    {

        return random.NextDouble() * max;
    }

    public static string RandomStrings(this Random random, params string[] stringList)
    {
        return stringList[random.Next(stringList.Length)];
    }

    public static bool CoinFlipExtended(this Random random, double probability = 0.5)
    {
        return (random.NextDouble() < probability);
    }

}

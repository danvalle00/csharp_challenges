int[] numberArray = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};
int currentSmallest = int.MaxValue;
int totalSum = 0;
float averageNumber;
foreach (int number in numberArray)
{
    if(number < currentSmallest)
    {
        currentSmallest = number;
    }
}
Console.WriteLine(currentSmallest);

foreach (int number in numberArray)
{
    totalSum += number;
}
averageNumber = (float) totalSum / numberArray.Length;
Console.WriteLine(averageNumber) ;
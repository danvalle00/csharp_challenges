Console.Title = "Replicator of D'To";

int[] firstArray = new int[5];
int[] secondArray = new int[5];

for  (int i = 0; i < firstArray.Length; i++)
{
    Console.Write($"Enter a number for index {i}: ");
    firstArray[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0;i < secondArray.Length;i++)
{
    secondArray[i] = firstArray[i];
}

Console.WriteLine("Arrays Content: ");
for (int i = 0; firstArray.Length > i; i++)
{
    Console.WriteLine($"index: {i}, first array value: {firstArray[i]}, second array value: {secondArray[i]}");
}

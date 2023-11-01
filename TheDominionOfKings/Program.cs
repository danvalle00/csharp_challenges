Console.WriteLine("How many Provincies do you have?");
int provinciesCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many Duchies do you have?");
int duchiesCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many Estates do you have?");
int estatesCount = Convert.ToInt32(Console.ReadLine());

int totalPoints = (1 * estatesCount) + (3 * duchiesCount) + (6 * provinciesCount);
Console.Write("Total Points: " + totalPoints);
float baseSize, height, triangleArea;

Console.WriteLine("Input the triangle base size: ");
baseSize = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Now Input the triangle height: ");
height  = Convert.ToSingle(Console.ReadLine());

triangleArea = baseSize * height / 2;
Console.WriteLine("The area of the triangle is " + triangleArea);

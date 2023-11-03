Console.Title = "Simula's Soup";

Console.WriteLine("Choose the elements of the soup for Simula to make it!");
FoodTypes desiredType = PickFoodType();
FoodMainIngredient desiredIngredient = PickFoodMainIngredient();
FoodSeasoning desiredSeasoning = PickFoodSeasoning();

var desiredFoodCombination = (Type: desiredType, MainIngredient: desiredIngredient, Seasoning: desiredSeasoning);
Console.WriteLine($"Your desired food is a {desiredFoodCombination.Type} with {desiredFoodCombination.MainIngredient} as a main component and a {desiredFoodCombination.Seasoning} seasoning.");
Console.WriteLine("Hope you enjoy it :)");

FoodTypes PickFoodType()
{
    Console.WriteLine("Which variation of food do you like? ");
    Console.WriteLine($"1 -> {FoodTypes.Gumbo}");
    Console.WriteLine($"2 -> {FoodTypes.Soup}");
    Console.WriteLine($"3 -> {FoodTypes.Stew}");
    int numberChoice = Convert.ToInt32(Console.ReadLine());

    FoodTypes typeChoice = numberChoice switch
    {
        1 => typeChoice = FoodTypes.Gumbo,
        2 => typeChoice = FoodTypes.Soup,
        3 => typeChoice = FoodTypes.Stew,
    };
    return typeChoice;
}

FoodMainIngredient PickFoodMainIngredient()
{
    Console.WriteLine("Which Main Ingredient do you like? ");
    Console.WriteLine($"1 -> {FoodMainIngredient.Mushroom}");
    Console.WriteLine($"2 -> {FoodMainIngredient.Chicken}");
    Console.WriteLine($"3 -> {FoodMainIngredient.Carrot}");
    Console.WriteLine($"4 -> {FoodMainIngredient.Potato}");
    int numberChoice = Convert.ToInt32(Console.ReadLine());

    FoodMainIngredient ingredientChoice = numberChoice switch
    {
        1 => ingredientChoice = FoodMainIngredient.Mushroom,
        2 => ingredientChoice = FoodMainIngredient.Chicken,
        3 => ingredientChoice = FoodMainIngredient.Carrot,
        4 => ingredientChoice = FoodMainIngredient.Potato,
    };
    return ingredientChoice;
}

FoodSeasoning PickFoodSeasoning()
{
    Console.WriteLine("Which Seasoning do you like? ");
    Console.WriteLine($"1 -> {FoodSeasoning.Spicy}");
    Console.WriteLine($"2 -> {FoodSeasoning.Salty}");
    Console.WriteLine($"3 -> {FoodSeasoning.Sweet}");
    int numberChoice = Convert.ToInt32(Console.ReadLine());

    FoodSeasoning seasoningChoice = numberChoice switch
    {
        1 => seasoningChoice = FoodSeasoning.Spicy,
        2 => seasoningChoice = FoodSeasoning.Salty,
        3 => seasoningChoice = FoodSeasoning.Sweet,
    };
    return seasoningChoice;
        
}
enum FoodTypes { Soup, Stew, Gumbo};
enum FoodMainIngredient {Mushroom, Chicken, Carrot, Potato};
enum FoodSeasoning {Spicy, Salty, Sweet};


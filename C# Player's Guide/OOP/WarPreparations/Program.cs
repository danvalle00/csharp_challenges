Console.Title = "War Preparations";

Sword originalSword = new Sword(MaterialType.Iron, GemstoneType.None, 5.0f, 2.0f);
Sword variationSword1 = originalSword with { SwordMaterial = MaterialType.Binarium };
Sword variationSword2 = originalSword with { SwordGemstone = GemstoneType.Bitstone };

Console.WriteLine(originalSword);
Console.WriteLine(variationSword1);
Console.WriteLine(variationSword2);

public record Sword (MaterialType SwordMaterial, GemstoneType SwordGemstone, float SwordLength,  float SwordCrossguardWidth);
public enum MaterialType { Wood, Bronze, Iron, Steel, Binarium }
public enum GemstoneType { Emerald, Amber, Sapphire, Diamond, Bitstone, None }

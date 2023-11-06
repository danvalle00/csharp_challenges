Console.Title = "The Card";

Color[] allColors = new Color[] {Color.Red, Color.Green, Color.Blue, Color.Yellow};
Rank[] allRanks = new Rank[] {Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, 
                              Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, 
                              Rank.Percent, Rank.Caret, Rank.Ampersand};

foreach (Color color in allColors)
{
    foreach (Rank rank in allRanks)
    {
        Card card = new Card(color, rank);
        Console.WriteLine($"The {card.CardColor} {card.CardRank} ");
    }
}

public class Card
{
    public Color CardColor { get; }
    public Rank  CardRank { get; }

    public Card(Color cardColor, Rank cardRank)
    {
        CardColor = cardColor;
        CardRank = cardRank;
    }
}
public enum Color { Red, Green, Blue, Yellow }
public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }

//  Answer this question: Why do you think we used a color enumeration here but made a color class 
// in the previous challenge?
// Because we have an limited amount of color choices
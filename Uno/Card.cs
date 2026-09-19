namespace Uno;

public enum CardType
{
    Number, Wild, Draw2, WildDraw4, Skip, Reverse
}

public enum Color
{
    Red, Yellow, Blue, Green, Wild
}

public class Card
{

    public CardType Type { get; set; }
    public Color Color { get; set; }
    public int? Number { get; set; }


    public static bool PlaysOn(Card card1, Card card2, Color? currentColor = null)
    {

        switch (card1.Type)
        {

            case CardType.Number:
                if (card2.Type == CardType.Number)
                {
                    return card1.Number == card2.Number || card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
                {
                    if (currentColor is null)
                    {
                        return true;
                    }
                    else return card1.Color == currentColor;
                    // TODO, check current color
                }
                else
                {
                    return card1.Color == card2.Color;
                    // SKIP, REVERSE, DRAW2
                    //TODO, check color
                }

            case CardType.Skip:
                if (card2.Type == CardType.Number)
                {
                    return card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Skip)
                {
                    return true;
                }
                else if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
                {
                    if (currentColor is null)
                    {
                        return true;
                    }
                    else return card1.Color == currentColor;
                    // TODO, check current color
                }
                else
                {
                    return card1.Color == currentColor;
                    // SKIP, REVERSE, DRAW2
                    //TODO, check color
                }

            case CardType.Draw2:
                if (card2.Type == CardType.Number)
                {
                    return card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Draw2)
                {
                    return true;
                }
                else if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
                {
                    if (currentColor is null)
                    {
                        return true;
                    }
                    else return card1.Color == currentColor;
                    // TODO, check current color
                }
                else
                {
                    return card1.Color == currentColor;
                    // SKIP, REVERSE, DRAW2
                    //TODO, check color
                }
            case CardType.Reverse:
                if (card2.Type == CardType.Number)
                {
                    return card1.Color == card2.Color;
                }
                else if (card2.Type == CardType.Reverse)
                {
                    return true;
                }
                else if (card2.Type == CardType.Wild || card2.Type == CardType.WildDraw4)
                {
                    if (currentColor is null)
                    {
                        return true;
                    }
                    else return card1.Color == currentColor;
                    //return card1.Color == currentColor;
                    // TODO, check current color
                }
                else
                {
                    return card1.Color == currentColor;
                    // SKIP, REVERSE, DRAW2
                    //TODO, check color
                }
            default: return true;
            



        }

        return false;
    }
    public override string ToString()
    {
        //TODO handle other card types
        if(Type == CardType.Number)
        {
            return $"{Color} {Number}";
        }
        if(Type == CardType.Draw2)
        {
            return $"{Color} Draw2";
        }
        if(Type == CardType.Reverse)
        {
            return $"{Color} Reverse";
        }
        if(Type == CardType.Skip)
        {
            return $"{Color} Skip";
        }
        else
        {
            return Type.ToString();
        }
    }

}
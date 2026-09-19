namespace Uno;

public class Player
{
    public string Name { get; set; } = "";

    public List<Card> Hand { get; set; } = new();

    public bool HasPlayableCard(Card card)
    {
        foreach(Card potentialcard in Hand)
        {
            if (Card.PlaysOn(potentialcard, card))
            {
                return true;
            }
        }
        return false;
    }

    public Card GetFirstPlayableCard(Card card)
    {
        if (HasPlayableCard(card) == false)
        {
            return null;
        }
        foreach(Card potentialcard in Hand)
        {
            if (Card.PlaysOn(potentialcard, card))
            {
                return potentialcard;
            }
        }
        return null;
    }

    public Color MostCommonColor()
    {
        int redcount = 0;
        int yellowcount = 0;
        int bluecount = 0;
        int greencount = 0;
        foreach(Card card in Hand)
        {
            if (card.Color == Color.Red)
            {
                redcount++;
            }
            if (card.Color == Color.Yellow)
            {
                yellowcount++;
            }
            if (card.Color == Color.Blue)
            {
                bluecount++;
            }
            if (card.Color == Color.Green)
            {
                greencount++;
            }
        }
        if (redcount >= yellowcount && redcount >= bluecount && redcount >= greencount)
        {
            return Color.Red;
        }
        else if (yellowcount >= bluecount && yellowcount >= greencount)
        {
            return Color.Yellow;
        }
        else if (bluecount >= greencount)
        {
            return Color.Blue;
        }
        else
        {
            return Color.Green;
        }
    }



}
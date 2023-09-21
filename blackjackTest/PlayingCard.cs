namespace blackjackTest;

public class PlayingCard
{
    public string suit;
    public string value;

    public PlayingCard(string suit, string value)
    {
        this.suit = suit;
        this.value = value;
    }

    public int getValue()
    {
        if (value is "king" or "queen" or "jack")
        {
            return 10;
        }
        else
        {
            return Convert.ToInt32(value);
        }
    }
}
using System.Threading.Channels;

namespace blackjackTest;

public class CardDeck
{
    public List<PlayingCard> Deck;
    public List<PlayingCard> DiscardPile;

    public CardDeck(int numOfDeck = 1, bool usingDiscardPile = true)
    {
        Deck = new List<PlayingCard>();
        InitializeDeck();
    }

    public void InitializeDeck()
    {
        string[] suits = { "hearts", "clubs", "diamonds", "spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };

        foreach (var t in suits)
        {
            for (int i = 0; i < ranks.Length; i++)
            {
                Deck.Add(new PlayingCard(t, ranks[i]));
            }
        }
    }

    public void showDeck()
    {
        Console.WriteLine(Deck.Count);
    }

    public PlayingCard DrawCard()
    {
        return Deck[0];
    }

    public void AddToDiscardPile()
    {
        
    }

    
}
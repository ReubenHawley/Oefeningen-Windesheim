namespace week1;

public class CardRepository:Repository
{
    public CardRepository()
    {
        items = new List<IRepoItem>();
        Card card = new Card();
        Card card2 = new Card();
        Card card3 = new Card();
        items.Add(card);
        items.Add(card2);
        items.Add(card3);
    }

    public Card GetCard(String accountNumber)
    {
        return (Card)items[1];
    }
}
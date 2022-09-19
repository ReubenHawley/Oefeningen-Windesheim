namespace week1;

public class CardRepository:Repository
{
    public CardRepository()
    {
        items = new List<IRepoItem>();
        Card card = new Card(1,"Reuben","NL12ING8267890","0007");
        Card card2 = new Card(2,"Julian","NL12ING8267891","1111");
        Card card3 = new Card(3,"Wouter","NL12ING8267892","9999");
        items.Add(card);
        items.Add(card2);
        items.Add(card3);
    }

    public Card GetCard(string? accountNumber)
    {       
        return Get().Cast<Card>().FirstOrDefault(card => card.AccountNumber == accountNumber );
    }
}
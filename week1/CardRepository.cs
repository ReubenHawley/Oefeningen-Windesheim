namespace week1;

public class CardRepository:Repository
{
    public CardRepository()
    {
        items = new List<IRepoItem>();
        Update(new Card(1,"Reuben","NL12ING8267890","0007"));
        Update(new Card(2,"Julian","NL12ING8267891","1111"));
        Update (new Card(3,"Wouter","NL12ING8267892","9999"));
    }

    public Card GetCard(string? accountNumber)
    {       
        return Get().Cast<Card>().FirstOrDefault(card => card.AccountNumber == accountNumber );
    }
}
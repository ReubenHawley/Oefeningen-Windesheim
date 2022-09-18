namespace week1;

public class AccountRepository:Repository
{
    public AccountRepository()
    {
        items = new List<IRepoItem>();
        Account account = new Account();
        Account account2 = new Account();
        Account account3 = new Account();
        items.Add(account);
        items.Add(account2);
        items.Add(account3);
    }

    public Account GetAccount(String accountNumber)
    {
        return (Account)items[1];
    }
}
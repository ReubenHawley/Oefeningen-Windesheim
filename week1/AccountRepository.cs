namespace week1;

public class AccountRepository:Repository
{
    public AccountRepository()
    {
        items = new List<IRepoItem>();
        Account account = new Account(1,"Reuben",1,1000,"NL12ING8267890");
        Account account2 = new Account(1,"Julian",2,2000,"NL12ING8267891");
        Account account3 = new Account(1,"Wouter",3,3000,"NL12ING8267892");
        items.Add(account);
        items.Add(account2);
        items.Add(account3);
    }

    public Account GetAccount(string? accountNumber)
    {
        return Get().Cast<Account>().FirstOrDefault(account => account.AccountNumber == accountNumber );
    }
}
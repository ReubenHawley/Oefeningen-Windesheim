namespace week1.Models;

public class AccountRepository:Repository
{
    public AccountRepository()
    {
        items = new List<IRepoItem?>();
        Update( new ChequeAccount(1,"Reuben",1,1000,"NL12ING8267890"));
        Update(new ChequeAccount(1,"Julian",2,2000,"NL12ING8267891"));
        Update(new ChequeAccount(1,"Wouter",3,3000,"NL12ING8267892"));
    }

    public Account GetAccount(string? accountNumber)
    {
        return Get().Cast<Account>().FirstOrDefault(account => account.AccountNumber == accountNumber );
    }
}
namespace week1.Models;

public class Account:IRepoItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int CustomerId { get; set; }

    public double Balance { get; private protected set; } = 0;
    public string? AccountNumber { get; set; }
    
    public AccountType TypeOfAccount { get; protected set; }

    public Account() {}

    public Account(int id, string? name, int customerId, double balance, string? accountNumber): this()
    {
        Id = id;
        Name = name;
        CustomerId = customerId;
        Credit(balance);
        AccountNumber = accountNumber;
    }
    
    public virtual void Credit(double amount)
    {
        Balance += amount;
    }
    public virtual void Debit(double amount)
    {
        Balance -= amount;
    }
    public override string ToString()
    {
        return $"[{AccountNumber}]{Name}";
    }
}

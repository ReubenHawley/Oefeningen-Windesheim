using System.Text;

namespace week1;

public class Account:IRepoItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int CustomerId { get; set; } 
    public double Balance { get; set; }
    public string? AccountNumber { get; set; }

    public Account() {}

    public Account(int id, string? name, int customerId, double balance, string? accountNumber)
    {
        Id = id;
        Name = name;
        CustomerId = customerId;
        Balance = balance;
        AccountNumber = accountNumber;
    }

    public override string ToString()
    {
        return $"[{AccountNumber}]{Name}";
    }
}

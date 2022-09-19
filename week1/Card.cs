using System.Text;

namespace week1;

public class Card:IRepoItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? AccountNumber{ get; }
    public string? Code{ get; set; }

    public Card() {}

    public Card(int id, string? name, string? accountNumber, string? code)
    {
        Id = id;
        Name = name;
        AccountNumber = accountNumber;
        Code = code;
    }

    public override bool Equals(object? obj)
    {
        Account account = (Account) obj;
        if (account != null && account.AccountNumber == AccountNumber)
        {
            return true;
        }

        return false;
    }
}
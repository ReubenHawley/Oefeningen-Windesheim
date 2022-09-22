namespace week1.Models;

public class CreditAccount :Account
{
    public double ServiceChargePercentage { get; set; } = 0.015;
    public CreditAccount(): base()
    {
    }

    public CreditAccount(int id, string? name, int customerId, double balance, string? accountNumber) : base(id, name, customerId, balance, accountNumber)
    {
        TypeOfAccount = AccountType.Credit;
    }
    
    public override void Credit(Double amount)
    {
        Balance += amount;
        Balance -= CalculateServiceCharge();
    }

    public override void Debit(Double amount)
    {
        Balance -= CalculateServiceCharge();
        Balance -= amount;
    }
    
    public Double CalculateServiceCharge()
    {
        return Balance*ServiceChargePercentage;
    }


}
namespace week1.Models;

public class ChequeAccount: Account
{
    private Double ServiceChargePercentage { get; set; } = 0.01;
    public ChequeAccount(): base()
    {
    }

    public ChequeAccount(int id, string? name, int customerId, double balance, string? accountNumber) : base(id, name, customerId, balance, accountNumber)
    {
        TypeOfAccount = AccountType.Cheque;
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
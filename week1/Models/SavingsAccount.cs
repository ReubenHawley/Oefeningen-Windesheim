namespace week1.Models;

public class SavingsAccount: Account
{

    public double InterestRate { get; private set; } = 0.015;    
    public SavingsAccount(): base()
    {
    }

    public SavingsAccount(int id, string? name, int customerId, double balance, string? accountNumber) : base(id, name, customerId, balance, accountNumber)
    {
        TypeOfAccount = AccountType.Savings;
    }
    
    public Double CalculateInterest()
    {
        var todayYear = (int)DateTime.Today.Year;
        var todayMonth = (int)DateTime.Today.Month;
        return Balance*(InterestRate/DateTime.DaysInMonth(todayYear,todayMonth));
    }


    public void CreditInterest()
    {
        Credit(CalculateInterest());
    }
}
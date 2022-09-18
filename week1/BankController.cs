namespace week1;

public class BankController
{
    private CustomerRepository? Customers { get; set; }
    private AccountRepository? Accounts { get; set; }
    private CardRepository? Cards { get; set; }
    private int Status { get; set; }
    private Card? CurrentCard { get; set; }
    private Account? CurrentAccount { get; set; }
    private List<string>? WithdrawalAmounts { get; set; }
    private Customer? CurrentCustomer { get; set; }
    
    public BankController()
    {
        WithdrawalAmounts = new List<string>() {"0","20","50","100"};
        Status = 0;
        Customers = new CustomerRepository();
        Accounts = new AccountRepository();
        Cards = new CardRepository();
    }

    public void Process()
    {
    }

    public void MainMenu()
    {
        Console.WriteLine("----------------------[Geld Automaat]----------------------");
    }

    public void ValidCardMenu()
    {
        Console.WriteLine("Welkom Peter Pannekoek - rekeningnummer 812347654\n" +
                          "Kies 1, 2 of 3 uit het volgende menu:\n" +
                          "1.\tSaldo opvragen\n" +
                          "2.\tGeld opnemen\n" +
                          "3.Stoppen.");
    }

    public void BalanceMenu()
    {
        Console.WriteLine("----------------------[Geld opnemen]----------------------\n" +
                          "Saldo van rekening 812347654 is 1235,55\n" +
                          "Druk <enter> om verder te gaan");
    }
    public void WithdrawalMenu()
    {
        Console.WriteLine("----------------------[Geld opnemen]----------------------\n" +
                          "Hoeveel geld wil jij opnemen [20,50,100]?");
    }

    public String ShowCardMenu()
    {
        return "";
    }

    public String ShowWithdrawalMenu()
    {
        return "";
    }

    public override string ToString()
    {
        return "BankController";
    }
}
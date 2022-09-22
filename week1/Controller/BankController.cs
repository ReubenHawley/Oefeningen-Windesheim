using week1.Models;

namespace week1.Controller;

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
        Console.WriteLine($"Nieuew Saldo rekeningnummer is {CurrentCard.AccountNumber} is {CurrentAccount.Balance}\n" +
                          $"Druk op <Enter> om verder te gaan...");
        Console.ReadLine();
        ValidCardMenu();
    }

    public void MainMenu()
    {
        Console.Write("----------------------[Geld Automaat]----------------------\n" +
                          "Voer je pasnummer in of geef <enter> om te stoppen: ");
        //get user input for the account number
        var accountNumber = Console.ReadLine();
        if (accountNumber == "")
        {
            Environment.Exit(0);
        }
        //use the account number to determine the card and account in the system
        CurrentAccount = Accounts?.GetAccount(accountNumber);
        CurrentCard = Cards?.GetCard(accountNumber);
        //use the accountID to return the linked customer
        CurrentCustomer = Customers.GetCustomer(CurrentAccount.Id);
        //create a loop that allows max 3 tries
        int i = 0;
        int maxtries = 3;
        while (i < maxtries)
        {
            Console.WriteLine("Voer je pincode in: ");
            var userPin = Console.ReadLine();
            if (CurrentCard?.Code == userPin)
            {
                ValidCardMenu();
                break;
            }
            else
            {
                i++;
                if (i != maxtries)
                {
                    Console.WriteLine($"PinCode onjuist. je heb nog {maxtries-i} pogingen");

                }
                else
                {
                    Console.WriteLine($"Je hebt de pincode {i} onjuist ingevoerd, je kaart wordt nu in beslag genomen");
                }
            }
        }
    }

    public void ValidCardMenu()
    {
        Console.WriteLine($"Welkom {CurrentAccount.Name} - rekeningnummer {CurrentAccount.AccountNumber}\n" +
                          "Kies 1, 2 of 3 uit het volgende menu:\n" +
                          "1.\tSaldo opvragen\n" +
                          "2.\tGeld opnemen\n" +
                          "3.\tStoppen.");
        var choice = (Console.ReadLine());
        switch (choice)
        {
            case "1":
                BalanceMenu();
                break;
            case "2":
                WithdrawalMenu();
                break;
            case "3":
                Environment.Exit(0);
                break;

        }
        
    }

    public void BalanceMenu()
    {
        Console.WriteLine("----------------------[Geld opnemen]----------------------\n" +
                          "Saldo van rekening 812347654 is 1235,55\n" +
                          "Druk <enter> om verder te gaan");
        Console.ReadLine();
        ValidCardMenu();
    }
    public void WithdrawalMenu()
    {
        Console.WriteLine("----------------------[Geld opnemen]----------------------\n" +
                          "Hoeveel geld wil jij opnemen [20,50,100]?");
        var withdrawalAmountString = Console.ReadLine();
        if (withdrawalAmountString != "")
        {
            var withdrawalAmount= Convert.ToUInt16(withdrawalAmountString);
            CurrentAccount?.Credit(withdrawalAmount);
            Process();
        }
        else
        {
            WithdrawalMenu();
        }
    }

    public String ShowCardMenu()
    {
        Console.WriteLine();
        return "";
    }

    public String ShowWithdrawalMenu()
    {
        return Console.ReadLine();
    }

    public override string ToString()
    {
        return "BankController";
    }
}
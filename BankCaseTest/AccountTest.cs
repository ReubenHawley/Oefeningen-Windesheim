using week1.Models;

namespace AccountTest
{
    [TestClass]
    public class AccountTest
    {

        [TestMethod]
        public void TestNewAccount()
        {
            Account account = new Account(1,"Reuben",1,1000,"NL12ING8267890");
            Assert.AreEqual(account.Name, "Reuben");
        }
        [TestMethod]
        public void TestNewChequeAccount()
        {
            Account account = new ChequeAccount(1,"Reuben",1,1000,"NL12ING8267890");
            Assert.AreEqual(account.Name, "Reuben");
            Assert.AreEqual(account.TypeOfAccount, AccountType.Cheque);
            Assert.IsInstanceOfType(account,typeof(Account));
            Assert.IsInstanceOfType(account,typeof(ChequeAccount));
        }
        [TestMethod]
        public void TestNewSavingsAccount()
        {
            Account account = new SavingsAccount(1,"Reuben",1,1000,"NL12ING8267890");
            Assert.AreEqual(account.Name, "Reuben");
            Assert.AreEqual(account.TypeOfAccount, AccountType.Savings);
            Assert.IsInstanceOfType(account,typeof(Account));
            Assert.IsInstanceOfType(account,typeof(SavingsAccount));
        }
        
        [TestMethod]
        public void TestSavingsAccountInterest()
        {
            SavingsAccount account =  new SavingsAccount(1,"Reuben",1,1000,"NL12ING8267890");
            Assert.AreEqual(account.Balance,1000);
            account.CreditInterest();
            Assert.AreEqual(1000.5,account.Balance);
        }
        
        [TestMethod]
        public void TestNewCreditAccount()
        {
            Account account = new CreditAccount(1,"Reuben",1,1000,"NL12ING8267890");
            Assert.AreEqual(account.Name, "Reuben");
            Assert.AreEqual(account.TypeOfAccount, AccountType.Credit);
            Assert.IsInstanceOfType(account,typeof(Account));
            Assert.IsInstanceOfType(account,typeof(CreditAccount));
        }
        [TestMethod]
        public void TestDepositMethod()
        {
            Account account = new Account(1,"Reuben",1,1000,"NL12ING8267890");
            Assert.AreEqual(account.Balance, 1000);
        }
        
    }
}
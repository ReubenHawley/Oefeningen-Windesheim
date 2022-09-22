using week1.Models;
using NUnit.Framework;
namespace BankTest;

public class Tests
{


    [Test]
    public void Test1()
    {
        Account account1 = new Account(1,"Reuben",1,1000,"NL12ING8267890");

        Assert.That("Reuben", Is.EqualTo(account1.Name));
    }
}
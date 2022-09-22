using week1.Models;

namespace AccountTest;
[TestClass]
public class CardTest
{
    [TestMethod]
    public void TestNewCard()
    {
        Card card1 = new Card(1, "Reuben", "NL12ING8267890", "0007");
        Assert.AreEqual(card1.Name, "Reuben");
    }
}
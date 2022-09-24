using System.Text;

namespace OdeAanHetCode;

public class StringsExample
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
    
    /// <summary>
    /// Dit is een voorbeeld van string interpolation.
    /// </summary>
    public void PrintString()
    {
        string displayName = $"{LastName}, {FirstName}";
        Console.WriteLine(displayName);
    }
    
    /// <summary>
    /// Dit is een voorbeeld van de gebruik van String builder.
    /// </summary>
    public void GebruikStringBuilder()
    {
        var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
        var manyPhrases = new StringBuilder();
        for (var i = 0; i < 10000; i++)
        {
            manyPhrases.Append(phrase);
        }
        Console.WriteLine("tra" + manyPhrases);
    }
}
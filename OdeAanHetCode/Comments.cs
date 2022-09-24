namespace OdeAanHetCode;

public class Comments
{
    public void MakeNew()
    {
        // Als je dit doet, krijg jij een onvoldoende... heeft geen nut
        // een for lusje om iteratief iets uit te voeren
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Dit is nutteloos");
            Console.WriteLine("Ik zal het nooit weer doen");
        }
        
        //Zo kan het wel...
        //De for lusje is NODIG om aan te tonen dat het een doel heeft, dat beschrijf ik hier
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Veel beter!");
            Console.WriteLine("Dit zal ik vaker doen");
        }
        
        /*
         * Dit is gewoon nasty
         * als je code in diepte wilt beschrijven
         * doe dat niet hier, maar in de gepaste document
         * Niemand wil jou levens verhaal hier lezen
         *
         * TLDR:
         * Gewoon niet doen
         */
        
    }

    /// <summary>
    /// Dit commentaar beschrijft het doel van deze methode
    /// </summary>
    public void MethodComment()
    {
        Console.WriteLine("Dat heb ik knap gedaan");
    }
}
// See https://aka.ms/new-console-template for more information

using week1.Models;

int val1 = 5;
int val2 = 4;
int val3 = 3;
int val4 = 2;

//1)	Schrijf alleen een declaratie per regel
Card card = new Card();

//2)	Schrijf alleen een statement per regel
var card2 = card;

//3)	Lijnen die overloop, dien ingesprongen te zijn
Console.WriteLine("Dit is een lange regel die helemaal nergens " +
                  "opslaat maar toch heel veel ruimte neemt, " +
                  "totdat het overloopt en dient ingesprongen te zijn");

//4)	Voeg minimaal een lege regel tussen definities en property definities
static void WriteResult(string description, int result)
{
    Console.WriteLine(description + ": " + result);
}

//5)	Gebruik haakjes om logica 
if ((val1 > val2) && (val1 > val3))
{
    // Duidleijke voorwaarden voor acties
}



using System;

/*//////////////////
// NALOGA 1 /////
//////////////////

int steviloUcencev = 25;       // celo število (int)
double cenaIzdelka = 4.99;     // decimalno število (double)
string ime = "Ana";            // besedilo (string)
bool jeAktiven = true;         // logična vrednost (bool)

Console.WriteLine("Število učencev: " + steviloUcencev);
Console.WriteLine("Cena izdelka: " + cenaIzdelka);
Console.WriteLine("Ime: " + ime);
Console.WriteLine("Je aktiven: " + jeAktiven);

*/



/*

////////naloga 2////////
///////////////////////

double realnoStevilo = 3.14;
string realnoKotBesedilo = realnoStevilo.ToString();

Console.WriteLine("Število kot string: " + realnoKotBesedilo);


*/




//////////////////////////
//////////naloga 3////////
/////////////////////////
/*

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vnesi temperaturo!");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int temperatura))
        {
            if (temperatura < 15)
            {
                Console.WriteLine("mrzlo je zunaj");
            }
            else if (temperatura > 30)
            {
                Console.WriteLine("vroče je zunaj");
            }
            else
            {
                Console.WriteLine("prijetno je zunaj.");
            }
        }
        else
        {
            Console.WriteLine("Vnesite veljavno temperaturo.");
        }
    }
}
*/

//////////////////////////
//////////naloga 4////////
//////////////////////////

/*
int stevilo = 14;              // za test poskusi npr. 9, 14, 8, 5

if (stevilo % 3 == 0)
{
    Console.WriteLine("Deljivo s 3");
}
else if (stevilo % 7 == 0)
{
    Console.WriteLine("Deljivo s 7");
}
else
{
    if (stevilo % 2 == 0)
    {
        Console.WriteLine("Število je sodo");
    }
    else
    {
        Console.WriteLine("Številka je liha");
    }
}
*/

using System;
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

/////////////////////////
////////2.naloaga////////
/////////////////////////
/*
class Program
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}
*/


/////////////////////////
///////3.naloga//////////
/////////////////////////
/*
using System;

class Program //Avtobus
{
    static void Main(string[] args)
    {
        int stevec = 1;
        int kapaciteta = 50;
        string prihod = "";

        while (prihod != "konec")
        {
            Console.WriteLine("Trenutno potnikov: " + stevec);
            Console.WriteLine("Vnesite 'vstop', 'izstop' ali 'konec':");
            prihod = Console.ReadLine();

            if (prihod == "vstop")
            {
                if (stevec < kapaciteta)
                {
                    stevec++;
                    Console.WriteLine("En potnik je vstopil.");
                }
                else
                {
                    Console.WriteLine("Avtobus je poln.");
                }
            }
            else if (prihod == "izstop")
            {
                if (stevec > 0)
                {
                    stevec--;
                    Console.WriteLine("En potnik je izstopil.");
                }
                else
                {
                    Console.WriteLine("Avtobus je prazen.");
                }
            }
            else if (prihod != "konec")
            {
                Console.WriteLine("Neveljavna izbira.");
            }
        }

        Console.WriteLine("Konec. V avtobusu je ostalo " + (kapaciteta - stevec) + " prostih mest.");
    }
}
*/

///////////////////////
////////4.naloga////////
////////////////////////
/*
class Program
{
    static void Main(string[] args)
    {
        for (int i = -3; i <= 3; i++)
        {
            Console.WriteLine(i);
        }
    }
}
*/


/*
class Program
{
    static void Main(string[] args)
    {
        int i = -3;

        while (i <= 3)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
*/

//////5.naloga///////
/*
class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }

            if (i==9)
            {
                break;
            }
        }
    }
}*/


/////////////////////////
////////6.naloga/////////
/////////////////////////
/*

class Program //Povprečna ocena
{
    static void Main(string[] args)
    {
        int vsota = 0;
        int steviloOcen = 0;
        int ocena = 0;

        Console.WriteLine("Vnašajte ocene med 5 in 10. Za konec vnesite -1.");

        while (ocena != -1)
        {
            Console.Write("Vnesite oceno: ");
            string vnos = Console.ReadLine();

            if (vnos == null)
            {
                break; // konec vnosa (npr. Ctrl+Z), program se ne zruši
            }

            if (!int.TryParse(vnos.Trim(), out ocena))
            {
                Console.WriteLine("Napaka: vnos ni celo število.");
            }
            else if (ocena >= 5 && ocena <= 10)
            {
                vsota += ocena;
                steviloOcen++;
            }
            else if (ocena != -1)
            {
                Console.WriteLine("Napaka: ocena mora biti med 5 in 10.");
            }
        }

        if (steviloOcen > 0)
        {
            double povprecje = (double)vsota / steviloOcen;
            Console.WriteLine("Število ocen: " + steviloOcen);
            Console.WriteLine("Povprečna ocena: " + povprecje.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Niste vnesli nobene ocene.");
        }
    }
}
*/


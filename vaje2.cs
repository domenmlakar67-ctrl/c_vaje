//prva naloga
/*
internal class Program
{
    private static int sestevanje(int a, int b)
    {
        return a + b;
    }


    private static int odstevanje(int a, int b)
    {
        return a - b;
    }

    private static int mnozenje(int a, int b)
    {
        return a * b;
    }

    private static int deljenje(int a, int b)
    {
        if (b == 0)
        {
            return a / b;
        }


    }
     static void Main(string[] args)
     {
        Console.WriteLine( sestevanje(30, 20));
        Console.WriteLine( odstevanje(30, 20));
        Console.WriteLine( mnozenje(30, 20));
        Console.WriteLine( deljenje(30, 20));

        Console.ReadLine();
     }
}
   */


////////2. naloga/////////


/*
string prijatelji1 = "Ana";
string prijatelji2 = "Blaž";
string prijatelji3 = "Cilka";

    public static void PozdraviPrijatelja(string ime1, string ime2, string ime3)
{
    ime1 = prijatelji1;
    ime2 = prijatelji2;
    ime3 = prijatelji3;
    Console.WriteLine(ime1);
    Console.WriteLine(ime2);
    Console.WriteLine(ime3);
}

*/

/*

///////3. naloga///////


internal class Program
{
    public static void Calculate()
    {
        Console.WriteLine("Vnesi prvo število: ");
        string? input1 = Console.ReadLine();
        Console.WriteLine("Vnesi drugo število: ");
        string? input2 = Console.ReadLine();

        double stevilka1 = Convert.ToDouble(input1);
        double stevilka2 = Convert.ToDouble(input2);
        double rezultat = stevilka1 * stevilka2;

        Console.WriteLine("Produkt: " + rezultat);
    }

    static void Main(string[] args)
    {
        Calculate();
        Console.ReadLine();
    }
}
*/

/////////4. naloga///////////



//probaj deliti z 0 trz catch
/*
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Vnesi prvo število: ");
        string? input1 = Console.ReadLine();
        Console.WriteLine("Vnesi drugo število: ");
        string? input2 = Console.ReadLine();

        try
        {
            int stevilka1 = int.Parse(input1);
            int stevilka2 = int.Parse(input2);
            int rezultat = stevilka1 / stevilka2;
            Console.WriteLine($"rezultat deljenja: {rezultat}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Deljenje z ničlo ni dovoljeno.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Vnesite veljavne številke.");
        }
        finally
        {
            Console.WriteLine("This is called anyways");
        }

        Console.ReadLine();
    }
}

*/

///////////naloga 5.//////////



/*
internal class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 3;

        int num3 = -num1; // unarni minus obrne predznak
        Console.WriteLine(num3);

        Console.ReadLine();
    }
}
*/


////////naloga 6.///////////

/*

internal class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num3 = -num1;

        if (num3 % 2 == 0)
        {
            Console.WriteLine("Število " + num3 + " je sodo.");
        }
        else
        {
            Console.WriteLine("Število " + num3 + " je liho.");
        }

        Console.ReadLine();
    }
}

*/

///////naloga 6./////////


/*internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vnesi število: ");
        int stevilka = int.Parse(Console.ReadLine());

        if (stevilka % 3 == 0)
        {
            Console.WriteLine("Deljiva s 3.");
        }
        else if (stevilka % 7 == 0)
        {
            Console.WriteLine("Deljivo s 7.");
        }
        else
        {
            if (stevilka % 2 == 0)
            {
                Console.WriteLine("Soda številka.");
            }
            else
            {
                Console.WriteLine("Liha številka.");
            }
        }

        Console.ReadLine();
    }
}
*/

////////naloga 7.///////
/*
internal class Program
{
    static void Main(string[] args)
    {
        string pravilniUsername = "domen";
        string pravilnoGeslo = "geslo123";

        Console.WriteLine("Vnesi username: ");
        string username = Console.ReadLine() ?? "";
        Console.WriteLine("Vnesi password: ");
        string password = Console.ReadLine() ?? "";

        if (username == pravilniUsername && password == pravilnoGeslo)
        {
            Console.WriteLine("Prijava uspešna.");
        }
        else
        {
            Console.WriteLine("Napačen username ali password.");
        }

        Console.ReadLine();
    }
}

*/


///////////naloga 7.////////////

/*

internal class Program
{
    static void Main(string[] args)
    {
        int age = 19;

        if (age == 15)
        {
    Console.WriteLine("Mlad");
        }
        else if (age == 25)
        {
        Console.WriteLine("Mlad");
        }
        else
        {
        Console.WriteLine("Legenda");
        }

Console.Read();
    }
}
*/


/////naloga 8.///////


internal class Program
{
    // najboljši rezultat in igralec, shranjena med klici metode
    static int highScore = 0;
    static string highScorePlayer = "";

    public static void PreveriRezultat(int score, string playerName)
    {
        if (score > highScore)
        {
            highScore = score;
            highScorePlayer = playerName;

            Console.WriteLine("Novi najboljši rezultat je " + score);
            Console.WriteLine("Novi najboljši rezultat ima " + playerName);
        }
        else
        {
            Console.WriteLine("Najboljši rezultat je " + highScore + ", ne moremo narediti več kot " + highScorePlayer);
        }
    }

    static void Main(string[] args)
    {
        PreveriRezultat(10, "Ana");
        PreveriRezultat(25, "Blaž");
        PreveriRezultat(15, "Cilka");
        PreveriRezultat(40, "Ana");

        Console.ReadLine();
    }
}





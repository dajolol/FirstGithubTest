using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        int poäng = 0;
        Console.WriteLine("Välkommen till Quizet!");

        Console.WriteLine("Fråga 1: Vilket är huvudstaden i Frankrike?");
        string svar = Console.ReadLine().ToLower();

        if (svar == "paris")
        {
            Console.WriteLine("Rätt!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel!");
        }

        Console.WriteLine("Fråga 2: Vilken brukar kallas för den röda planeten?");
        svar = Console.ReadLine().ToLower();

        if (svar == "mars")
        {
            Console.WriteLine("Rätt!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel!");
        }

        Console.WriteLine("Fråga 3: Vilken hundras är Lassie?");
        svar = Console.ReadLine().ToLower();

        if (svar == "collie")
        {
            Console.WriteLine("Rätt!");
            poäng++;
        }
        else
        {
            Console.WriteLine("Fel!");
        }

        Console.WriteLine("Skriv in en siffra som delat med 10 ska bli 5");
        svar = Console.ReadLine();

        //double svarsomnummer = double.Parse(svar); // sträng 50 --> int 50
        double svarsomnummer = 0;

        if (double.TryParse(svar, out svarsomnummer))
        {
            if (svarsomnummer == 50)
            {
                Console.WriteLine("Rätt!");
                poäng++;
            }
            else
            {
                Console.WriteLine($"Fel! Ditt svar blev inte 5, ditt svar blev {svarsomnummer / 10}.");
            }
        }
        else
        {
            Console.WriteLine("Fel! Du skrev inte ens en siffra...");
        }

        Console.WriteLine($"Nu är quizet klart. Du fick {poäng} poäng.");


    }
}

// Välkommen till Quizet!
// första frågan: Vilken är huvudstaden i Frankrike?
// Svar: paris
// Rätt! 1 poäng!
// Andra frågan: Vilken brukar kallas för den röda planeten?
// Svar: jupiter
// Fel: Fel! Rätt svar är Mars.
// ...
// Nu är quizet klart, du fick 17 poäng.
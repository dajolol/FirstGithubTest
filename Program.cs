using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        int poäng = 0;
        Console.WriteLine("Välkommen till Quizet!");

        AskQuestions("Fråga 1: Vilket är huvudstaden i Frankrike?", "paris"); // fråga 1

        AskQuestions("Fråga 2: Vilken brukar kallas för den röda planeten?", "mars"); // fråga 2

        AskQuestions("Fråga 3: Vilken hundras är Lassie?", "collie"); // fråga 3

        //Console.WriteLine("Fråga 4: Skriv in en siffra som delat med 10 ska bli 5", ); // fråga 4

        Console.WriteLine($"Nu är quizet klart. Du fick {poäng} poäng.");
    }

    static void AskQuestions(string fråga, string svaretPåFrågan)
    {
        Console.WriteLine(fråga);

        string svar = Console.ReadLine();

        if (svar.ToLower() == svaretPåFrågan)
        {
            Console.WriteLine("Rätt!");
        }
        else
        {
            Console.WriteLine("Fel!");
        }
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
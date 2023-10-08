class Program
{
    static void Main()
    {
        Console.WriteLine("Välkommen till Quizet!");

        Console.WriteLine("Fråga 1: Vilket är huvudstaden i Frankrike?");

        string svar = Console.ReadLine();

        if (svar == "paris")
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
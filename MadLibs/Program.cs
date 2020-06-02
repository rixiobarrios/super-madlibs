using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Super MadLibs";
            Console.WriteLine("Welcome to Super MadLibs!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press Enter To Start");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a Name: ");
            string name = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a Place: ");
            string place = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a Verb: ");
            string verb1 = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter a Adverb: ");
            string adverb1 = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter anoder Verb: ");
            string verb2 = Console.ReadLine();
            Console.Clear();

            Console.Write("Enter another Adverb: ");
            string adverb2 = Console.ReadLine();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Once upon a time I saw ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(name);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" at a ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(place);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(". They had a super power that made them ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(verb1);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" really ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(adverb1);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(". I wanted a super power too. So I drank a special posion. Now I can ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(verb2);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" really ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(adverb2);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(". And everyone live happily ever after");
            Console.ReadLine();

        }
    }
}

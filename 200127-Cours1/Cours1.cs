using System;

namespace ConsoleApp1;

class Cours1
{
    private static void Main(string[] args)
    {
        Random rng = new Random();
        int toto = rng.Next(0, 50);
        string choix = "";
        Console.Write("Make a choice (n/a/other string): ");
        choix = Console.ReadLine();
        int[] ArrayEntier = new int[10];
        int[] ArrayEntier2 = { 10, 0, 3 };

        ArrayEntier[0] = 10;

        // One way to manage with choice input
        if (choix == "n")
        {
            // Displays different ways to loop through an array
            Console.WriteLine("Index\n--------");
            for (int index = 0; index < toto; index++)
            {
                Console.WriteLine(index);
            }

            Console.WriteLine("for\n--------");
            for (int i=0; i < ArrayEntier.Length; i++)
                Console.WriteLine(ArrayEntier[i]);

            Console.WriteLine("Stream et Lambda\n--------");
            Array.ForEach(ArrayEntier, item => Console.WriteLine(string.Format("{0}", item)));

            Console.WriteLine("foreach\n--------");
            foreach (int nb in ArrayEntier)
                Console.WriteLine(nb);

            Console.WriteLine("--------");
        }
        else
        {
            Console.WriteLine("faux");
        }

        // Another way to deal with choice input
        switch (choix)
        {
            case "a":
                Console.WriteLine("Cas 1 :");
                break;
            default:
                Console.WriteLine("Cas par défaut.");
                break;
        }
    }
}


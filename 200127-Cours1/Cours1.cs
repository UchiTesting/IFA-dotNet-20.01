using System;

namespace ConsoleApp1
{
    class Cours1
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            int toto = rng.Next(0, 50);
            string choix = "";
            choix = Console.ReadLine();
            int[] ArrayEntier = new int[10];
            int[] ArrayEntier2 = { 10, 0, 3 };

            ArrayEntier[0] = 10;

            if (choix == "n")
            {
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
}


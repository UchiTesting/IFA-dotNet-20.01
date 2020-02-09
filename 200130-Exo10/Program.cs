using System;

namespace _200130_Exo10
{
    /* Ecrire la factorielle en recursive
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 10: Calcul de factorielle.\n========\n");
            int n = askInt("Valeur de N: ");

            Console.WriteLine(factorielleRecursive(n));
        }

        static int factorielleRecursive(int n)
        {
            if (n >= 2)
            {
                return n * factorielleRecursive(n - 1);
            } else if (n == 0 || n == 1)
            {
                return 1;
            }

            return -1;
        }

        // Demande un entier.
        static int askInt()
        {
            int tmp = -1;
            bool ok = false;
            do
            {
                bool DEBUG = false;

                try
                {
                    Console.Write("Veuillez saisir un entier: ");
                    tmp = Convert.ToInt16(Console.ReadLine());
                    ok = true;

                    if (DEBUG)
                        Console.WriteLine("tmp -> " + tmp);

                    return tmp;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Pas un entier.");
                }
            } while (!ok);

            return tmp;
        }

        static int askInt(string message)
        {
            Console.Write(message);
            return askInt();
        }
    }
}

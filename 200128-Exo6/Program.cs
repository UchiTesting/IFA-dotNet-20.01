using System;

namespace _200128_Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 5: Suite Arithmétique\n========\n");

            const bool DEBUG = true;

            int unN;
            int unQ;
            int unZ;

            try
            {
                Console.Write("Valeur de N: ");
                unN = Convert.ToInt16(Console.ReadLine());
                Console.Write("Valeur de Q: ");
                unQ = Convert.ToInt16(Console.ReadLine());
                Console.Write("Valeur de Z: ");
                unZ = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("[n: " + unN + ", q: " + unQ + ", z: " + unZ + "]");
                if (DEBUG)
                    Console.WriteLine("U(n) = " + suiteArithmetique(unN, unQ, unZ));
            }
            catch (FormatException)
            {
                Console.WriteLine("Veuillez saisir des entiers.");
            }

        }
        static int suiteArithmetique(int n, int q, int z)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                // TODO Revoir la formule de la suite Arithmétique
                return q + suiteArithmetique(n - 1, q, z) + z;
            }
        }
    }
}

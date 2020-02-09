using System;

namespace _200128_Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 5: Suite Géométrique\n========\n");

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
                
                Console.WriteLine("U(n) = " + suiteGeo(unN, unQ, unZ));

                if (DEBUG)
                    Console.WriteLine("[n: " + unN + ", q: " + unQ + ", z: " + unZ + "]");
            }
            catch (FormatException)
            {
                Console.WriteLine("Veuillez saisir des entiers.");
            }

        }
        static int suiteGeo(int n, int q, int z)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return q * suiteGeo(n - 1, q, z) + z;
            }
        }
    }

}

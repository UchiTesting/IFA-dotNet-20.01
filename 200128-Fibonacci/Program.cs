using System;

namespace _200128_Exo7
{
    class Program
    {
        const bool DEBUG = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Exo 7: Fibonacci\n========\n");
            int n = askInt("Saisissez la valeur de n: ");
            Console.WriteLine("Resultat Fibonacci Itératif: " + suiteFibonacciIterative(n));
            Console.WriteLine("Resultat Fibonacci Recursif: " + suiteFibonacciRecursive(n));
        }

        /* n(0) = 0
         * n(1) = 1
         * n > 1 = f(n-1) + f(n-2)
         * 
         */
        static int suiteFibonacciRecursive(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n > 1)
            {
                return suiteFibonacciRecursive(n - 1) + suiteFibonacciRecursive(n - 2);
            }
            else
            {
                return -1;
            }
        }

        /* Suite de Fibonacci itérative.
         */
        static int suiteFibonacciIterative(int n)
        {
            int nb1 = 0;
            int nb2 = 1;
            int tmp = 0;

            if (n > 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    tmp = nb1 + nb2;
                    nb1 = nb2;
                    nb2 = tmp;
                }

                return tmp;
            }
            else if (n == 0 || n == 1)
            {
                return n;
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

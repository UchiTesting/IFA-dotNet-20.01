using System;

namespace _200130_Exo9
{
    class Program
    {
        const bool DEBUG = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 9: Afficher la table de X.\n========\n");
            int multiple = askInt("Multiple: ");
            int valMax = askInt("Valeur plafond: ");
            int[] tabInt = new int[0];

            Console.WriteLine("Version itérative:\n========");
            tabInt = calculTableIterative(multiple, valMax);
            affichertable(tabInt);
            Console.WriteLine();

            Console.WriteLine("Version recursive:\n========");
            tabInt = new int[0];
            calculTableRecursive(multiple, valMax, ref tabInt);
            affichertable(tabInt);
        }

        private static void affichertable(int[] tabInt)
        {
            for (int i = 0; i <= tabInt.Length - 1; i++)
            {
                Console.WriteLine(string.Format("{0}: {1}", i, tabInt[i]));
            }
        }

        static int[] calculTableIterative(int multiple, int valMax)
        {
            int[] tabInt = new int[0];
            int taille = 0;

            while ((multiple * (taille)) <= valMax)
            {
                taille++;
                Array.Resize(ref tabInt, taille);
                if (taille - 1 == 0)
                {
                    tabInt[taille - 1] = 0;
                }
                else
                {

                    tabInt[taille - 1] = (taille - 1) * multiple;
                }
            }

            return tabInt;
        }

        static void calculTableRecursive(int multiple, int valMax, ref int[] tabInt, int taille = 0)
        {
            if ((multiple * (taille-1)) <= valMax)
            {
                if (taille == 0)
                {
                    Array.Resize(ref tabInt, taille + 1);
                    tabInt[0] = 0;
                    calculTableRecursive(multiple, valMax, ref tabInt, taille+1);

                }
                else
                {
                    Array.Resize(ref tabInt, taille);
                    tabInt[taille - 1] = (taille - 1) * multiple;
                    if (tabInt[taille-1] < valMax)
                        calculTableRecursive(multiple, valMax, ref tabInt, taille + 1);
                }
            }
        }

        static int askInt()
        {
            bool ok = false;
            int n = -1;

            do
            {
                try
                {
                    n = Convert.ToInt16(Console.ReadLine());
                    if (DEBUG)
                        Console.WriteLine(string.Format("n -> {0}", n));
                    ok = true;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Veuillez saisir des entiers.");
                }
            } while (!ok);

            return n;
        }

        static int askInt(string message)
        {
            Console.Write(message);
            return askInt();
        }
    }
}

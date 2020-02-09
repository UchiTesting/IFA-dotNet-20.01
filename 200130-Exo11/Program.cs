using System;
using System.Text;
//using _200128_Exo7;

namespace _200130_Exo11
{
    /* Demander à l'utilisateur de saisie un nombre d'entiers.
     * Trouver le minimum et le maximum du tableau avec leurs indices.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 11: Min et Max d'un tableau.\n========\n");
            int n = 0;
            int min = -100;
            int max = 100;
            int minTab = min;
            int maxTab = max;
            int[] tabInt = new int[0];
            Random rnd = new Random();

            Console.Write("Veuillez saisir un nombre d'entiers à ajouter au tableau > 1: ");
            do
            {
                n = Convert.ToInt16(Console.ReadLine());
            } while (n < 1);

            for (int i = 0; i < n; i++)
            {
                Array.Resize(ref tabInt, i + 1);
                tabInt[i] = rnd.Next(minTab, maxTab);
                Console.Write("|{0,4}: {1,4:00}", i + 1, tabInt[i]);
                if ((i + 1) % 10 == 0)
                    Console.Write("|\r\n");
            }

            Console.WriteLine("\n");
            // Après le remplissage du tableau on redéfinit min pour la valeur max afin que la fonction de recherche puisse fonctionner.
            min = max;

            min = findMinInIntTableRecursive(tabInt, maxTab);
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write(string.Format("Min: {0,4}", min));
            Console.Write(" " + findValIndexes(tabInt, min,1));
            Console.Write("\n");

            max = findMaxInInttableRecursive(tabInt, minTab, 0);
            Console.Write(string.Format("Max: {0,4}", max));
            Console.Write(" "+findValIndexes(tabInt, max,1));
            Console.ResetColor();
            Console.Write("\n");
        }

        static int findMinInIntTableRecursive(int[] tabInt, int min, int idx = 0)
        {

            if (tabInt[idx] < min)
            {
                min = tabInt[idx];
            }

            if (idx < tabInt.Length - 1)
            {
                min = findMinInIntTableRecursive(tabInt, min, idx + 1);
            }

            return min;
        }

        static int findMaxInInttableRecursive(int[] tabInt, int max, int idx)
        {
            if (tabInt[idx] > max)
                max = tabInt[idx];

            if (idx < tabInt.Length - 1)
                max = findMaxInInttableRecursive(tabInt, max, idx + 1);

            return max;
        }

        static string findValIndexes(int[] tabInt, int valueToFind, int displayOffset=0)
        {
            int[] tabIdx = new int[0];
            int taille = 0;

            // Building a table of indexes
            for (int i = 0; i < tabInt.Length - 1; i++)
            {
                if (tabInt[i] == valueToFind)
                {
                    taille++;
                    Array.Resize(ref tabIdx, taille);
                    tabIdx[taille - 1] = i;
                }
            }

            //Building a string to return
            StringBuilder builder = new StringBuilder();

            builder.Append(string.Format("{0,4} found at indexes -> [ ", valueToFind));

            for (int i = 0; i < tabIdx.Length; i++)
            {
                if (i == tabIdx.Length - 1)
                    builder.Append(string.Format(" {0} ", tabIdx[i]+displayOffset));
                else
                    builder.Append(string.Format(" {0},", tabIdx[i]+displayOffset));
            }

            builder.Append("]");

            return builder.ToString();
        }
    }
}

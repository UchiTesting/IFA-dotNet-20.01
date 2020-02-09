using System;

namespace _200130_Exo12
{
    /* Dans un tableau non trié
     * Trouver l'élément manquant.
     * 
     * Droit à 2 boucles d'affichage.
     * Une autre boucle.
     * Une variable temporaire en plus de celle nécessaires aux boucles.
     */
    class Program
    {
        private const bool DEBUG = false;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("", "CS0162", MessageId = "args")]

        static void Main(string[] args)
        {
            Console.WriteLine("Exo12: Valeur manquante.\n========\n");
            int[] tabInt = { 10, 1, 3, 4, 9, 8, 5, 2, 7 };
            int manquant= 0;

            for (int i = 0; i <= tabInt.Length;i++)
            {
                manquant += i+1;
                if (DEBUG)
                    Console.Write(String.Format("{0,5:0} {1,5:0}\n", i, manquant));
            }

            for (int i = 0; i < tabInt.Length;i++)
            {
                manquant -= tabInt[i];
                if (DEBUG)
                    Console.WriteLine(manquant);
            }

            Console.Write("\r\n");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valeur manquante: "+(manquant));
            Console.ResetColor();
        }
    }
}

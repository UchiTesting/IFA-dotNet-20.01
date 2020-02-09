using System;

/*
 * Ecrire un programme Tableau dynamique
 * Saisir entiers
 * Quit Q
 * Afficher le contenu du tableau
 * 
 */

namespace _200127_Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 2: Tableau de n entiers\n========\n");
            int taille = 0;
            int[] tab = new int[taille];
            string valeurSaisie = string.Empty;
            int n;

            do
            {
                Console.Write("Valeur (q -> quitter): ");
                valeurSaisie = Console.ReadLine();
                if (int.TryParse(valeurSaisie, out n))
                {
                taille++;
                Array.Resize(ref tab, taille);
                tab[taille - 1] = n;
                } else
                {
                    if (valeurSaisie != "q")
                        Console.WriteLine("Please input an integer.");
                }

            } while (!valeurSaisie.Equals("q"));

            // Affichage du tableau
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;

/* Enoncé
 * 
 * Créer un programme qui demande à l'utilisateur un nombre n d'entiers
 * Remplir un tableau de valeurs aléatoires
 * Calculer et afficher la somme.
 */

namespace _200127_Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 1: Somme de n entiers aléatoires.\n========\n");
            Console.Write("Veuillez saisir un nombre de valeurs à entrer: ");

            const bool DEBUG = false;
            int nbValeurs = Int16.Parse(Console.ReadLine());
            int[] tabValeurs = new int[nbValeurs];
            Random rnd = new Random();
            int somme = 0;

            for (int idx = 0; idx < tabValeurs.Length; idx++)
            {
                tabValeurs[idx] = rnd.Next(999999);
                somme += tabValeurs[idx];
                if (DEBUG)
                    Console.WriteLine(string.Format("[idx: {0}, tab[{0}]: {1}", idx, tabValeurs[idx]));
            }

            Console.WriteLine("Somme: "+somme.ToString());
        }
    }
}

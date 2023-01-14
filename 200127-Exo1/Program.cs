using System;

/* Enoncé
 * 
 * Créer un programme qui demande à l'utilisateur un nombre n d'entiers
 * Remplir un tableau de valeurs aléatoires
 * Calculer et afficher la somme.
 * 
 * Create a program asking the user to n integers.
 * Fill an array with random values.
 * Compute and display the sum.
 */

namespace _200127_Exo1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exo 1: Somme de n entiers aléatoires.\n========\n");
        Console.Write("Veuillez saisir un nombre de valeurs à entrer: ");

        int nbValeurs;

        try
        {
            nbValeurs = Int16.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {

            Console.Error.WriteLine(e.Message);
            Console.WriteLine("Définition du nombre de valeurs à entrer à 3.");

            nbValeurs = 3;
        }

        int[] tabValeurs = new int[nbValeurs];
        Random rnd = new Random();
        int somme = 0;

        for (int idx = 0; idx < tabValeurs.Length; idx++)
        {
            tabValeurs[idx] = rnd.Next(999999);
            somme += tabValeurs[idx];
            Console.WriteLine(string.Format("[idx: {0}, tab[{0}]: {1}", idx, tabValeurs[idx]));
        }

        Console.WriteLine("\nSomme: "+somme.ToString());
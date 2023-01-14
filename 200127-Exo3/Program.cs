using System;
using System.Linq;

namespace _200127_Exo3;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Exo 3: Pallindrome.\n========\n");
        Console.Write("Veuillez saisir un mot ou une chaine de caracteres: ");
        string saisie = Console.ReadLine();

        Console.WriteLine($"{saisie} <=> {reverseString(saisie)}");

        if (reverseString(saisie).Equals(saisie))
            Console.WriteLine(saisie + " est un pallindrome.");
        else
            Console.WriteLine(saisie + " n'est pas un pallindrome.");
    }

    static string reverseString(string str) 
        => new string(str.Reverse().ToArray());
}

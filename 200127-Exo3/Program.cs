using System;

namespace _200127_Exo3
{
    class Program
    {

        static void Main(string[] args)
        {
            bool DEBUG = false;
            Console.WriteLine("Exo 3: Pallindrome.\n========\n");
            Console.Write("Veuillez saisir un mot ou une chaine de caracteres: ");
            string saisie = Console.ReadLine();

            if (reverseString(saisie).Equals(saisie))
            {
                Console.WriteLine(saisie + " est un pallindrome.");
            } else
            {
                Console.WriteLine(saisie + " n'est pas un pallindrome.");
            }
            if (DEBUG)
               Console.WriteLine(string.Format("s: {0}, r: {1}", saisie, reverseString(saisie)));
        }

        static string reverseString(string str)
        {
            char[] strArray = str.ToCharArray();
            Array.Reverse(strArray);

            return new string(strArray);
        }
    }
}

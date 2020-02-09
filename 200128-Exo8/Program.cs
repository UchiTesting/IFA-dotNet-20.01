using System;

namespace _200128_Exo8
{
    class Program
    {
        /*
         * Saisir un tableau de char.
         * Inverser de manière récursive.
         * Affichage recursif et itératif.
         */

        private static bool DEBUG = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Exo 8: Inversion de chaine récursive.\n========\n");
            Console.WriteLine("Veuillez saisir des lettres. Terminer avec le caractère point.");

            string motSaisi = saisirTabChar();
            Console.WriteLine(); // Force un passage à la ligne.

            string motInverse = reverseString(motSaisi, 0);


            afficheIteratif(motSaisi);
            afficheIteratif(motInverse);
            afficheRecursif(motSaisi);
            afficheRecursif(motInverse);

            // System.Console.WriteLine(motSaisi+" "+motInverse);

        }

        public static string saisirTabChar()
        {
            int taille = 0;
            char tmp = '\0';

            char[] tabChar = new char['\0'];
            do
            {
                tmp = askChar();
                if (tmp != '.')
                {
                    taille++;
                    Array.Resize(ref tabChar, taille);
                    tabChar[taille - 1] = tmp;
                }
            } while (tmp != '.');

            return new string(tabChar);
        }

        public static string reverseString(string str, int contour) => new string(reverseString(str.ToCharArray(), contour));

        public static char[] reverseString(char[] strArray, int contour)
        {
            char tmp = '\0';

            if (Program.DEBUG == true)
            {
                System.Console.WriteLine("[Len: " + strArray.Length + ", contour: " + contour + "]");
                System.Console.WriteLine("[ArrBegin: " + strArray);
            }

            if (contour < (strArray.Length / 2))
            {
                tmp = strArray[contour];
                strArray[contour] = strArray[strArray.Length - contour - 1];
                strArray[strArray.Length - contour - 1] = tmp;

                strArray = reverseString(strArray, contour + 1);
            }

            return strArray;
        }

        public static void afficheIteratif(char[] strArray)
        {
            foreach (var c in strArray)
            {
                Console.Write(c);
            }
            Console.Write("\r\n");
        }

        public static void afficheIteratif(string str)
        {
            afficheIteratif(str.ToCharArray());
        }

        public static void afficheRecursif(char[] strArray, int idx = 0)
        {
            if (Program.DEBUG == true)
                Console.WriteLine("idx: " + idx);

            if (idx < strArray.Length)
            {
                Console.Write(strArray[idx]);
                afficheRecursif(strArray, ++idx);
            }
            else
            {
                Console.Write("\r\n");
            }
        }

        public static void afficheRecursif(string str, int idx = 0)
        {
            afficheRecursif(str.ToCharArray(), idx);
        }

        public static char askChar()
        {
            bool ok = false;
            char tmp = '\0';

            do
            {
                try
                {
                    tmp = Console.ReadKey().KeyChar;

                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Veuillez saisir des caractères SVP.");
                }
            }
            while (!ok);
            return tmp;
        }
    }
}

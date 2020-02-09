using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int taille;

            Console.WriteLine("Hello World!");
            try
            {
                taille = Int16.Parse(Console.ReadLine());
            } catch (FormatException)
            {
                Console.WriteLine("Tapez un entier !!!");
            }
            finally
            {
                Console.WriteLine("0+0 = TOTO");
            }
        }
    }
}

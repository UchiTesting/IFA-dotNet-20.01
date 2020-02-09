using System;

namespace _200128_Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo 4: Triangle d'étoiles.\n========\n");
            int nbEtoiles = 0;
            bool inputIsInt;
            bool validInput;
            int minLines = 3;
            int maxLines = 15;

            do
            {
                Console.Write(string.Format("Nombre de lignes (min: {0}, max: {1}): ",minLines,maxLines));
                inputIsInt = int.TryParse(Console.ReadLine(), out nbEtoiles);
                validInput = nbEtoiles <= maxLines && nbEtoiles >= minLines || !inputIsInt;

                if (validInput)

                {
                    for (int i = 0; i <= nbEtoiles; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\r\n");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please input an integer of 3 or greater!");
                    Console.ResetColor();
                }


            } while (!validInput);



        }
    }
}

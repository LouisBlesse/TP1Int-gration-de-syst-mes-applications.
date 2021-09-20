using System;

namespace ConsoleApplication1
{
    public class Exercice1
    {
        public static void Exo1()
        {
            Console.WriteLine("Exercice 1: Seulement les nombres impaires");

            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine("Table of "+i);
                for (var j = 1; j < 11; j++)
                {
                    if ((i * j) % 2 == 1)
                    {
                        Console.WriteLine(i+"*"+j+"="+i*j);
                    }
                    
                }
                Console.WriteLine('\n');
            }
            Exo1Part3();
        }

        public static void Exo1Part3()
        {
            Console.WriteLine("Exercice 1 partie 3");
            var number = AskUserForParameter();
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i+"*"+number+"="+i*number);
            }
        }

        public static int AskUserForParameter()
        {
            Console.WriteLine("Choisisez un chiffre entre 1 et 100");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
    }
}
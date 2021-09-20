using System;

namespace ConsoleApplication1
{
    public class Exercice3
    {
        public static void Exo3()
        {
            Console.WriteLine("Exercice 3: ");
            for (var i = -3; i <= 3; i++)
            {
                try
                {
                    Console.WriteLine(PowerFunction(i));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) -4);
        }
    }
}
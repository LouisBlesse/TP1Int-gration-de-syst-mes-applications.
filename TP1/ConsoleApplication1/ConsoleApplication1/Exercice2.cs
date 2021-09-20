using System;

namespace ConsoleApplication1
{
    public class Exercice2
    {
        public static void Exo2()
        {
            Console.WriteLine("Exercice 2:");
            Boolean check = true;
            for (var i = 1; i <= 1000; i++)
            {
                check = true;
                for (var j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    Console.WriteLine(i);
                }
            }

            Exo2Part2();
        }

        public static void Exo2Part2()
        {
            Console.WriteLine("Exercice 2 part 2:");
            var num2=1;
            var num1=0;
            var result = 0;

            while (num1 < 1000)
            {
                Console.WriteLine(result);
                result = num1 + num2;
                num2 = num1;
                num1 = result;
            }

            Exo2Part3();
        }
        
        public static void Exo2Part3()
        {
            Console.WriteLine("Exercice 2 part 3:");
            var result = 1;

            for (var num1=Exercice1.AskUserForParameter(); num1 > 0; num1--)
            {
                result = result * num1;
            }
            Console.WriteLine(result);
        }
    }
}
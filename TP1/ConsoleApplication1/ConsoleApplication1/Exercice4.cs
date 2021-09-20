using System;

namespace ConsoleApplication1
{
    public class Exercice4
    {
        public static void Exo4()
        {
            Console.WriteLine("Choisisez la largeur");
            int.TryParse(Console.ReadLine(), out var largeur);
            
            Console.WriteLine("Choisisez la hauteur");
            int.TryParse(Console.ReadLine(), out var hauteur);

            Exo4Buid(largeur, hauteur);
        }

        public static void Exo4Buid(int largeur,int hauteur)
        {
            for (int x = 0; x < hauteur; x++)
            {
                for (int y = 0; y < largeur; y++)
                {
                    if (x == 0 || x == hauteur-1)
                    {
                        if (y == 0 || y == largeur - 1)
                        {
                            Console.Write('0');
                        }
                        else
                        {
                            Console.Write('-');
                        }
                        
                    }
                    else if (y == 0 || y == largeur-1)
                    {
                        Console.Write('|');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                    
                }
                
                Console.WriteLine(' ');
            }
        }
    }
}
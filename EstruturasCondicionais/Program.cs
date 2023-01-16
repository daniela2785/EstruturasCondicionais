using System;

namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 200;

            // && (E ou AND) e || (OU/OR)
            //TRUE && TRUE -> true            //TRUE || TRUE -> true
            //FALSE && FALSE -> false         //FALSE || TRUE -> false
            //TRUE && FALSE -> false          //TRUE || FALSE -> false
            //FALSE && TRUE -> false          //FALSE || FALSE -> false

            // Entrar no jogo gratuitamente(TRUE)
            // LEVAR ALIMENTO(V) || LEVARBRINQUEDO(F) => ENTRAR NO JOGO


            if (a < b || a > c ) // SE
            {
                Console.WriteLine("É verdade");
            }
            else if (b >= c)
            {
                Console.WriteLine("Executou Elseif");
            }
            else //SE NÃO
            {
                Console.WriteLine("É mentira");
            }

        }
    }
}
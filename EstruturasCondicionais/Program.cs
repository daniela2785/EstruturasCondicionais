using System;

namespace EstruturasCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 2;

            if (10 > 20) // SE
            {
                Console.WriteLine("É verdade");
            }
            else if (20 >= 20)
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
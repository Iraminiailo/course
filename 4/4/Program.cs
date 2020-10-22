using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int stars = 4;
            do
            {
                Console.WriteLine("*");
                stars = stars - 1;
            }
            while (stars > 0);
            */





            /* int stars = 4;
            while (stars > 0)
            {
                Console.Write("*"); // звездочки в линию
                stars -= 1;
            }
            int stars = 4;
            while (stars > 0)
            {
                Console.Write("*\n"); // звездочки в столбик
                stars -= 1;
            }

            int stars = 4;
            while (stars > 0)
            {
                Console.Write("*\n"); // звездочки в столбик
                stars -= 1;
            }*/






            /*int stars = 2;
            while (stars > 0)
            {
                Console.Write("***"); // звездочки в прямоугольник
                stars --;
            }*/





            int x = 3;
            int y = 3;
            while (y > 0)
            {
                int stars = x;
                while (stars > 0)
                {
                    Console.Write("*");
                    stars--;
                }
                Console.WriteLine("\n");
                y--;
            }
            Console.WriteLine();


            /* for (int x = 10; x < 0; x--)
                Console.Write("*");*/

        
        }
    }
}

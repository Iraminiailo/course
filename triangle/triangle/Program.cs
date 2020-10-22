using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 6;
          
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
               

            for (int i = -1; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

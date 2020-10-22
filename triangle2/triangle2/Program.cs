using System;

namespace triangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 8;

            for (int i = 0; i < height; i++)
            {
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }


                Console.WriteLine();
            }
                
            


           
            
        }
    }
}

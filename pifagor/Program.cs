using System;

namespace pifagor
{ 
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 9; i++)
                if(i <= 1)
                {
                    Console.Write("    1");
                }
               else
                {
                Console.Write("  " + i);
                }
            Console.Write("\n");



            for (int j = 1; j <= 9; j++)

                if (j <= 1)
                {
                    Console.Write("    -");
                }
                else
                {
                    Console.Write("---");
                }

                    Console.Write("\n");

           


            for (int n = 1; n <= 9; n++)
            {
                Console.Write(n + "|");
                for (int a = 1; a <= 9; a++)
               
                {
                    int t = n * a;
                    if (t < 10)
                    {
                        Console.Write("  " + t);
                    }
                   
                    else
                    {
                        Console.Write(" " + t);
                    }

                }

                Console.Write("\n");

            }
            
            Console.ReadLine();

        }
    }
}

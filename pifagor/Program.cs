using System;

namespace pifagor
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter p");
            int p = int.Parse(Console.ReadLine());

            for (int i = m; i <= p; i++)
                if(i <= 1)
                {
                    Console.Write("    1");
                }
               else
                {
                Console.Write("  " + i);
                }
            Console.Write("\n");



            for (int j = m; j <= p; j++)

                if (j <= 1)
                {
                    Console.Write("    -");
                }
                else
                {
                    Console.Write("---");
                }

                    Console.Write("\n");




            for (int n = m; n <= p; n++)
            {
                Console.Write(n + "|");
                for (int a = m; a <= p; a++)

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
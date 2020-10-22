using System;

namespace romb
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int colsCnt = 1;
            for (int row = 0; row < n - 1; row++)
            {
                Console.Write(new string(' ', n - colsCnt));
                for (int col = 0; col < colsCnt; col++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
                colsCnt++;
            }
            for (int col = 0; col < n; col++)
            {
                Console.Write("**");
            }

            Console.WriteLine();

            colsCnt = n - 1;
            for (int row = 0; row < n - 1; row++)
            {
                Console.Write(new string(' ', n - colsCnt));
                for (int col = 0; col < colsCnt; col++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
                colsCnt--;
            }



        }
    }
}

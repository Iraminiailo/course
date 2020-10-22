using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int a;

                a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)

                {
                    Console.WriteLine("число четное");
                }
                else
                {
                    Console.WriteLine("число нечетное");
                }
                Console.ReadLine();
            }
        }
    }
}

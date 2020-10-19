using System;

namespace _5
{
    class Program
    {
        public static int func(int x)
        {
            int y;
            y = 4* (x - 3) * (x - 3) * (x - 3) * (x - 3) * (x - 3) * (x - 3) * - 7* (x - 3)*(x - 3)*(x - 3) + 2;
            return y;
        }
        static void Main(string[] args)
        {
            int x = 0, k = 0, res;
            Console.WriteLine("f(x) = 4*(x-3)^6 - 7*(x-3)^3 + 2 ");
            do
            {
                Console.Write("Введите число x: ");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            res = func(x);
            Console.WriteLine($"f({x}) = {res}");
        }
    }
}

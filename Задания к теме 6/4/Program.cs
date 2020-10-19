using System;

namespace _4
{
    class Program
    {
        public static int func(int x){
            int y;
            y = 3 * x * x * x * x * x * x - 6 * x * x - 7;
            return y;
        }
        static void Main(string[] args)
        {
            int x = 0, k = 0, res;
            Console.WriteLine("f(x) = 3x^6 - 6x^2 - 7 ");
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

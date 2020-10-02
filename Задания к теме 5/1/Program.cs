using System;

namespace _1
{
    class Program
    {
        public static double calc_RS(int x1, int y1, int x2, int y2)
        {
            double RS;
            RS = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));

            return RS;
        }
        
        static void Main(string[] args)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0, k = 0;
            double res;
            do
            {
                Console.Write("Введите координату x точки A: ");
                try
                {
                    x1 = Convert.ToInt32(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            k = 0;
            do
            {
                Console.Write("Введите координату y точки A: ");
                try
                {
                    y1 = Convert.ToInt32(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            k = 0;
            do
            {
                Console.Write("Введите координату x точки B: ");
                try
                {
                    x2 = Convert.ToInt32(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            k = 0;
            do
            {
                Console.Write("Введите координату y точки B: ");
                try
                {
                    y2 = Convert.ToInt32(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            res = calc_RS(x1, y1, x2, y2);
            Console.WriteLine(res);
        }
    }
}

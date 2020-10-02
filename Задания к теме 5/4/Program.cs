using System;

namespace _4
{
    class Program
    {
        public static int modul(int M)
        {
            if (M > 0)
            {
                return M;
            }
            else
            {
                return M * (-1);
            }
        }
        public static int calc_PR(int x1, int y1, int x2, int y2)
        {
            int PR, a , b;
            a = modul(x2 - x1);
            b = modul(y2 - y1);
            PR = 2 * (a + b);
            return PR;
        }
        public static int calc_PS(int x1, int y1, int x2, int y2)
        {
            int PR, a, b;
            a = modul(x2 - x1);
            b = modul(y2 - y1);
            PR = a*b;
            return PR;
        }
        static void Main(string[] args)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0, k, resS = 0, resP = 0;
            k = 0;
            do
            {
                Console.Write("Введите координату x1: ");
                try
                {
                    x1= Convert.ToInt32(Console.ReadLine());
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
                Console.Write("Введите координату y1: ");
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
                Console.Write("Введите координату x2: ");
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
                Console.Write("Введите координату y2: ");
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
            resP = calc_PR(x1, y1, x2, y2);
            resS = calc_PS(x1, y1, x2, y2);
            Console.WriteLine($"Перметр заданного прямоугольика {resP}");
            Console.WriteLine($"Площадь заданного прямоугльника {resS}");
        }
    }
}

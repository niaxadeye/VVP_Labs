using System;

namespace _5
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
        public static int dlin(int x, int y)
        {
            int dlin;
            dlin = modul(x - y);
            return dlin;
        }
        public static double calc_RS(int x1, int y1, int x2, int y2)
        {
            double RS;
            RS = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            return RS;
        }
        public static double calc_P(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double P, a, b, c;
            a = calc_RS(x1, y1, x2, y2);
            b = calc_RS(x1, y1, x3, y3);
            c = calc_RS(x2, y2, x3, y3);
            P = a + b + c;
            return P;
        }
        public static double calc_S(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double S, p, a , b ,c;
            a = calc_RS(x1, y1, x2, y2);
            b = calc_RS(x1, y1, x3, y3);
            c = calc_RS(x2, y2, x3, y3);
            p = calc_P(x1, y1, x2, y2, x3, y3)/2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
        static void Main(string[] args)
        {
            int x1= 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, k = 0;
            double S = 0, P = 0;
            do
            {
                Console.Write("Введите координату x1: ");
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
            k = 0;
            do
            {
                Console.Write("Введите координату x3: ");
                try
                {
                    x3 = Convert.ToInt32(Console.ReadLine());
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
                Console.Write("Введите координату y3: ");
                try
                {
                    y3 = Convert.ToInt32(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);
            P = calc_P(x1, y1, x2, y2, x3, y3);
            S = calc_S(x1, y1, x2, y2, x3, y3);
            if (S == 0)
            {
                Console.WriteLine("Такого треугольника не существует");
            }
            else
            {
                Console.WriteLine($"Периметр заданного треугольника равен {P}");
                Console.WriteLine($"Площадь заданного треугольника равна {S}");
            }
        }
    }
}

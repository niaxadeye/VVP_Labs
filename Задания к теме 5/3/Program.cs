using System;
using System.Reflection.Metadata.Ecma335;

namespace _3
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
        public static int calc_PR(int A, int B, int C)
        {
            int PR;
            PR = dlin(A, C) * dlin(B, C);
            return PR;
        }
        static void Main(string[] args)
        {
            int A = 0, B = 0, C = 0, k, res;
            k = 0;
            do
            {
                Console.Write("Введите координату точки A: ");
                try
                {
                    A = Convert.ToInt32(Console.ReadLine());
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
                Console.Write("Введите координату точки B: ");
                try
                {
                    B = Convert.ToInt32(Console.ReadLine());
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
            int k2 = 0;
            do
            {
                Console.Write("Введите координату точки C: ");
                try
                {
                    C = Convert.ToInt32(Console.ReadLine());
                    k = 1;
                    if ((C > A && C < B) || (C > B && C < A))
                    {
                        k2 = 1;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Точка C должна лежать между точек A и B, попробуйте снова");
                        Console.ResetColor();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0 || k2 == 0);
            res = calc_PR(A, B, C);
            Console.WriteLine($"AC*BC = {res}") ;

        }
    }
}

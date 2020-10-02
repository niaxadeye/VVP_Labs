using System;

namespace _1
{
    class Program
    {
        public static decimal modul(decimal M)
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
        public static decimal dlin(decimal x, decimal y)
        {
            decimal dlin;
            dlin = modul(x - y);
            return dlin;
        }
        static void Main(string[] args)
        {
            decimal A = 0, B = 0, C = 0, k = 0, AC, BC, sum;
            Console.WriteLine("Разделитель - запятая (пример 12,2)");
            do
            {
                Console.Write("Введите число A: ");
                try
                {
                    A = Convert.ToDecimal(Console.ReadLine());
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
                Console.Write("Введите число B: ");
                try
                {
                    B = Convert.ToDecimal(Console.ReadLine());
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
                Console.Write("Введите число C: ");
                try
                {
                    C = Convert.ToDecimal(Console.ReadLine());
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
            AC = dlin(A, C);
            BC = dlin(B, C);
            sum = AC + BC;
            Console.WriteLine($"Длина отрезка AC = {AC}");
            Console.WriteLine($"Длина отрезка BC = {BC}");
            Console.WriteLine($"Сумма отрезков AC и BC = {sum}");

        }
    }
}

using System;

namespace _3
{
    class Program
    {
        static decimal calc_SRAR(decimal a, decimal b)
        {
            decimal SRAR;
            SRAR = (a + b)/ 2;
            return SRAR;
        }
        static void Main(string[] args)
        {
            decimal a = 0, b = 0, k = 0, SRAR;
            Console.WriteLine("Разделитель - запятая (например 12,2)");
            do
            {
                Console.Write("Введите чсло a: ");
                try
                {
                    a = Convert.ToDecimal(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат");
                    Console.ResetColor();
                }
            } while (k == 0);

            k = 0;


            do
            {
                Console.Write("Введите число b: ");
                try
                {
                    b = Convert.ToDecimal(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат");
                    Console.ResetColor();
                }
            } while (k == 0);

            SRAR = calc_SRAR(a, b);
            Console.WriteLine($"Среднее арифметическое {a} и {b} = {SRAR}");
        }
    }
}

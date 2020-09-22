using System;

namespace _5
{
    class Program
    {
        public static decimal modul(decimal a) 
        {
            if( a > 0)
            {
                return a;
            }
            else
            {
                return a * (-1);
            }
        } 
        public static decimal F_sum(decimal a, decimal b)
        {
            decimal sum = a + b;
            return sum;
        }
        public static decimal F_raz(decimal a, decimal b)
        {
            decimal raz = a - b;
            return raz;
        }
        public static decimal F_proizv(decimal a, decimal b)
        {
            decimal proizv = a * b;
            return proizv;
        }
        public static decimal F_chastnoe(decimal a, decimal b)
        {
            decimal chastnoe = a / b;
            return chastnoe;
        }
        static void Main(string[] args)
        {
            decimal a = 0, b = 0;
            int k = 0;            
            Console.WriteLine("Разделитель - запятая (пример 12,2)");
            do
            {
                Console.Write("Введите число a: ");
                try
                {
                    a = Convert.ToDecimal(Console.ReadLine());
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
                Console.Write("Введите число b: ");
                try
                {
                    b = Convert.ToDecimal(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат данных");
                    Console.ResetColor();
                }
            } while (k == 0);

            decimal sum, raz, proizv, chastnoe;
            sum = F_sum(modul(a), modul(b));
            raz = F_raz(modul(a), modul(b));
            proizv = F_proizv(modul(a), modul(b));
            chastnoe = F_chastnoe(modul(a), modul(b));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.ResetColor();
            Console.WriteLine($"|a| + |b| =  {modul(a)} + {modul(b)} = {sum}");
            Console.WriteLine($"|a| - |b| = {modul(a)} - {modul(b)} = {raz}");
            Console.WriteLine($"|a| * |b| = {modul(a)} * {modul(b)} = {proizv}");
            Console.WriteLine($"|a| / |b| = {modul(a)} / {modul(b)} = {chastnoe}");
        }
    }
}

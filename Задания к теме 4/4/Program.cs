using System;

namespace _4
{
    class Program
    {
        public static decimal calcl_Fsum(decimal a, decimal b)
        {
            decimal Fsum;
            Fsum = a * a + b * b;
            return Fsum;
        }
        public static decimal calcl_Fraz(decimal a, decimal b)
        {
            decimal Fraz;
            Fraz = a * a - b * b;
            return Fraz;
        }
        public static decimal calcl_Fproizv(decimal a, decimal b)
        {
            decimal Fsum;
            Fsum = a * a * b * b;
            return Fsum;
        }
        public static decimal calcl_Fchasnoe(decimal a, decimal b)
        {
            decimal Fchasnoe;
            Fchasnoe = (a * a) / (b * b);
            return Fchasnoe;
        }
        static void Main(string[] args)
        {
            int k = 0;
            decimal a =0 , b = 0, Fsum, Fraz, Fproizv, Fchasnoe;
            Console.WriteLine("Разделитель - запятая (например 12,2)");
            do {
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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.ResetColor();

            Fsum = calcl_Fsum(a, b);
            Fraz = calcl_Fraz(a, b);
            Fproizv = calcl_Fproizv(a, b);
            Fchasnoe = calcl_Fchasnoe(a, b);

            Console.WriteLine($"a^2 + b^2 = {a * a} + {b * b} = {Fsum}");
            Console.WriteLine($"a^2 - b^2 = {a * a} - {b * b} = {Fraz}");
            Console.WriteLine($"a^2 * b^2 = {a * a} * {b * b} = {Fproizv}");
            Console.WriteLine($"a^2 / b^2 = {a * a} / {b * b} = {Fchasnoe}");
        }
    }
}

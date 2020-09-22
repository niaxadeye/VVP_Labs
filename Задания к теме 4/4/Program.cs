using System;
using System.Text;

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
            Console.Write("Введите число a: ");
            do {
                try
                {
                    a = Convert.ToDecimal(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.Write("Введите чсло a: ");
                }
            } while (k == 0);

            k = 0;

            Console.Write("Введите число b: ");
            do
            {
                try
                {
                    b = Convert.ToDecimal(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.Write("Введите число b: ");
                }
            } while (k == 0);

            Console.WriteLine($"a = {a} b = {b}");

            Fsum = calcl_Fsum(a, b);
            Fraz = calcl_Fraz(a, b);
            Fproizv = calcl_Fproizv(a, b);
            Fchasnoe = calcl_Fchasnoe(a, b);

            Console.WriteLine($"a^2 + b^2 = {Fsum}");
            Console.WriteLine($"a^2 - b^2 = {Fraz}");
            Console.WriteLine($"a^2 * b^2 = {Fproizv}");
            Console.WriteLine($"a^2 / b^2 = {Fchasnoe}");
        }
    }
}

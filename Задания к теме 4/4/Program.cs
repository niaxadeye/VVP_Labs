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
            decimal a, b, Fsum, Fraz, Fproizv, Fchasnoe;
            a = Convert.ToDecimal(Console.ReadLine());
            b = Convert.ToDecimal(Console.ReadLine());
            Fsum = calcl_Fsum(a, b);
            Fraz = calcl_Fraz(a, b);
            Fproizv = calcl_Fproizv(a, b);
            Fchasnoe = calcl_Fchasnoe(a, b);
            Console.WriteLine(Fsum);
            Console.WriteLine(Fraz);
            Console.WriteLine(Fproizv);
            Console.WriteLine(Fchasnoe);
        }
    }
}

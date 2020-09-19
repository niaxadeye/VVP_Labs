using System;

namespace _3
{
    class Program
    {
        static decimal calc_SRAR(decimal a, decimal b)
        {
            decimal SRAR;
            SRAR = (a + b)/ 2;
            return (decimal)SRAR;
        }
        static void Main(string[] args)
        {
            decimal a, b, SRAR;
            a = Convert.ToDecimal(Console.ReadLine());
            b = Convert.ToDecimal(Console.ReadLine());
            SRAR = calc_SRAR(a, b);
            Console.WriteLine(SRAR);
        }
    }
}

using System;

namespace _5
{
    class Program
    {
        public static double Fact2(double N)
        {
            double res = 0;
            double K;
            if (N%2 == 0)
            {
                res = 1;
                K = 2;
                while(N > 0)
                {
                    res = res * K;
                    K = K + 2;
                    N--;
                }
                return res;
            }
            else
            {
                res = 1;
                K = 1;
                while (N > 0)
                {
                    res = res * K;
                    K = K + 2;
                    N--;
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{N}!! = {Fact2(N)}");
        }
    }
}

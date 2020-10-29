using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N > 0: ");
            double N = Convert.ToDouble(Console.ReadLine());
            N = N * 0.1 + 1;
            double sum = 1.1;
            for(double i = 1.2; i <= N; i+= 0.1){
                sum = sum* i;
            }
            Console.WriteLine(sum);
        }
    }
}

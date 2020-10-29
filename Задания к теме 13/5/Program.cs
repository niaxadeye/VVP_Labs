using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A : ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            double temp;
            for (double i = 0; i <= N; i++)
            {
                temp = Math.Pow(A, i);
                sum = sum + Math.Pow(-1,i)* temp;
            }
            Console.WriteLine(sum);
        }
    }
}

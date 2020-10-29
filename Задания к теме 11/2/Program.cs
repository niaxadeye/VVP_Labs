using System;
using System.ComponentModel.DataAnnotations;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            int prmax;
            int max = A;
            if (B >= max)
            {
                prmax = max;
                max = B;
            }
            else
            {
                prmax = B;
            }
            if(C >= max)
            {
                prmax = max;
                max = C;
            }else if(C > prmax)
            {
                prmax = C;
            }
            Console.WriteLine($"Сумма двух наибольших чисел: {max + prmax}");
        }
    }
}

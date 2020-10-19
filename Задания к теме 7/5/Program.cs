using System;

namespace _5
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Дано линейное кравнение вида A*x + B = 0");
            Console.Write("Введите коэффицент A не равный нулю: ");
            int A = Convert.ToInt32(Console.ReadLine());
            if(A == 0)
            {
            Console.Write("A не может равняться нулю");
                return 0;
            }
            Console.Write("Введите коэффицент B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            double x = B * (-1) / (double)A;
            Console.Write($"При A = {A} и B = {B}, x = {x}");
            return 0;
        }
    }
}

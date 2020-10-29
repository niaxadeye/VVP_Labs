using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A != 0)
            {
                if (A > 0)
                {
                    Console.Write("Положительное ");
                }
                if (A < 0)
                {
                    Console.Write("Отрицательное ");
                }
                if (A % 2 == 0)
                {
                    Console.Write("чётное число");
                }
                if (A % 2 != 0)
                {
                    Console.Write("нечётное число");
                }
            }
            else
            {
                Console.WriteLine("Нулевое число");
            }


        }
    }
}

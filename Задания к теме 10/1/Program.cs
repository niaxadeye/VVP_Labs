using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A > 2 && B <= 3)
            {
                Console.WriteLine("Высказывание A > 2 и B <= 3 истинно");
            }
            else
            {
                Console.WriteLine("Высказывание A > 2 и B <= 3 ложно");
            }
        }
    }
}

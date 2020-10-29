using System;
using System.Runtime.InteropServices;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число P: ");
            Double P = Convert.ToDouble(Console.ReadLine());
            double vkld = 1000;
            int mss = 0;
            while(vkld < 1100)
            {
                vkld *= (1 + P / 100);
                mss++;
            }
            Console.WriteLine($"Итоговый размер вклада {vkld}");
            Console.WriteLine($"Найденного кол-во месяцев {mss}");

        }
    }
}

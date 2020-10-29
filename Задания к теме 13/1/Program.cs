using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену в руб. за 1 кг конфет: ");
            int price = Convert.ToInt32(Console.ReadLine());
            for(double i = 0.1; i <= 1.0; i += 0.1)
            {
                Console.WriteLine($"{Math.Round(i, 1)} кг конфет стоит {price * Math.Round(i,1)} руб.");
            }
        }
    }
}

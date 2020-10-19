using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите скорость первого автомобиля в км/ч: ");
            int v1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите скорость второго автомобиля в км/ч: ");
            int v2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите расстояние между этими автомобилями в км: ");
            int s = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Введите время в часах: ");
            int t = Convert.ToInt32(Console.ReadLine());

            int S = s + v1 * t + v2 * t;

            Console.WriteLine($"Расстояние между двумя этими автомобилями через {t} часов - {S}");

        }
    }
}

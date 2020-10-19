using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите значение угла в градусах: ");
            a = Convert.ToInt32(Console.ReadLine());
            double rad = a * 3.14 / 180;
            Console.WriteLine($"{a} градусов = {rad} радиан");
        }
    }
}

using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a*a == b*b + c * c || b*b == a*a + c*c || c*c == a*a + b*b)
            {
                Console.WriteLine("Высказывание: \"Треугольник со сторонами a, b, c является прямоугольным \" - истинно");
            }
            else
            {
                Console.WriteLine("Высказывание: \"Треугольник со сторонами a, b, c является прямоугольным \" - ложно");
            }
        }
    }
}

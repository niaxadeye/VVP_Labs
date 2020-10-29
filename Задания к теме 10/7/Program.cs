using System;

namespace _7
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

            if(a < b + c && b < b + a && c < a + b)
            {
                Console.WriteLine("Высказывание: \" Существует треугольник со сторонами a, b, c \" - истинно");
            }
            else{
                Console.WriteLine("Высказывание: \" Существует треугольник со сторонами a, b, c \" - ложно");
            }
        }
    }
}

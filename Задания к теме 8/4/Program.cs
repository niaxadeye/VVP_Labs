using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int D = num / 10;
            int E = num % 10;
            int res = E * 10 + D;
            Console.WriteLine($"Число полученное при перестановке чисел: {res}");
        }
    }
}

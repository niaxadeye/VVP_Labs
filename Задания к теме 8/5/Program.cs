using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int S = num / 100;
            int NN = num % 100;
            if (NN < 10)
            {
                int res = NN * 10 + S;
            Console.Write($"Полученное число: 0{res}");
            }
            else
            {
            int res = NN * 10 + S;
            Console.Write($"Полученное число: {res}");
            }

        }
    }
}

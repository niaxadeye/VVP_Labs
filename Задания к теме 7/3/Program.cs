using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, A, Y;
            Console.Write("Введите A - кол-во конфет в кг: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите X -  цену в руб за {A} кг: ");
            X = Convert.ToInt32(Console.ReadLine());
            double rkg = X / A;
            Console.WriteLine($"1 кг конфет стоит {rkg} руб");
            Console.Write("Введите Y кг: ");
            Y = Convert.ToInt32(Console.ReadLine());
            double Ykg = Y * rkg;
            Console.WriteLine($"{Y} кг конфет стоит - {Ykg} руб");
        }
    }
}

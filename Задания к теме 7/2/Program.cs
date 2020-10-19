using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите значение угла в радианах: ");
            a = Convert.ToInt32(Console.ReadLine());
            double gr = a *180/3.14;
            Console.WriteLine($"{a} радиан = {gr} градусов");
        }
    }
}

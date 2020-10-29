using System;
using System.ComponentModel.DataAnnotations;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите точку A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите точку B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите точку C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            int min = Math.Abs(A - B);
            if(Math.Abs(A - C) < min)
            {
                Console.WriteLine("Точка С ближе к точке A, чем точка B");
            }
            else
            {
                Console.WriteLine("Точка B ближе к точке A, чем точка C");
            } 
        }
    }
}

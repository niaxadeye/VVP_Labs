using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            if ((A / 100 > (A % 100) / 10 && (A % 100) / 10 > A % 10) || (A / 100 < (A % 100) / 10 && (A % 100) / 10 < A % 10))
            {
                Console.WriteLine("Высказывание: \"Цифры данного числа образуют возрастающую или убывающую последовательность\" - истинно ");
            }
            else
            {
                Console.WriteLine("Высказывание: \"Цифры данного числа образуют возрастающую или убывающую последовательность\" - ложно ");
            }
        }
    }
}

using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            if(A > 9 && A < 100 && A%2 == 0)
            {
                Console.WriteLine($"Высказывание: \"Данное число является четным двузначны\" - истинно");
            }
            else
            {
                Console.WriteLine($"Высказывание: \"Данное число является четным двузначны\" - ложно");
            }
        }
    }
}

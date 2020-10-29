using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            if(A%2 == 0)
            {
                Console.Write("Чётное ");
            }
            else
            {
                Console.Write("Нечётное ");
            }
            if(A/100 > 0)
            {
                Console.Write("трёхзначное число");
            }else if(A/10 > 0)
            {
                Console.Write("двузначное число");
            }
            else
            {
                Console.Write("однозначное число");
            }
            
            
        }
    }
}

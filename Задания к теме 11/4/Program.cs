using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if(x > 0)
            {
                if(y > 0)
                {
                    Console.WriteLine("Точка лежит в 1 четверти");
                }
                else
                {
                    Console.WriteLine("Точка лежит в 4 четверти");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("Точка лежит во 2 четверти");
                }
                else
                {
                    Console.WriteLine("Точка лежит в 3 четверти");
                }
            }
        }
    }
}

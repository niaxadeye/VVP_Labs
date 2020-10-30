using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите кол-во строк в матрице R: ");
            int R = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов в матрице C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            int[,] Matrix = new int[R, C];
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Matrix[i, j] = rand.Next(30) + 1;
                    Console.Write($"{Matrix[i, j]} ");
                }
                Console.Write("\n");
            }

            Console.Write("Введите номер строки K: ");
            int K = Convert.ToInt32(Console.ReadLine());
            int prz = 1;
            for(int i = 0; i < C; i++)
            {
                prz *= Matrix[K-1, i];
            }
            Console.WriteLine($"Произведение элементов {K}-й строки данной матрицы = {prz}");
        }
    }
}

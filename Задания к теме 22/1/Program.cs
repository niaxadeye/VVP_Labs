using System;

namespace _1
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
            for(int i = 0; i < R; i++)
            {
                int max = Matrix[i, 0];
                int min = Matrix[i, 0];
                int max_j = 0;
                int min_j = 0;
                for(int j = 1; j < C; j++)
                {
                    if (Matrix[i, j] > max) { max = Matrix[i, j]; max_j = j; }
                    if (Matrix[i, j] < min) { min = Matrix[i, j]; min_j = j; }
                }
                int temp = Matrix[i, max_j];
                Matrix[i, max_j] = Matrix[i, min_j];
                Matrix[i, min_j] = temp;
            }

            Console.WriteLine("Изменённая матрица");
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write($"{Matrix[i, j]} ");
                }
                Console.Write("\n");
            }
        }
    }
}

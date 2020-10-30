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
            int max = Matrix[0, 0];
            int min = Matrix[0, 0];
            int max_C = 0;
            int min_C = 0;
            for(int i = 0; i < C; i++)
            {
                for(int j = 1; j < R; j++)
                {
                    if (Matrix[j,i] > max)
                    {
                        max = Matrix[j, i];
                        max_C = i;
                    }
                    if (Matrix[j, i] < min)
                    {
                        min = Matrix[j, i];
                        min_C= i;
                    }
                }
            }
            for(int i = 0; i < R; i++)
            {
                int temp = Matrix[i, min_C];
                Matrix[i, min_C] = Matrix[i, max_C];
                Matrix[i, max_C] = temp;
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

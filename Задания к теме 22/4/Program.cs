using System;

namespace _4
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
            for(int i = 0; i < C; i++)
            {
                for (int j = i+1; j < C; j++)
                {
                    if (Matrix[0,i] > Matrix[0, j])
                    {
                        for(int k = 0; k < R; k ++)
                        {
                            int temp = Matrix[k, j];
                            Matrix[k, j] = Matrix[k, i];
                            Matrix[k, i] = temp;
                        }
                    }
                }
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

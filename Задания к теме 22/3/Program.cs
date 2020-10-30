using System;

namespace _3
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

            for(int i = 0; i < R/2; i++)
            {
                for(int j = 0; j < C/2; j++)
                {
                    int temp = Matrix[i + R / 2, j + C / 2];
                    Matrix[i + R / 2, j + C / 2] = Matrix[i, j];
                    Matrix[i, j] = temp;
                }
            }
            Console.WriteLine("Изменённый массив");
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

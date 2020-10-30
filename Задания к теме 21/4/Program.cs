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

            int[] Ksr = new int[C];
            for(int i = 0; i < C; i++)
            {
                double sum = 0;
                for(int j = 0; j < R; j++)
                {
                    sum += Matrix[j, i];
                }
                double sr = sum / (double)R;
                for (int j = 0; j < R; j++)
                {
                    if (Matrix[j, i] > sr)
                    {
                        Ksr[i]++;
                    }
                }
                Console.WriteLine($"Количество элементов, больших среднего арифметического всех элементов {i+1} столбца: {Ksr[i]}");
            }
        }
    }
}

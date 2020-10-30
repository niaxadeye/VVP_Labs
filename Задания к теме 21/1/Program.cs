using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Введите порядой квадратной матрицы M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] Matrix = new int[M, M];
            for (int i = 0; i < M; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    Matrix[i, j] = rand.Next(30) + 1;
                    Console.Write($"{Matrix[i,j]} ");
                }
                Console.Write("\n");
            }
            int kray = 0;
            int step = 0;
            int N = M;
            while (N >= 3)
            {
                for (int i = kray; i < M - kray  - 1; i++)  
                {
                    Console.WriteLine(Matrix[step , i]);
                }
                for (int i = kray; i < M - kray - 1; i++)
                {
                    Console.WriteLine(Matrix[i, M - step - 1]);
                }
                for (int i = M - 1 - kray; i > kray; i--)
                {
                    Console.WriteLine(Matrix[M - step - 1, i]);
                }
                for (int i = M - 1 - kray; i > kray; i--)
                {
                    Console.WriteLine(Matrix[i, step]);
                }
                step++;
                kray++;
                N--;
            }
            Console.WriteLine(Matrix[M/2,M/2]);


        }
    }
}

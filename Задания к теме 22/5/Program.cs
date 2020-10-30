using System;

namespace _5
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
            for(int i = 1; i <= R; i++)
            {
                int sum = 0;
                for(int j = 0; j < i; j++)
                {
                    sum+= Matrix[R - i + j,  j];
                    
                }
                Console.WriteLine(sum);

            }
            for (int i = R-1; i > 0 ; i--)
            {
                int sum = 0;
                for (int j = 0; j < i; j++)
                {
                    sum += Matrix[j, R - i + j];

                }
                Console.WriteLine(sum);
            }
        }
    }
}

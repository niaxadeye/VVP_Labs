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
            int flag = 0;
            for(int i = 0; i < C; i++)
            {
                int k = 0;
                for (int j = 0; j < R; j++)
                {
                    if(Matrix[j,i] %2 != 0)
                    {
                        k++;
                    }
                }
                if (k == R && flag == 0)
                {
                    Console.WriteLine($"Первый столбец содержащий точько нечётные числа: {i+1}");
                    flag = 1;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine(0);
            }
        }
    }
}

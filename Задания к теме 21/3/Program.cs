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
            int minprzv = 0;
            int index = 0;
            int flag = 0;
            int przv = 1;
            for(int i = 0; i < C; i++)
            {
                przv = 1;
                for(int j = 0; j < R; j++)
                {
                    przv *= Matrix[j, i];
                }
                if (przv < minprzv && flag != 0)
                {
                    minprzv = przv;
                    index = i + 1;
                }
                if (flag == 0)
                {
                    minprzv = przv;
                    index = i + 1;
                    flag = 1;
                }
               
            }
            Console.WriteLine($"Номер столбца с наименьшим произведением элементов - {index}");
            Console.WriteLine($"Значение наименьшего произведения = {minprzv}");
        }
    }
}

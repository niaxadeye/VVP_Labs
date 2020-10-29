using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите перывй член A : ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель D: ");
            int D = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рвзмер массива N : ");
            int N = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[N];
            for(int i = 0; i < N; i++)
            {
                arr[i] = (double)A * Math.Pow((double)D, (double)i);
                Console.WriteLine($"arr[{i}] = {arr[i]}") ;
            }
        }
    }
}

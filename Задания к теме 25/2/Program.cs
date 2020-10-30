using System;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)   
        {
            
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число K : ");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите название файла: ");
            string Path = @"D:\Политех\Введение в программирование\VVP_Labs\Задания к теме 25\2\"+Console.ReadLine() +".txt";
            StreamWriter file = new StreamWriter(Path, true, System.Text.Encoding.Default);
                    
            for( int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++) {
                            file.Write("*");
                }
             file.WriteLine();
            }
                
            Console.WriteLine("Запись выполнена");
            
        }
    }
}

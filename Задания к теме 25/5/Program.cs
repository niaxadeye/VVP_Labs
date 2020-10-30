using System;
using System.IO;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = File.ReadAllText(@"D:\Политех\Введение в программирование\VVP_Labs\Задания к теме 25\5\file.txt");
            int ans = 0;
            for(int i = 0; i < file.Length-5; i++)
            {
                if(file[i] == ' ' && file[i+1] == ' ' && file[i+2] == ' ' && file[i+3] == ' ' && file[i+4] == ' ')
                {
                    ans += 1;
                }
            }
            Console.WriteLine($"Кол-во абзацев в данном файле: {ans}");
        }
    }
}

using System;
using System.IO;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = File.ReadAllText(@"D:\Политех\Введение в программирование\VVP_Labs\Задания к теме 25\3\file1.txt");
            StreamWriter sw = new StreamWriter(@"D:\Политех\Введение в программирование\VVP_Labs\Задания к теме 25\3\file1.txt");
            string file2 = File.ReadAllText(@"D:\Политех\Введение в программирование\VVP_Labs\Задания к теме 25\3\file2.txt");
            sw.Write(file2);
            sw.WriteLine();
            sw.Write(file1);
            sw.Close(); 
            Console.WriteLine("Запись выполнена");
        }
    }
}

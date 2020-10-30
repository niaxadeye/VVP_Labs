using System;
using System.IO;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = File.ReadAllText(@"D:\Политех\Введение в программирование\VVP_Labs\Задания к теме 25\4\file.txt");
            file = String.Join(" ", file.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            StreamWriter sw = new StreamWriter(@"D:\Политех\Введение в программирование\VVP_Labs\Задания к теме 25\4\file.txt");
            sw.Write(file);
            sw.Close();
            Console.WriteLine("Запись выполнена");
        }
    }
}

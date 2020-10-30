using System;
using System.IO;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Политех\\Введение в программирование\\Задания.txt";

            Console.WriteLine(Path.GetFileNameWithoutExtension(path));

        }
    }
}

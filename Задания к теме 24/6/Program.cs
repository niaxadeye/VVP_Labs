using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Политех\\Введение в программирование\\Задания.txt";

            String[] dir = path.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(dir[dir.Length - 2]);
        }
    }
}

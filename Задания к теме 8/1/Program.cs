using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер файла в байтах: ");
            int bytes = Convert.ToInt32(Console.ReadLine());
            int kb = bytes / 1024;
            Console.WriteLine($"Файл размером {bytes} байтов занимает {kb} полных килобайтов");
            
        }
    }
}

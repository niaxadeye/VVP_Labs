using System;
using System.IO;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Политех\Введение в программирование\VVP_Labs\Задания к теме 25\1\text_1.txt";
            int i = 0;
            
            string FF = "";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    FF += line;
                }
            }
            while (FF[i] != ' ')
            {
                i++;
            }
            i++;
            Console.WriteLine(FF.Remove(0, i));
        }
    }
}

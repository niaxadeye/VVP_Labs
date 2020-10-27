using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер некоторого года: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int res = year / 100 + 1;
            if( year % 100 == 0)
            {
                res = res - 1;
            }
            Console.Write($"Номер столетия: {res}");

        }
    }
}

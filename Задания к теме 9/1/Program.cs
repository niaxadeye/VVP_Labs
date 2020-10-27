using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во секунд прошедших с начала суток: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            int res = sec % 60;
            Console.WriteLine($"{res} секунды/секунд прошло с начала последней минуты");
        }
    }
}

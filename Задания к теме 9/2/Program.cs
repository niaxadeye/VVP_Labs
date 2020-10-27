using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня в диапазоне 1-365: ");
            int day = Convert.ToInt32(Console.ReadLine());
            int num = day % 7;
            switch (num)
            {
                case 1:
                    Console.WriteLine("Это понедельник");
                    break;
                case 2:
                    Console.WriteLine("Это вторник");
                    break;
                case 3:
                    Console.WriteLine("Это среда");
                    break;
                case 4:
                    Console.WriteLine("Это четверг");
                    break;
                case 5:
                    Console.WriteLine("Это пятница");
                    break;
                case 6:
                    Console.WriteLine("Это суббота");
                    break;
                case 0:
                    Console.WriteLine("Это воскресенье");
                    break;
            }
        }
    }
}

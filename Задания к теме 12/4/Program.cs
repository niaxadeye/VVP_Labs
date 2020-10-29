using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A (от 100 до 999): ");
            int A = Convert.ToInt32(Console.ReadLine());
            switch (A / 100)
            {
                case 1:
                    Console.Write("Сто ");
                    break;
                case 2:
                    Console.Write("Двести ");
                    break;
                case 3:
                    Console.Write("Триста ");
                    break;
                case 4:
                    Console.Write("Четыреста ");
                    break;
                case 5:
                    Console.Write("Пятьсот ");
                    break;
                case 6:
                    Console.Write("Шестьсот ");
                    break;
                case 7:
                    Console.Write("Семьсот ");
                    break;
                case 8:
                    Console.Write("Восемьсот ");
                    break;
                case 9:
                    Console.Write("Девятьсот ");
                    break;
            }
            if ((A % 100) / 10 == 1)
                switch (A % 100)
                {
                    case 10:
                        Console.Write("десять\n");
                        break;
                    case 11:
                        Console.Write("одинадцать\n");
                        break;
                    case 12:
                        Console.Write("двенадцать\n");
                        break;
                    case 13:
                        Console.Write("тринадцать\n");
                        break;
                    case 14:
                        Console.Write("четырнадцать\n");
                        break;
                    case 15:
                        Console.Write("пятнадцать\n");
                        break;
                    case 16:
                        Console.Write("шестнадцать\n");
                        break;
                    case 17:
                        Console.Write("семнадцать\n");
                        break;
                    case 18:
                        Console.Write("восемнадцать\n");
                        break;
                    case 19:
                        Console.Write("девятнадцать\n");
                        break;
                }
            else
            {
                switch ((A % 100) / 10)
                {
                    case 2:
                        Console.Write("двадцать ");
                        break;
                    case 3:
                        Console.Write("тридцать ");
                        break;
                    case 4:
                        Console.Write("сорок ");
                        break;
                    case 5:
                        Console.Write("пятьдесят ");
                        break;
                    case 6:
                        Console.Write("шестьдесят ");
                        break;
                    case 7:
                        Console.Write("семьдесят ");
                        break;
                    case 8:
                        Console.Write("восемьдесят ");
                        break;
                    case 9:
                        Console.Write("девяносто ");
                        break;
                }

                switch (A % 10)
                {
                    case 1:
                        Console.Write("один\n");
                        break;
                    case 2:
                        Console.Write("два\n");
                        break;
                    case 3:
                        Console.Write("три\n");
                        break;
                    case 4:
                        Console.Write("четыре\n");
                        break;
                    case 5:
                        Console.Write("пять\n");
                        break;
                    case 6:
                        Console.Write("шесть\n");
                        break;
                    case 7:
                        Console.Write("семь\n");
                        break;
                    case 8:
                        Console.Write("восемь\n");
                        break;
                    case 9:
                        Console.Write("девять\n");
                        break;
                }
            }
         }
    }
}

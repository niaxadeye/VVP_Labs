using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер года: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Год ");

            switch ((year) % 10)
            {
                case 0:
                case 1:
                    Console.Write("бел");
                    break;
                case 2:
                case 3:
                    Console.Write("черн");
                    break;
                case 4:
                case 5:
                    Console.Write("зелён");
                    break;
                case 6:
                case 7:
                    Console.Write("красн");
                    break;
                case 8:
                case 9:
                    Console.Write("жёлт");
                    break;
            }

            switch ((year + 1) % 5)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 9:
                case 10:
                case 11:
                    Console.Write("ой ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("ого ");
                    break;
            }

            switch ((year + 8) % 12)
            {
                case 0:
                    Console.Write("крысы\n");
                    break;
                case 1:
                    Console.Write("коровы\n");
                    break;
                case 2:
                    Console.Write("тигра\n");
                    break;
                case 3:
                    Console.Write("зайца\n");
                    break;
                case 4:
                    Console.Write("дракона\n");
                    break;
                case 5:
                    Console.Write("змеи\n");
                    break;
                case 6:
                    Console.Write("лошади\n");
                    break;
                case 7:
                    Console.Write("овцы\n");
                    break;
                case 8:
                    Console.Write("обезьяны\n");
                    break;
                case 9:
                    Console.Write("курицы\n");
                    break;
                case 10:
                    Console.Write("собаки\n");
                    break;
                case 11:
                    Console.Write("свиньи\n");
                    break;
            }
        }
    }
}

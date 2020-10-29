using System;
using System.Text;

namespace _3
{
    class Program
    {
        static string f(int n)
        {
            if (n < 10 || n > 40)
                return "Число должно быть между 10 и 40";
            int dec = n / 10;
            int unit = n % 10;
            StringBuilder sb = new StringBuilder();

            if (n >= 10 && n <= 20 || n == 20 || n == 30 || n == 40)
            {
                switch (n)
                {
                    case 10:
                        sb.Append("Десять ");
                        break;
                    case 11:
                        sb.Append("Одиннадцать ");
                        break;
                    case 12:
                        sb.Append("Двенадцать ");
                        break;
                    case 13:
                        sb.Append("Тринадцать ");
                        break;
                    case 14:
                        sb.Append("Четырнадцать ");
                        break;
                    case 15:
                        sb.Append("Пятнадцать ");
                        break;
                    case 16:
                        sb.Append("Шестнадцать ");
                        break;
                    case 17:
                        sb.Append("Семнадцать ");
                        break;
                    case 18:
                        sb.Append("Восемнадцать ");
                        break;
                    case 19:
                        sb.Append("Девятнадцать ");
                        break;
                    case 20:
                        sb.Append("Двадцать ");
                        break;
                    case 30:
                        sb.Append("Дридцать ");
                        break;
                    case 40:
                        sb.Append("Сорок ");
                        break;
                }
                sb.Append("учебных заданий");
                return Convert.ToString(sb);
            }
            else
            {
                switch (dec)
                {
                    case 2:
                        sb.Append("Двадцать ");
                        break;
                    case 3:
                        sb.Append("Тридцать ");
                        break;
                    case 4:
                        sb.Append("Сорок ");
                        break;
                }
                switch (unit)
                {
                    case 1:
                        sb.Append("одно ");
                        break;
                    case 2:
                        sb.Append("два ");
                        break;
                    case 3:
                        sb.Append("три ");
                        break;
                    case 4:
                        sb.Append("четыре ");
                        break;
                    case 5:
                        sb.Append("пять ");
                        break;
                    case 6:
                        sb.Append("шесть ");
                        break;
                    case 7:
                        sb.Append("семь ");
                        break;
                    case 8:
                        sb.Append("восемь ");
                        break;
                    case 9:
                        sb.Append("девять ");
                        break;
                }
                if (unit == 1)
                    sb.Append("учебное задание");
                else
                    sb.Append("учебных заданий");
                return Convert.ToString(sb);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число A (в диапазоне от 10 до 40): ");
            int A = Convert.ToInt32(Console.ReadLine());
            string zd = f(A);
            Console.WriteLine(zd);
        }
    }
}

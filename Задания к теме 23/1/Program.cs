using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ С: ");
            char C = Convert.ToChar(Console.ReadLine());

            Console.Write("Предыдущий символ: " + Convert.ToChar(C - 1));
            Console.WriteLine(" | Следующий символ: " + Convert.ToChar(C + 1));
        }
    }
}

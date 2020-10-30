using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.Write("Введите символ: ");
            c = Convert.ToChar(Console.ReadLine());
            char[] s;
            Console.Write("Введите строку: ");
            s = Console.ReadLine().ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    int size = s.Length + 1;
                    Array.Resize(ref s, size);
                    for (int j = s.Length - 2; j >= i; j--)
                    {
                        s[j + 1] = s[j];
                    }
                    i++;
                }

            }
            string result = new string(s);
            Console.WriteLine($"Новая строка: {result} ");
        }
    }
}

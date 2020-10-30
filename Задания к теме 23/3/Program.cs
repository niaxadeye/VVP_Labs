using System;
using System.Security.Cryptography;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку S: ");
            string S1 = Console.ReadLine();
            int ans = 0;
            for (int i = 0; i < S1.Length; i++)
            {
                if (S1[i] >= 'a' && S1[i] <= 'z')
                {
                    ans += 1;
                }
            }
            Console.WriteLine($"Кол-во прописных латинских букв в строке S: {ans} ");
        }
    }
}
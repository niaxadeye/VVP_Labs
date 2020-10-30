using System;
using System.IO.Pipes;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string S = Console.ReadLine();
            int temp = 0;
            int ans = 0;
            for(int i = 0; i < S.Length; i++)
            {
                if(S[i] != ' ')
                {
                    temp++;
                }
                else
                {
                    if (temp > 0)
                    {
                        ans++;
                    }
                    temp = 0;
                }
                if(i == S.Length - 1 && temp > 0)
                {
                    ans++;
                }
            }
            Console.WriteLine($"Кол-во слов в строке: {ans}");
        }
    }
}

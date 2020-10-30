using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку S: ");
            string S = Console.ReadLine();
            string S1 = "";
            int k = -10000;
            for(int i = 0; i < S.Length - 1; i++)
            {
                if (S[i] == ' ')
                {
                    if (i - 1 != k)
                    {
                        S1 += S[i - 1];
                    }
                    k = i + 1;
                    S1 += S[i+1];
                }
            }
            Console.WriteLine(S1);
        }
    }
}

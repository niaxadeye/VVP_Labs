using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string S = Console.ReadLine();
            int temp = 0;
            int ans = 0;
            int flag = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != ' ')
                {
                    temp++;
                }
                else
                {
                    if (temp > 0 && temp < ans && flag != 0)
                    {
                        ans = temp;
                    }
                    if (flag == 0)
                    {
                        ans = temp;
                        flag = 1;
                    }
                    
                    temp = 0;
                }
                if (i == S.Length - 1 && temp > 0 && temp < ans && flag != 0)
                {
                    ans = temp;
                }
                if (i == S.Length - 1 && temp > 0 && flag == 0)
                {
                    ans = temp;
                }
            }
            Console.WriteLine($"Длина самого короткого слова: {ans}");

        }
    }
}

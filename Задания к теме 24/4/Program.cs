using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку на русском языке: ");
            string S = Console.ReadLine();
            char[] glas = new char[] { 'а', 'и', 'е', 'е', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            int ans = 0;
            for (int i = 0; i < S.Length; i++)
            {
                int k = 0;
                for(int j = 0; j < glas.Length; j ++)
                {
                    if (S[i] == glas[j])
                        k = 1;
                }
                ans += k;
            }
            Console.WriteLine($"Кол-во гласных в данной строке: {ans}");
        }
    }
}

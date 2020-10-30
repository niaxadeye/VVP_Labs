using System;

namespace _5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введиет строку S: ");
            string S = Console.ReadLine();
            Console.Write("Введиет строку S0: ");
            string S0 = Console.ReadLine();
            int ans = 0;
            for(int i = 0; i < S.Length-S0.Length +1; i++)
            {
                int k = 0;
                for(int j = 0; j < S0.Length; j++)
                {
                    if(S0[j] == S[i+j])
                    {
                        k++;
                    }
                }
                if (k == S0.Length)
                {
                    ans+=1;
                    i = i + S0.Length - 1 ;
                }
            }
            Console.WriteLine($"Строка S0 входит в строку S {ans} раз(a)");
        }
    }
}

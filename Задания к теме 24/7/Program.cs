using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "Программа";
            string newS = "";
            string NCh = "";
            for (int i = 1; i < S.Length; i+=2)
            {
                newS += S[i];
            }
            for (int i = 0; i < S.Length; i += 2)
            {
                NCh += S[i];
            }
            for (int i = NCh.Length - 1; i  >= 0; i--)
            {
                newS += NCh[i];
            }
            Console.WriteLine(newS);

        }
    }
}

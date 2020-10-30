using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string S = Console.ReadLine();
            char symb = ' ';
            string newS = "";
            for(int i = 0; i < S.Length; i++)
            {
                if(S[i] != ' ') { 
                    if(i == 0)
                    {
                        symb = S[i];
                        newS += S[i];
                    }else if(S[i-1] == ' ')
                    {
                        symb = S[i];
                        newS += S[i];
                    }
                    else if(S[i] == symb)
                    {
                        newS += ".";
                    }
                    else
                    {
                        newS += S[i];
                    }
                }
                else
                {
                    newS += " ";
                }
            }
            Console.WriteLine(newS);
        }
    }
}

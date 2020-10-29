using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string C = Convert.ToString(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            string CC = "C";
            string[] dir = new string[] {"C", "З" , "Ю", "В" };
            for(int i = 0; i < 4; i++)
            {
                if(C == dir[i])
                {
                    temp = i;
                }
            }
            if (C == CC && N == 1)
            {
                Console.WriteLine("В");
            }
            else
            {
                Console.WriteLine(dir[(temp - N) % 4]);
            }
        }
    }
}

using System;
Us

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int Ax = A;
            int Bx = B;
            while(B != A)
            {
                if(A > B)
                {
                    A -= B;
                }
                if(B > A)
                {
                    B -= A;
                }
            }
            Console.WriteLine($"НОД {Ax} и {Bx} = {A}");
        }
    }
}

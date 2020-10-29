using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            if(A > B)
            {
                B = A;
            }else if(B > A)
            {
                A = B;
            }
            else
            {
                A = 0;
                B = 0;
            }
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");


        }
    }
}

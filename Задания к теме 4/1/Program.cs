using System;

namespace _1
{
    class Program
    {
        static public decimal calc_S(decimal a, decimal b)
        {
            decimal S;
            S = a * b;
            return S;
        }
        static public decimal calc_P(decimal a, decimal b)
        {
            decimal P;
            P = 2 * (a + b);
            return P;
        }
        
        static void Main(string[] args)
        {
            decimal a = 0, b = 0, S, P , k =0;
            Console.WriteLine("Разделитель - запятая (например 12,2)");
            do
            {
                Console.Write("Введите длину прямоугольника: ");
                try
                {
                    a = Convert.ToDecimal(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат");
                    Console.ResetColor();
                }
            } while (k == 0);

            k = 0;


            do
            {
                Console.Write("Введите ширину прямоугольника: ");
                try
                {
                    b = Convert.ToDecimal(Console.ReadLine());
                    k = 1;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат");
                    Console.ResetColor();
                }
            } while (k == 0);
            S = calc_S(a, b);
            P = calc_P(a, b);
            Console.WriteLine($"Площадь прямоугольника со стронами {a} и {b} равна {S}, а периметр равен {P}");
        }
    }
}

using System;

namespace NumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Введите 3 числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                int d = a;
                a = b;
                b = d;
            }
            
            if (b < c)
            {
                int d = b;
                b = c;
                c = d;
            }
            
            if (a < b)
            {
                int d = a;
                a = b;
                b = d;
            }
            Console.WriteLine("Числа "+ a + " " + b + " " + c + " по убыванию");
        }
    }
}

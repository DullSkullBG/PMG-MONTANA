using System;

namespace Cikli_GeorgiApostolov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете "+n+"числа:");
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double b = double.Parse(Console.ReadLine());
                sum += b;
            }
            Console.WriteLine("Сбора на числата е: "+sum);
        }
    }
}

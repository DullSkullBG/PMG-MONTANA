using System;
public class PrimeNumberExample
{
    public static void Main(string[] args)
    {
        
        Console.Write("Въведете число и вижте дали е просто: ");
        int n = int.Parse(Console.ReadLine());
        double m =Math.Sqrt(n);
        bool isPrime = true;
        for (int i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                Console.Write("Числото не е просто.");
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            Console.Write("Числото е просто.");
    }
}
using System;

namespace ГеоргиАпостолов
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int result=0;
            while (firstNumber != secondNumber)
            {

                if (firstNumber>secondNumber)
                {
                    result = firstNumber -= secondNumber;
                    
                }
                else if (firstNumber<secondNumber)
                {
                    result = secondNumber -= firstNumber;
                    
                }
                    
            }
            Console.WriteLine(result);
        }
    }
}

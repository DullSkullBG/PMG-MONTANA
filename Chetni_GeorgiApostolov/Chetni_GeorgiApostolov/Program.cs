using System;

namespace Chetni_GeorgiApostolov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a;
            double  max = -1;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                
                if (max>=a) //Това съм го сложил понеже като въведа отрицателно число нищо не става щото е int, и затова реших да направа променлива дето да е равна на -1 и да проверява дали е по голямо
                {
                    Console.WriteLine("Трябва да е положително число!");
                }
                else
                {
                    int b = 0;

                    for (int i = 0; i <= a; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);

                        }
                        
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Трябва да е цяло число!");  //А този else проверява дали това което въвеждам е int и ако не е да излезе този writeline
            }
            //Господине така добре ли е?
           
        }
    }
}

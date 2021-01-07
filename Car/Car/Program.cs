using System;

namespace Car
{
    public class Car
    {
        public string Mark;
        public string Model;
        public int carYear;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Mark = "Audi";
            myCar.Model = "a8";
            myCar.carYear = 2008;
            Console.WriteLine($"Моята марка е {myCar.Mark}, модел {myCar.Model}, годината на колата е {myCar.carYear}");
        }
    }
}

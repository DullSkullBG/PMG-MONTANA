using System;

namespace test
{
    class Car
    {
       public string name;
       public string model;
       public double price;

        public Car(string name,string model,double price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
        }

  
    }
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("toyota","celica",1000000);
            Print(car1);
            Car car2 = new Car("toyota2", "celica2", 100000);
            Print(car2);

        }
        static void Print(Car car)
        {
            Console.WriteLine(car.name);
            Console.WriteLine(car.model);
            Console.WriteLine(car.price);
        }
    }
}

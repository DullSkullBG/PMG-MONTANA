using System;

namespace HappyBirthday
{
    class Birtday
    {
        public string name;
        public string sername;
        public int age;
        public Birtday(string name,string sername,int age)
        {
            this.name = name;
            this.sername = sername;
            this.age = age;
        }
        
    }
    class Program
    {

         static void Print(Birtday birthday)
        {
            Console.WriteLine($"First name: {birthday.name} , second name: {birthday.sername} , my age: {birthday.age}");
        }
        static void Main(string[] args)
        {
            Birtday people1 = new Birtday("Ivan", "Ivanov", 15);
            Print(people1);
        }
    }

}

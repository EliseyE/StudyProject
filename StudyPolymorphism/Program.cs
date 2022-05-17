using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPolymorphism
{
    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Engine is running");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("Car is riding");
        }
    } 

    class SportCar : Car
    {
        protected override void StartEngine()
        {
            Console.WriteLine("Engine is running");
        }

        public override void Drive()
        {
            Console.WriteLine("Car is riding very fast"); ;
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Drive(new SportCar());

            Console.ReadKey();
        }
    }
}

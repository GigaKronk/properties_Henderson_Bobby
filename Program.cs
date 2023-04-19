using System;

namespace properties_Henderson_Bobby
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            Console.WriteLine($"make: {car.Make}, Model: {car.Model}");
            
            Car car2 = new Car();
            car2.Make = "chevy";
            car2.Model = "Camero";

            Console.WriteLine($"make: {car2.Make}, Model: {car2.Model}");

            Car car3 = new Car();
            Console.WriteLine($"make: {car3.Make}, Model: {car3.Model}");
        }
    }
}

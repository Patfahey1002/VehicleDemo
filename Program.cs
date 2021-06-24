using System;

namespace VehicleLot
{
    class Program
    {
        public class Vehicle
        {
            // using protected method to show that it is not accessible via Main
            // but can be accessed by Car and Semi
            protected string drive (string location)
            {
                return "Went for a drive to ";
            }
        }
        // Car is extended by Vehicle 
        // can be accessed outside assembly or this program
        public class Car : Vehicle {
            public void city ()
            {
                string CityName = "New York";
                string myString = drive(CityName);
                Console.WriteLine($"{myString}{CityName}");
            }
        }
        // Semi is extended by Vehicle
        // can be accessed outside assembly or this program
        public class Semi : Vehicle {

        public void numberWheels ()
            {
                int myWheels = 18;
                string myString = $"Truck number wheels are: {myWheels}";
                Console.WriteLine($"{myString}");
            }
        }

        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.city();
            Vehicle myVehicle = new Vehicle();

            // NOTE: the next line cannot access Vehicle!!
            // myVehicle.drive();
            
            Semi mySemi = new Semi();
            mySemi.numberWheels(); 
        }
    }
}

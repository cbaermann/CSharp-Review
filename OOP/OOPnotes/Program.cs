using System;

namespace OOPnotes
{
        class Vehicle
        {
            public int NumPassengers;
            public string Color;
            protected double Odometer;

            public Vehicle(int numPass, string color)
            {
                NumPassengers = numPass;
                Color = color;
                Odometer = 0;
            }

            public Vehicle(string color)
            {
                NumPassengers = 5;
                Color = color;
                Odometer = 0;
            }

            public virtual void GetInfo()
            {
                System.Console.WriteLine($"Num Passengers: {NumPassengers}");
                System.Console.WriteLine($"Color: {Color}");
                System.Console.WriteLine($"Miles: {Odometer}");
            }
        }

            class Car : Vehicle
            {
                public string Make;
                public string Model;

                public Car(string color, string make, string model) : base(color)
                {
                    Make = make;
                    Model = model;
                }

                public override void GetInfo()
                {
                    base.GetInfo();
                    System.Console.WriteLine($"Make: {Make}");
                    System.Console.WriteLine($"Model: {Model}");
                }

                public void Drive(double distance)
                {
                    Odometer += distance;
                    System.Console.WriteLine("I'm Driving");
                }
            }
    class Program
    {

        static void Main(string[] args)
        {
            Vehicle someVehicle = new Vehicle("Green");
            Car someCar = new Car("Yellow", "Dodge", "Dart");
            someVehicle.GetInfo();
            someCar.GetInfo();
        }
    }
}

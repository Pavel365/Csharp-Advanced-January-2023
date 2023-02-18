using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            
            string inputTires;
            while ((inputTires = Console.ReadLine()) != "No more tires")
            {
                string[] info = inputTires
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                tires.Add(new Tire[4]
                {
                    new Tire( int.Parse(info[0]), double.Parse(info[1]) ),
                    new Tire( int.Parse(info[2]), double.Parse(info[3]) ),
                    new Tire( int.Parse(info[4]), double.Parse(info[5]) ),
                    new Tire( int.Parse(info[6]), double.Parse(info[7]) ),

                });
            }
            
            List<Engine> engines = new List<Engine>();
            
            string inputEngines;
            while ((inputEngines = Console.ReadLine()) != "Engines done")
            {
                string[] info = inputEngines
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int horsePower = int.Parse(info[0]);
                double cubicCapacity = double.Parse(info[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));
            }
            
            List<Car> cars = new List<Car>();

            string inputCars;
            while ((inputCars = Console.ReadLine()) != "Show special")
            {
                string[] infoCar = inputCars
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string make = infoCar[0];
                string model = infoCar[1];
                int year = int.Parse(infoCar[2]);
                double fuelQuantity = double.Parse(infoCar[3]);
                double fuelConsumption = double.Parse(infoCar[4]);
                int engineIndex = int.Parse(infoCar[5]);
                int tireIndex = int.Parse(infoCar[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, 
                    fuelConsumption, engines[engineIndex], tires[tireIndex]));
            }

            foreach (Car car in cars)
            {
                double sumPressure = 0;
                foreach (Tire tire in car.Tires)
                {
                    sumPressure += tire.Pressure;
                }

                if (car.Year >= 2017 && car.Engine.HorsePower > 330
                    && sumPressure >= 9 && sumPressure <= 10)
                {
                    car.Drive(0.2);

                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}

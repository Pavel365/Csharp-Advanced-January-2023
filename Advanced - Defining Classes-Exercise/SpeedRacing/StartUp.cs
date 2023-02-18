using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] carProps = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Car car = new Car(carProps[0], double.Parse(carProps[1]), double.Parse(carProps[2]));

                cars.Add(car);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string carModel = input[1];
                double amountOfKm = double.Parse(input[2]);

                foreach (Car car in cars)
                {
                    if (car.Model == carModel)
                    {
                        car.Drive(amountOfKm);
                    }
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}

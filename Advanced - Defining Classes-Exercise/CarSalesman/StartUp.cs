using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();

            int countEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countEngines; i++)
            {
                string[] engineProps = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Engine engine = CreateEngine(engineProps);
                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();

            int countCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCars; i++)
            {
                string[] carProps = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Car car = CreateCar(carProps, engines);
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        static Engine CreateEngine(string[] enginePropeties)
        {
            Engine engine = new(enginePropeties[0], int.Parse(enginePropeties[1]));

            if (enginePropeties.Length > 2)
            {
                int displacement;

                bool isDigit = int.TryParse(enginePropeties[2], out displacement);

                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = enginePropeties[2];
                }

                if (enginePropeties.Length > 3)
                {
                    engine.Efficiency = enginePropeties[3];
                }
            }

            return engine;
        }

        static Car CreateCar(string[] carPropeties, List<Engine> engines)
        {
            Engine engine = engines.Find(x => x.Model == carPropeties[1]);

            Car car = new(carPropeties[0], engine);

            if (carPropeties.Length > 2)
            {
                int weight;

                bool isDigit = int.TryParse(carPropeties[2], out weight);

                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carPropeties[2];
                }

                if (carPropeties.Length > 3)
                {
                    car.Color = carPropeties[3];
                }
            }

            return car;
        }
        
    }
}

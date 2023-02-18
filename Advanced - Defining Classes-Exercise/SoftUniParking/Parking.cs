using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;
        private int count;

        public Parking(int capacity)
        {
            this.Cars = new Dictionary<string, Car>();
            this.Capacity = capacity;
        }

        public Dictionary<string, Car> Cars { get { return this.cars; } set { this.cars = value; } }

        public int Capacity { get { return this.capacity; } set { this.capacity = value; } }

        public int Count { get { return this.cars.Count; } }

        public string AddCar(Car car)
        {
            if (this.Cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (this.Cars.Count >= capacity)
            {
                return "Parking is full!";
            }

            this.Cars.Add(car.RegistrationNumber, car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!this.Cars.ContainsKey(registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }

            this.Cars.Remove(registrationNumber);

            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            return this.Cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string registrationNumber in registrationNumbers)
            {
                this.RemoveCar(registrationNumber);
            }
        }
    }
}

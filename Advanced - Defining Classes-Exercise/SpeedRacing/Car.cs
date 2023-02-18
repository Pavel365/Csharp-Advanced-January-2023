using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance = 0;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }

        public string Model { get { return this.model; } set { this.model = value; } }

        public double FuelAmount { get { return this.fuelAmount; } set { this.fuelAmount = value;} }

        public double FuelConsumptionPerKilometer { get { return this.fuelConsumptionPerKilometer; } set { this.fuelConsumptionPerKilometer = value; } }    

        public double TravelledDistance { get { return this.travelledDistance; } }

        public void Drive (double distanse)
        {
            double neededFuel = this.FuelConsumptionPerKilometer * distanse;

            if (this.FuelAmount >= neededFuel)
            {
                this.FuelAmount -= neededFuel;
                this.travelledDistance += distanse;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
}

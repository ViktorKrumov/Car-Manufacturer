using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;



        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) 
            : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year,
            double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public double FuelQuantity
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Tire[] Tires
        {
            get => tires;
            set => tires = value;
        }
        public Car(string make, string model, int year,
        double fuelQuantity, double fuelConsumption, Engine engine,
        Tire[] tires)
        : this(make, model, year, fuelQuantity, fuelConsumption)

        {
            this.Engine = engine;
            this.Tires = tires;
        }


        public void Drive(double distance)
        {
            if (fuelQuantity - (distance * FuelConsumption) > 0)
            {
                var result = distance * FuelConsumption;
                fuelQuantity -= result;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = "";
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tiresInfo = input.Split();
                var currentTires = new Tire[4];
                for (int i = 0; i <=tiresInfo.Length; i += 2)
                {
                    var currentTire = new Tire(int.Parse(tiresInfo[i]), double.Parse(tiresInfo[i + 1]));
                    currentTires[i] = currentTire;
                }
                tires.Add(currentTires);
            }

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input.Split();
                Engine engine = new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]));
                engines.Add(engine);
            }

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split();
                Engine engine = engines[int.Parse(carInfo[5])];
                Tire[] currentTires = tires[int.Parse(carInfo[6])];
                Car currentCar = new Car(carInfo[0], carInfo[1], int.Parse(carInfo[2]), double.Parse(carInfo[3]), double.Parse(carInfo[4]), engine, currentTires);
                cars.Add(currentCar);
            }

            cars = cars.Where(x => x.Year >= 2017).ToList();
            cars = cars.Where(x => x.Engine.HorsePower > 330).ToList();
            cars = cars.Where(x => x.Tires.Sum(x => x.Pressure) <= 10 && x.Tires.Sum(x => x.Pressure) >= 9)
                .ToList();

            foreach(var car in cars)
            {
                Console.Write("Make: " + car.Make);
                Console.Write("Model: " + car.Model);
                Console.Write("Year: " + car.Year);
                Console.Write("HorsePowers: " + car.Engine.HorsePower);
                Console.Write("FuelQuantity: " + car.FuelQuantity);

            }
        }
    }
}


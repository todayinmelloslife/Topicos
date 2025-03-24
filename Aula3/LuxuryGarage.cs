using System;
using System.Collections.Generic;

namespace LuxuryGarage
{
    // Classe Carro
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }

    // Classe Garagem
    public class Garage
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void ShowCars()
        {
            foreach (var car in cars)
            {
                car.DisplayInfo();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Garage luxuryGarage = new Garage();

            Car car1 = new Car("Ferrari", "488 Spider", 2020);
            Car car2 = new Car("Lamborghini", "Aventador", 2021);
            Car car3 = new Car("Porsche", "911 Turbo S", 2022);

            luxuryGarage.AddCar(car1);
            luxuryGarage.AddCar(car2);
            luxuryGarage.AddCar(car3);

            Console.WriteLine("Luxury Garage Cars:");
            luxuryGarage.ShowCars();
        }
    }
}
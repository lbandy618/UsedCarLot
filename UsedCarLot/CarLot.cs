using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot
{
    internal class CarLot
    {
        public List<Car> cars = new List<Car>()
        {
            new Car("Kia", "Forte", 2009, 1000.50m),
            new Car("Chevrolet", "Silverado", 2022, 55000.00m),
            new UsedCar("Acura", "TLX", 2014, 13000.00m, 100000),
            new UsedCar("Ford", "Focus", 2011, 15000.00m, 20000),
            new Car("GMC", "Terrain", 2021, 26000.00m),
            new UsedCar("Kia", "Sorento", 2021, 11500.00m, 46000),
            new Car("Nissan", "GTR", 2015, 71000.00m),
        };




        //add a car
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        //list cars
        public void ListCars()
        {
            //foreach (Car car in cars)
            //{
            //    Console.WriteLine(car.ToString());
            //}

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1} {cars[i].ToString()}");
            }

        }
        //removes cars

        public void RemoveCar(int index)
        {
            cars.RemoveAt(index);
        }
    }
}

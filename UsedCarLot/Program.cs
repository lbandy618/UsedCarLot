using System;

namespace UsedCarLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hi Lucas");

            Console.WriteLine("Welcome to the Grand Chirpus' Used Car Emporium!");
            Console.WriteLine();

            CarLot lot = new CarLot();
            lot.ListCars();
            

        }
    }
}
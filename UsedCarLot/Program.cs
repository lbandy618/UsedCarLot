using System;

namespace UsedCarLot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarLot lot = new CarLot();
            bool runProgram = true;
            //intro message
            Console.WriteLine("Welcome to the Grand Chirpus' Used Car Emporium!");
            Console.WriteLine();

            while (runProgram)
            {
                //listing cars
                lot.ListCars();
                Console.WriteLine($"{lot.cars.Count + 1} Add a car");
                Console.WriteLine($"{lot.cars.Count + 2} Quit");

                //collecting user input                
                int choice = 0;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Not a menu option, please try again: ");
                }

                //buying a car
                if (choice >= 1 && choice <= lot.cars.Count)
                {
                    Console.WriteLine(lot.cars[choice - 1]);
                    while (true)
                    {
                        Console.WriteLine("Would you like to buy the car? y/n: ");
                        string purchase = Console.ReadLine().ToLower().Trim();
                        if(purchase == "y")
                        {
                            lot.RemoveCar(choice - 1);
                            Console.WriteLine("Excellent, our finace department will be in touch shortly.");
                            break;
                        }
                        else if(purchase == "n")
                        {
                            Console.WriteLine("You will regret this.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid input.");
                        }
                    }
                    
                }

                //adding a car
                else if(choice == lot.cars.Count + 1)
                {
                    Console.WriteLine("Perfect! Please give me more info about that car: ");
                    Console.WriteLine();
                    //make
                    Console.Write("What is the cars make?: ");
                    string make = Console.ReadLine().ToLower().Trim();
                    //model
                    Console.Write("What is the cars model?: ");
                    string model = Console.ReadLine().ToLower().Trim();
                    //year
                    Console.Write("What year was the car made?: ");
                    int year = 0;
                    while (!int.TryParse(Console.ReadLine(), out year))
                    {
                        Console.Write("Not a valid input, please try again: ");
                    }
                    //price
                    Console.Write("What is the car's price?: ");
                    decimal price = 0;
                    while (!decimal.TryParse(Console.ReadLine(), out price))
                    {
                        Console.Write("Not a valid input, please try again: ");
                    }
                    //is used?
                    bool isUsed = true;
                    while (true)
                    {
                        Console.Write("Is this car used? y/n: ");
                        string isUsedChoice = Console .ReadLine().ToLower().Trim();
                        if(isUsedChoice == "y")
                        {
                            isUsed = true;
                            break;
                        }
                        else if(isUsedChoice == "n")
                        {
                            isUsed = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid input.");
                        }
                    }
                    if(isUsed == false)
                    {
                        Car newCar = new Car(make, model, year, price);
                        lot.AddCar(newCar);
                    }
                    //used car
                    else
                    {
                        double milage = 0;
                        while (true)
                        {
                            Console.Write("What is the milage?: ");
                            while (!double.TryParse(Console.ReadLine(), out milage))
                            {
                                Console.Write("Not a menu option, please try again: ");
                            }
                            break;

                        }
                        UsedCar newCar = new UsedCar(make, model, year, price, milage);
                        lot.AddCar(newCar);
                    }

                }
                //quit
                else if(choice == lot.cars.Count + 2)
                {
                    runProgram = false;
                    Console.WriteLine("Thank you for visiting the Grand Chirpus' Used Car Emporium! We will be back tomorrow.");
                }



            }
        }
    }
}
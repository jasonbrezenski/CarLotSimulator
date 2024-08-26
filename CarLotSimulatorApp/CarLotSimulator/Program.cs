using System;
using System.Threading.Channels;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            Console.WriteLine($"Current number of cars: {CarLot._numberOfCars}");
            
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            //Dot notation
            var carOne = new Car();
            carOne.Year = 2022;
            carOne.Make = "Volkswagen";
            carOne.Model = "Atlas";
            carOne.EngineNoise = "kitten purring";
            carOne.HonkNoise = "smooth consistent sound";
            carOne.IsDriveable = true;
            
            carOne.MakeEngineNoise();
            carOne.MakeHonkNoise();
            Console.WriteLine($"Current number of cars: {CarLot._numberOfCars}");
            
            Console.WriteLine("-----------------------");
            
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Object initializer syntax
            var carTwo = new Car()
            {
                Year = 2018, 
                Make = "Chevrolet", 
                Model = "Traverse", 
                EngineNoise = "wrenches clanking", 
                HonkNoise = "beep beep", 
                IsDriveable = true
            };
            carTwo.MakeEngineNoise();
            carTwo.MakeHonkNoise();
            Console.WriteLine($"Current number of cars: {CarLot._numberOfCars}");
            
            Console.WriteLine("_______________________");

            //Custom constructor (default & custom methods at bottom of Car.cs)
            var carThree = new Car(2013, "VW", "Passat","normal vehicle", "beeeeeeeep", true);
            carThree.MakeEngineNoise();
            carThree.MakeHonkNoise();
            Console.WriteLine($"Current number of cars: {CarLot._numberOfCars}");
            
            Console.WriteLine("-----------------------");
            
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            var carLotOne = new CarLot();
            carLotOne.CarListing.Add(carOne);
            carLotOne.CarListing.Add(carTwo);
            carLotOne.CarListing.Add(carThree);
            carLotOne.ListOfCars();
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace CarLotSimulator;

public class CarLot
{
    
    //Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    public List<Car> CarListing { get; set; } = new List<Car>();

    public void ListOfCars()
    {
        foreach (var vehicle in CarListing)
        {
            Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
        }
    }

    public static int _numberOfCars;
}
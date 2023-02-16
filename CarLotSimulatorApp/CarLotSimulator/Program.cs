using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            Car car1 = new Car();

            car1.make = "Genesis";
            car1.model = "gv60";
            car1.year = 2023;
            car1.isDriveable = true;
            car1.EngineNoise = "voom";
            car1.HonkNoise = "beep";


            CarLot carlot = new CarLot();

            Car car2 = new Car();
            
            car2.make = "hyundai";
            car2.model = "Elantra";
            car2.year = 2023;
            car2.isDriveable = true;
            car2.EngineNoise = "vroom";
            car2.HonkNoise = "boop";

            Car car3 = new Car();
            
            car3.make = "jeep";
            car3.model = "wagoneer";
            car3.year = 2023;
            car3.isDriveable = true;
            car3.EngineNoise = "vroom";
            car3.HonkNoise = "bonk";

            Car car4 = new Car();
            
            car4.make = "mercedes";
            car4.model = "G-wagon";
            car4.year = 2023;
            car4.isDriveable = true;
            car4.EngineNoise = "vroom";
            car4.HonkNoise = "Move";

            Console.WriteLine($"{CarLot._numberOfCars}");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

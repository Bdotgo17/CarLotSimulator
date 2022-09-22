using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();


            //Done Create a seperate class file called Car



            //Now that the Car class is created we can instanciate 3 new cars
            // focus = new Car();
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var michaelsCar = new Car();
            michaelsCar.Make = "Ford";
            michaelsCar.Model = "Focus";
            michaelsCar.Year = 2013;
            michaelsCar.EngineNoise = "vroom";
            michaelsCar.HonkNoise = "beep";
            michaelsCar.IsDrivable = true;

            lot.Cars.Add(michaelsCar);

            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDrivable = false
            };

            lot.Cars.Add(stevesCar);

            var brettsCar = new Car(2013, "Honda", "Civic", "vrroommm", "vruuuuuga", true);

            lot.Cars.Add(brettsCar);

            michaelsCar.MakeEngineNoise(michaelsCar.EngineNoise);
            stevesCar.MakeEngineNoise(stevesCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //done Create a CarLot class
            //done It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the
            //

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"{car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}

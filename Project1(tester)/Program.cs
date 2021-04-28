using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionLibrary1;

namespace Project1_tester_
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //be careful. try block will stop program when it catches the first error.
            try
            {




                List<AutoMobile> myGarage = new List<AutoMobile>
                                                {

                                                                        new PickupTruck(15, "black", 13, 1995, 5000, "Ford"),
                                                                        new PickupTruck(21, "blue", 13, 2000, 5000, "Chevy"),
                                                                        new PickupTruck(25, "red", 13, 2013, 5000, "Ram"),
                                                                        new Car(9, "white", 20, 2010, "Cadillac"),
                                                                        new Car(19, "red", 20, 2002, "Toyota"),
                                                                        new Car(8, "black", 20, 2019, "BMW"),
                                                                        new Car(15, "black", 20, 1999, "Volvo"),
                                                                        new Suv(20, "blue", 25, 2009, 2000, "Toyota"),
                                                                        new Suv(12, "grey", 25, 2003, 2000, "Chevy"),
                                                                        new Suv(13, "white", 25, 2017, 2000, "Chevy"),
                                                                        new Suv(13, "red", 25, 2017, 2000, "Chevy"),
                                                                        new GarbageTruck(10, "grey", 10, 2002, 5000, 15000, "Camarro"),
                                                                        new GarbageTruck(10, "purple", 10, 2002, 5000, 15000, "Chevy")

                                                };





                   

               
                



            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
           
            
            Console.ReadLine();
        }
    }
}





//Goals:
//
//1.
//2. Improve the Garbage truck class.
//
//
//solved
//1.Milage should only be set if there is gas in the tank, Drive method always adds the miles even if there is no gas in the tank
//2..Find the gallons used. Create a bool variable that checks if gallons used is greater than 0.
//3. place bool variable inside a 'while' loop.
//4..Inside the loop:
//      1.milage should be increased by MilesPerGallon
//      2.GasInTank should be decreased by one.
//5. If the user complets the loops it should print a statement.
//6.add needsOilChange property to Automobile class that is affected every time milage property is added. Override property in Cadillac  





//Notes and code lessons:
// 1. A collection cannot be enumerated (counted) and modified in a for each loop. This is because collection cannot cound and modify at the same time without getting an error.
// this is why you need to use ToList() or ToArray() so it makes a copy of the list already counted and then removes or adds the items.
//
//
//
//














//List<AutoMobile> myGarage = new List<AutoMobile>
//                                {

//                                                        new PickupTruck(15, "black", 13, 1995, 5000, "Ford"),
//                                                        new PickupTruck(21, "blue", 13, 2000, 5000, "Chevy"),
//                                                        new PickupTruck(25, "red", 13, 2013, 5000, "Ram"),
//                                                        new Car(9, "white", 20, 2010, "Cadillac"),
//                                                        new Car(19, "red", 20, 2002, "Toyota"),
//                                                        new Car(8, "black", 20, 2019, "BMW"),
//                                                        new Car(15, "black", 20, 1999, "Volvo"),
//                                                        new Suv(20, "blue", 25, 2009, 2000, "Toyota"),
//                                                        new Suv(12, "grey", 25, 2003, 2000, "Chevy"),
//                                                        new Suv(13, "white", 25, 2017, 2000, "Chevy"),
//                                                        new GarbageTruck(10, "grey", 10, 2002, 5000, 15000, "Chevy"),
//                                                        new GarbageTruck(10, "purple", 10, 2002, 5000, 15000, "Chevy")

//                                };



















//List<string> favoriteColor = new List<string> { "purple", "red", "blue" };

//var FavoriteColorCars = myGarage.Join(
//    favoriteColor,
//    car => car.Color,
//    c => c,
//    (car, color) => car
//    );

//foreach (var car in FavoriteColorCars.ToList())
//{
//    Console.WriteLine("Model: " + car.Model + "  Color: " + car.Color);
//}




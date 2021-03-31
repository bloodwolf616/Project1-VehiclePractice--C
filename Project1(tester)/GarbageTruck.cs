using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class GarbageTruck : AutoMobile
    {
        
        protected readonly int TrailerWeight;
        public int MaxCarryWeight { get; }
       
       
        public GarbageTruck(int gasTank, String color, int milesPerGallon, int yearOfManufacturer, int trailerWeight, int maxCarryWeight, string model) : base(gasTank, color, milesPerGallon, yearOfManufacturer, model)
        {
        
            MaxCarryWeight = maxCarryWeight;
            
            TrailerWeight = trailerWeight;
            // We specify that our SetTow interface is a LargeTow object.
            SetTow = new LargeTow(trailerWeight);

        }


        public void TakeOutGarbage(GarbageCan[] cans, int milesBetweenCans)
        {

            foreach (var can in cans)
            {
               
                can.EmptyOutGarbageCan();
                Drive(milesBetweenCans);

            }

            Console.WriteLine("you have taken out all the trash.");
         

        }
    }
}

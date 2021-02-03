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
        public int RemainingWeight { get; private set; }
       
        public GarbageTruck(int gasTank, String color, int milesPerGallon, int yearOfManufacturer, int trailerWeight, int maxCarryWeight, string model) : base(gasTank, color, milesPerGallon, yearOfManufacturer, model)
        {
            GasInTank = gasTank;
            MaxCarryWeight = maxCarryWeight;
            RemainingWeight = MaxCarryWeight;
            TrailerWeight = trailerWeight;
            // We specify that our SetTow interface is a LargeTow object.
            SetTow = new LargeTow(trailerWeight);

        }


        public bool TakeOutGarbage(GarbageCan[] cans, int milesBetweenCans)
        {

            foreach (var can in cans)
            {
                RemainingWeight -= can.GarbageWeight;
                can.EmptyOutGarbageCan();
                Drive(milesBetweenCans);

            }
            

            if (RemainingWeight > 0)
            {
                Console.WriteLine($"This garbage truck has taken out all the trash. You can take out {RemainingWeight} more pound(s) of trash");
                return true;
            }

            else
            {
                Console.WriteLine("This garbage truck has failed to take out all the trash because it has reached full capacity");
                return false;
            }

        }
    }
}

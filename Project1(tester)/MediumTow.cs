using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class MediumTow : ITowable
    {

        //Takes in a trailer weight integer and sets it to the property TrailerWeight. CanTow takes in the traielr weight property/
        public int TrailerWeight { get; set; }

        private readonly int MaxTowingCapacity = 5000;
        public MediumTow(int trailerWeight)
        {
            TrailerWeight = trailerWeight;
        }
        public bool CanTow()
        {
            int RemainingWeight = TrailerWeight - MaxTowingCapacity;

            if (TrailerWeight < MaxTowingCapacity)
            {
                Console.WriteLine("You can tow this trailer.");
                return true;

            }
            else
            {
                Console.WriteLine($"This trailer is {RemainingWeight} pound(s) over the max towing capacity. Therefore you cannot tow this object");
                return false;
            }
        }
    }
}


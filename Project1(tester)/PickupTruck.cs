using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class PickupTruck : AutoMobile
    {
       public int TrailerWeight { get; private set; }

        public override int MilesToOilChange { get; protected set; } = 5000;
        public PickupTruck(int gasTank, String color, int milesPerGallon, int yearOfManufacturer, int trailerWeight, string model) : base(gasTank, color, milesPerGallon, yearOfManufacturer, model)
        {
            GasInTank = gasTank;

            TrailerWeight = trailerWeight;
            // We specify that our SetTow interface is a LargeTow object.
            SetTow = new LargeTow(trailerWeight);

        }
        
    }
}

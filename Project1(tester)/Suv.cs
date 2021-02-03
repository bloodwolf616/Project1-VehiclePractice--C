using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class Suv : AutoMobile
    {
        protected readonly int TrailerWeight;
        public Suv(int gasTank, String color, int milesPerGallon, int yearOfManufacturer, int trailerWeight, string model) : base(gasTank, color, milesPerGallon, yearOfManufacturer, model)
        {
            GasInTank = gasTank;

            TrailerWeight = trailerWeight;
            // we drop down our tow interface from Automobile. We specify that this tow interface is a LargeTow object.
            SetTow = new MediumTow(trailerWeight);

        }
    }
}

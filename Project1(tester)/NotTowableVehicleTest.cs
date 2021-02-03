using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class NotTowableVehicleTest : AutoMobile
    {
        public NotTowableVehicleTest(int gasTank, string color, int milesPerGallon, int yearOfManufacturer, string model) : base(gasTank, color, milesPerGallon, yearOfManufacturer, model)
        {
        }
    }
}

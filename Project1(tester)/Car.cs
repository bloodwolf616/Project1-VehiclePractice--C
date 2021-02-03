using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class Car : AutoMobile
    {
       



        // GasInTank parent property is set to the gasTank the user specifies. the Milage parent property is used in the Drive() method.
        public Car(int gasTank, String color, int milesPerGallon, int yearOfManufacturer, string model) : base(gasTank, color, milesPerGallon, yearOfManufacturer, model)
        {
            GasInTank = gasTank;
        }

       
      

    

    }
}


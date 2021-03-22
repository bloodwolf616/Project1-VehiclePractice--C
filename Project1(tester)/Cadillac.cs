using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class Cadillac : AutoMobile
    {
        public override int MilesToOilChange { get; protected set; } = 15000;
        public Cadillac(int gasTank, String color, int milesPerGallon, int yearOfManufacturer, string model) : base(gasTank, color, milesPerGallon, yearOfManufacturer, model)
        {
            
            SetTow = new NotTowable();
            
        }








        
    }
 }


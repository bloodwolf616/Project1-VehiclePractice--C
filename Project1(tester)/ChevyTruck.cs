using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_tester_
{
    class ChevyTruck : IAutomobile
    {
        public int GasTank { get; private set; }

        private int _gasInTank;

        public int GasInTank
        {
            get { return _gasInTank; }
            protected set
            {



                if (value >= 0 && value <= GasTank)
                {
                    _gasInTank = value;
                }
                if (value > GasTank) { throw new InvalidOperationException("You are over filling the gas tank!"); }

                if (value <= 0) { throw new InvalidOperationException("There is no gas left in the tank."); }





            }
        }



        public string Color { get; private set; }

        public int MilesPerGallon { get; private set; }

         public int YearOfManufacturer { get; private set; }

         public int Milage { get; private set; }

           public string Model { get; private set; }





        public ChevyTruck(int gasTank, string color, int milesPerGallon, int yearOfManufacturer, int milage, string model)
        {
            GasTank = gasTank;
            GasInTank = gasTank;
            Color = color;
            MilesPerGallon = milesPerGallon;
            YearOfManufacturer = yearOfManufacturer;
            Milage = milage;
            Model = model;
        }

        public void Drive(int miles)
        {
            throw new NotImplementedException();
        }

        public void Fill()
        {
            throw new NotImplementedException();
        }

        public void GetOilChange()
        {
            throw new NotImplementedException();
        }

        public void PerformTowable()
        {
            throw new NotImplementedException();
        }
    }
}

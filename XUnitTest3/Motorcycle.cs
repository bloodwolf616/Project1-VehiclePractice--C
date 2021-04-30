using System;

namespace XUnitTest3
{
    internal class Motorcycle
    {

        public int GasTank { get; private set; }
        public int Milage { get; private set; }

        private int _gasInTank;

        public int MilesperGallon { get; } = 20;

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

        public Motorcycle(int gasTank)
        {
            
            GasTank = gasTank;
            GasInTank = GasTank;
        }


      


        /// <summary>
        /// Drives the Motorcycle
        /// </summary>
        /// <param name="miles">the miles you want to drive as a integer</param>
        /// <returns></returns>
        public bool DriveBike(int miles)
        {
            int gallonsUsed = miles / MilesperGallon;

            while(gallonsUsed > 0)
            {
                Console.WriteLine("Vroom!");
                GasInTank--;
                gallonsUsed--;
                Milage += MilesperGallon;
            }

            if(GasInTank > 0 && gallonsUsed == 0) { return true; }
            else { return false; }
        }
    }
}
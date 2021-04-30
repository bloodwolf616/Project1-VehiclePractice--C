using System;
using System.Collections.Generic;
using System.Text;
using Project1_tester_;
namespace XUnitTest3
{
    public class TestableAutomobile
    {
        public int GasTank { get; private set; }
        public string Color { get; set; }
        public int MilesPerGallon { get; private set; }
        private int _gasInTank;
        public int YearOfManufacturer { get; private set; }
        public virtual int Milage { get; protected set; } = 0;

        public string Model { get; private set; }



        public virtual int MilesToOilChange { get; protected set; } = 10000;

        //Constructor
        public TestableAutomobile(int gasTank, String color, int milesPerGallon, int yearOfManufacturer, string model)
        {
            Model = model;
            GasTank = gasTank;
            GasInTank = GasTank;
            Color = color;
            MilesPerGallon = milesPerGallon;
            YearOfManufacturer = yearOfManufacturer;
            IsLocked = true;
            if (yearOfManufacturer < 1905)
            {
                throw new Exception("Cars didn't exist in this time period.");
            }

        }

        //---------------------------------------------------------------------------------------------------------------

        //GasInTank property. It can only be set if the value is between gasTank and 0. If it is over or unnder it will throw an error.

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


        //----------------------------------------------------------------------------------------------------------------------------->

        // the car will start out locked so you will have to unlock car to use some of the methods
        // Is locked propertiues and all of it's methods.


        public virtual bool IsLocked { get; private set; }

        public void Unlock()
        {

            IsLocked = false;
        }

        public void Lock()
        {

            IsLocked = true;
        }


        //------------------------------------------------------------------------------------------------------------------------------------>


        // Fill() method. Fills up the GasIntank property


        public virtual void Fill()
        {
            GasInTank = GasTank;
        }
        //Fill method takes an integer and is wrapped around a try catch block. If they over fill the gas tank it will thorw an error. 
        public virtual void Fill(int gallonsOfGas)
        {

            GasInTank += gallonsOfGas;

        }


        //---------------------------------------------------------------------------------------------------------------------------------------->



        // the car will start out locked. If the the car is locked the code will throw an error. 

        /// <summary>
        /// drives the vehicle. effects Milage, GasInTank, MilesToOilChange properties
        /// </summary>
        /// <param name="miles">miles that you wish to drive</param>
        public virtual void Drive(int miles)
        {



            if (IsLocked == false && MilesToOilChange >= 0)
            {

                int gallonsUsed = miles / MilesPerGallon;
                int gallonsToGo = gallonsUsed;


                while (gallonsToGo > 0)
                {
                    Milage += MilesPerGallon;
                    GasInTank--;
                    Console.WriteLine("VROOM!");
                    gallonsToGo--;
                }

                if (GasInTank > 0)
                {
                    Console.WriteLine($"You have completed your {miles} mile journey. You have {GasInTank} gallon(s) left in the tank and this car has driven {Milage} miles.");
                }


            }

            else { throw new InvalidOperationException("Your car is locked. Unlock to drive."); }


            //miles to oil changes decreases every time you use the Drive() method. If MilesToOilChange() gets to zero it will throw an exception.
            MilesToOilChange -= miles;
            if (MilesToOilChange <= 0) { throw new InvalidOperationException("You need to get an oil change with the GetOilChange() method."); }




        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------->



 



        //-------------------------------------------------------------------------------------------------------------------------


        /// <summary>
        /// Gives the vehicle an oil change. returns how many miles until next oil change
        /// </summary>
        public void GetOilChange()
        {
            int oilChange = 10000;
            MilesToOilChange += oilChange;
            Console.WriteLine($"You have {oilChange} miles until your next oil change.");
        }





        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Compares two Automobile objects. Used for sorting lists
        /// </summary>
        /// <param name="other">the object you want to compare to</param>
        /// <returns></returns>
        /// 

        // CompareTo() method returns 0 if two objects have the same value.
        // It returns a positive integer if the object passed in should be ordered after, a negative integer if it should be placed before
        public int CompareTo(TestableAutomobile other)
        {
            int result = this.Model.CompareTo(other.Model);

            if (result == 0)
            {
                result = this.Color.CompareTo(other.Color);
            }


            return result;
        }
    }
}

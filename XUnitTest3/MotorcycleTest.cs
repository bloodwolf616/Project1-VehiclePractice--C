using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Project1_tester_;

namespace XUnitTest3
{
  public class MotorcycleTest
  {
        //Arrange
        private Motorcycle _myMotorcycle;
          public MotorcycleTest()
        {
           _myMotorcycle = new Motorcycle(15);
        }
            
        
        [Fact]
            public void MotorcycleCanDrive()
            {
                      bool expected = true;
                      bool actual;
                  
                        
                            _myMotorcycle.DriveBike(100);
                            if (_myMotorcycle.Milage == 100) { actual= true; }
                            else { actual = false; }
                        

                       
                        Assert.Equal(expected, actual);
            }


        [Fact]
        public void MotorcycleWontDrive()
        {

            var exception = Assert.Throws<InvalidOperationException>(() => _myMotorcycle.DriveBike(500));


        }



        [Fact]
        public void MotorcycleHazardLights()
        {
            //act
            var actual = _myMotorcycle.SetHazardLights(true);
            var expected = true;
            //assert
            Assert.Equal(expected, actual);
            


        }

    }
}

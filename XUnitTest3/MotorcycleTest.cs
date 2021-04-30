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
                
                    var expected = true;

                    //Act
                   bool actual = _myMotorcycle.DriveBike(100);
                    //Assert
                    Assert.Equal(expected, actual);
            }


        [Fact]
        public void MotorcycleWontDrive()
        {

            var exception = Assert.Throws<InvalidOperationException>(() => _myMotorcycle.DriveBike(500));


        }

    }
}

using System;
using Xunit;
using Project1_tester_;




namespace XUnitTest3
{
    public class AutomobileTest
    {
        [Fact]
        public void OverfillingGasTankError()
        {
            //Arrange
            TestableAutomobile myTruck = new TestableAutomobile(25, "red", 13, 2013, "Ram");
            
         
            //Assert
            var exception = Assert.Throws<InvalidOperationException>(() => myTruck.Fill(50));

        }
    }
}


//var exception = Assert.Throws<InvalidOperationException>(() => myTruck.Fill(50));
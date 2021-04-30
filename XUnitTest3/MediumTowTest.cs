using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Project1_tester_;
namespace XUnitTest3
{
     public class MediumTowTest
    {
        [Fact]
        public void CanTowMethodTest()
        {
            //Arrange
            MediumTow tow = new MediumTow(3000);
            bool expected = true;
            //Act
            bool actual = tow.CanTow();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

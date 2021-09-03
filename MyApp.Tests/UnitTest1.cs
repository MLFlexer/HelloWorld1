using System;
using Xunit;

namespace MyApp.Tests
{
    public class LeapYearTest
    {
        [Fact]
        public void LeapYear1700False()
        {
            //Arrage
            var leapYear = new Program();
            //Act
            var output = leapYear.IsLeapYear(1700);
            //Assert
            Assert.Equal(false, output);
        }

        [Fact]
        public void LeapYear2000True()
        {
            //Arrage
            var leapYear = new Program();
            //Act
            var output = leapYear.IsLeapYear(2000);
            //Assert
            Assert.Equal(true, output);
        }

        [Fact]
        public void LeapYear16True()
        {
            //Arrage
            var leapYear = new Program();
            //Act
            var output = leapYear.IsLeapYear(16);
            //Assert
            Assert.Equal(true, output);
        }
    }
}

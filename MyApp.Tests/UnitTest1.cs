using System;
using System.IO;
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

        [Fact]
        public void LeapYear15False()
        {
            //Arrage
            var leapYear = new Program();
            //Act
            var output = leapYear.IsLeapYear(15);
            //Assert
            Assert.Equal(false, output);
        }

        [Fact]
        public void LeapYear15nay()
        {
            //Arrage
            var leapYear = new Program();
            var writer = new StringWriter();
            Console.SetOut(writer);
            //Act
            var expected = "nay\r\n";
            leapYear.LeapYearYayOrNay("15");
            
            var output = writer.GetStringBuilder().ToString();
            //Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void LeapYear16yay()
        {
            //Arrage
            var leapYear = new Program();
            var writer = new StringWriter();
            Console.SetOut(writer);
            //Act
            var expected = "yay\r\n";
            leapYear.LeapYearYayOrNay("16");
            
            var output = writer.GetStringBuilder().ToString();
            //Assert
            Assert.Equal(expected, output);
        }
    }
}

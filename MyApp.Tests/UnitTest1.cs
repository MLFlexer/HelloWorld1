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
            leapYear.LeapYearYayOrNay("1599");
            
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
            leapYear.LeapYearYayOrNay("1600");
            
            var output = writer.GetStringBuilder().ToString();
            //Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void LeapYearYayOrNay_Throws_YearLessThen1582Exception()
        {
            //Arrange
            var program = new Program();
            //Act
            
            //Assert
            Assert.Throws<YearLessThen1582Exception>(() => program.LeapYearYayOrNay("1580"));
        }

        [Fact]
        public void LeapYearYayOrNay_Throws_FormatException()
        {
            //Arrange
            var program = new Program();
            //Act
            
            //Assert
            Assert.Throws<FormatException>(() => program.LeapYearYayOrNay("s"));
        }
    }
}

using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.LeapYearYayOrNay();
        }

        public void LeapYearYayOrNay() 
        {
            Console.WriteLine("Please enter year, to check if it is a leap year:");
            var userInput = Console.ReadLine();
            try
            {
            LeapYearYayOrNay(userInput);
            }
            catch (YearLessThen1582Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not calculate Leap Year, because input was not in the form of an integer");
            }
        }

        public void LeapYearYayOrNay(string userInput) {

            var year = int.Parse(userInput);

            if (year < 1582)
            {
                throw new YearLessThen1582Exception("Leap year can only be calculated based on years from 1582");
            } 
            else 
            {

                if (IsLeapYear(year))
                {
                    Console.WriteLine("yay");
                }
                else {
                    Console.WriteLine("nay");
                }
            }
        }

        public bool IsLeapYear(int year) {
            if (year % 100 == 0) {
                if (year % 400 == 0)
                {
                    return true;
                } else {
                    return false;
                }
            } else if (year % 4 == 0)
            {
                return true;
            } else
            {
                
                return false;
            }
        }
    }
}

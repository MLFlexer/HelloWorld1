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
            LeapYearYayOrNay(userInput);
        }

        public void LeapYearYayOrNay(string userInput) {

            var year = int.Parse(userInput);
            if (IsLeapYear(year))
            {
                Console.WriteLine("yay");
            }
            else {
                Console.WriteLine("nay");
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

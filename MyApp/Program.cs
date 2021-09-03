using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //prints hello world
            Console.WriteLine("Hello World!");
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

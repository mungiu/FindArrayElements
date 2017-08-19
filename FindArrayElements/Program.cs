using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //int indexOfTuesday = Array.IndexOf(daysOfWeek, "Tuesday");

            ////searching array elements according to predicate bool condition
            //int indexOfWednesday = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
            //Console.WriteLine(indexOfWednesday);
            //Console.WriteLine(daysOfWeek[indexOfWednesday]);
            //Console.WriteLine();

            //finds all elements with 6 chars
            string[] allWithSixChars = Array.FindAll(
                daysOfWeek, x => x.Length == 6);
            foreach (string item in allWithSixChars)
                Console.WriteLine(item);
        }
    }
}

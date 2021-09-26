using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerDataTypes
{
    /// <summary>
    /// Integer Data Types Lecture code
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates Integer Data Types
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int totalSecondsPlayed = 100;
            const int SecondsPerMinute = 60;

            //calculate minutes and seconds played
            int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
            int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

            //print results
            Console.WriteLine("minutes played: " + minutesPlayed);
            Console.WriteLine("seconds played: " + secondsPlayed);
            Console.ReadLine();
        }
    }
}

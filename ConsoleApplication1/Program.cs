using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace searchFlights
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length <4 )
            {
                System.Console.WriteLine("Please enter arguments properly. Example '$searchFlights -o YYZ -d DEL' " );
                return;
            }
            else {
                if (args[0] == "-o" && args[1].Length == 3 & args[2] == "-d" && args[3].Length == 3)
                {


                    List<string> list = new List<string>();
                    string[] paths = new string[] { "c:/Provider1.txt", "c:/Provider2.txt", "c:/Provider3.txt" };
                    

                    {
                        try
                        {
                            for (int j = 0; j < paths.Length; j++)
                            {
                                //Flights.Readflights(File.ReadLines(paths[j]).ToArray(), args[1], args[3]);
                                Flights.Readflights(File.ReadLines(paths[j]).ToArray(),"JFK", "YEG");

                            }
                            Flights.FlightsList.Sort(
        delegate (Flight p1, Flight p2)
        {
            int compareDate = p1.Price.CompareTo(p2.Price);
            if (compareDate == 0)
            {
                return p2.Departuredate.CompareTo(p1.Departuredate);
            }
            return compareDate;
        }
    );
                            
                            var distinctItems = Flights.FlightsList.GroupBy(c => new { c.Origin, c.Destination, c.Departuredate, c.DestinationDate, c.Price }).Select(c => c.First()).ToList();
                            foreach (Flight f in distinctItems) { Console.WriteLine(f.Origin + " -->" + f.Destination + " (" + f.Departuredate + " --> " + f.DestinationDate + ") - " + f.Price  );}                  

                            }
                        catch (Exception e)
                        {
                            System.Console.WriteLine("An error has occured. Please see the details of the error: " + e.InnerException);
                        }

                    }
                } else
                {
                    System.Console.WriteLine("Please enter arguments properly. Example '$searchFlights -o YYZ -d DEL' ");
                    return;
                }
            }
        }
        }
}


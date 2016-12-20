using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace searchFlights
{
    static class Flights
    {
        static string _origin;
        static List<Flight> _flightsList = new List<Flight>();

        public static List<Flight> FlightsList
        {
            get { return _flightsList; }
            set { _flightsList = value; }
        }
        public static void Readflights(string[] slist, string Origin, string Destination)
        {
            char splitChar = ',';
            if (slist[0].Split(splitChar)[0] != "Origin") {  splitChar = '|'; }
            foreach (var s in slist)
            {
                if (s.Split(splitChar)[0] != "Origin")
                {
                    if (s.Split(splitChar)[0] == Origin && s.Split(splitChar)[2] == Destination)
                    {
                        FlightsList.Add(new Flight(s.Split(splitChar)[0], s.Split(splitChar)[1], s.Split(splitChar)[2], s.Split(splitChar)[3], s.Split(splitChar)[4]));
                    }
                }
            }
        }


    } } 
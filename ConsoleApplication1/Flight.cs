using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchFlights
{
    class Flight
    {
        string _origin;

        DateTime _departuredate;
        string _destination;
        DateTime _destinationdate;
        string _price;

        public Flight( string origin, string departuredate, string destination, string destinationDate, string price) { Origin = origin; Departuredate = departuredate;
            Destination = destination; DestinationDate = destinationDate; Price = price; }
        
public string Origin
{
    get { return _origin; }
    set { if (string.IsNullOrWhiteSpace(value))
        throw new ArgumentNullException();

    _origin = value; }
}

        public string Departuredate
{
    get { return _departuredate.ToString(); }
    set {   DateTime.TryParse(value, out _departuredate); }
}
        public string Destination
{
    get { return _destination; }
    set { if (string.IsNullOrWhiteSpace(value))
        throw new ArgumentNullException();

    _destination = value; }
}
        public string DestinationDate
{
            get { return _destinationdate.ToString(); }
            set { DateTime.TryParse(value, out _destinationdate); }
        }
        public string Price
{
    get { return  string.Format("{0:C}", _price); }
    set { if (value == null) _price = "0"; else _price= String.Format("{0:C}", value); }
}

    }
}

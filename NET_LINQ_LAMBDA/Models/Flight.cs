using System;

namespace NET_LINQ_LAMBDA.Models
{
    public class Flight
    {
        public int AirlineID;
        public int CountryFromID;
        public int CountryToID;

        public Flight(int AirlineID, int CountryFromID, int CountryToID)
        {
            this.AirlineID = AirlineID;
            this.CountryFromID = CountryFromID;
            this.CountryToID = CountryToID;
        }
    }
}
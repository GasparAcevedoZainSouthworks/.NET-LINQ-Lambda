using System;

namespace NET_LINQ_LAMBDA.Models
{
    public class Airline
    {
        public int ID;
        public string Name;
        public int CountryID;

        public Airline(int ID, string Name, int CountryID)
        {
            this.ID = ID;
            this.Name = Name;
            this.CountryID = CountryID;
        }
    }
}
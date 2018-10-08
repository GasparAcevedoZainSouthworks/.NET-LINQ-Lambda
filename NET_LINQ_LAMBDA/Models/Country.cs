using System;

namespace NET_LINQ_LAMBDA.Models
{
    public class Country
    {
        public int ID;
        public string Name;

        public Country(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
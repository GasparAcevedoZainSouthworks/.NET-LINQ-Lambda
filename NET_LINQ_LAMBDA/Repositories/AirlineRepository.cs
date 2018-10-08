using System;
using System.Collections.Generic;
using NET_LINQ_LAMBDA.Models;

namespace NET_LINQ_LAMBDA.Repositories
{
    public class AirlineRepository
    {
        private static readonly AirlineRepository airlineRepository = new AirlineRepository();

        private List<Airline> airlines;

        private AirlineRepository()
        {
            airlines = new List<Airline>()
            {
                new Airline(1,"Argentinian Airways", 1),
                new Airline(2,"Brasilian Airways", 2),
                new Airline(3,"Chilean Airways", 3),
                new Airline(4,"Charrua Airways", 4)
            };
        }

        public static AirlineRepository GetRepository()
        {
            return airlineRepository;
        }

        public List<Airline> GetAirlines()
        {
            return this.airlines;
        }
    }
}
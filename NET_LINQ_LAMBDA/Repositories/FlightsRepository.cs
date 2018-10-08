using System;
using System.Collections.Generic;
using NET_LINQ_LAMBDA.Models;

namespace NET_LINQ_LAMBDA.Repositories
{
    public class FlightRepository
    {
        private static readonly FlightRepository flightRepository = new FlightRepository();

        private List<Flight> flights;

        private FlightRepository()
        {
            flights = new List<Flight>()
            {
                new Flight(1, 1, 2),
                new Flight(1, 1, 3),
                new Flight(1, 1, 4),
                new Flight(1, 2, 1),
                new Flight(1, 3, 1),
                new Flight(1, 4, 1),
                new Flight(1, 2, 3),
                new Flight(1, 3, 2),

                new Flight(2, 2, 1),
                new Flight(2, 2, 3),
                new Flight(2, 2, 4),
                new Flight(2, 1, 2),
                new Flight(2, 3, 2),
                new Flight(2, 4, 2),
                new Flight(2, 1, 3),
                new Flight(2, 3, 1),

                new Flight(3, 3, 1),
                new Flight(3, 3, 2),
                new Flight(3, 3, 4),
                new Flight(3, 1, 3),
                new Flight(3, 2, 3),
                new Flight(3, 4, 3),

                new Flight(4, 4, 1),
                new Flight(4, 1, 4),
            };
        }

        public static FlightRepository GetRepository()
        {
            return flightRepository;
        }

        public List<Flight> GetFlights()
        {
            return this.flights;
        }
    }
}
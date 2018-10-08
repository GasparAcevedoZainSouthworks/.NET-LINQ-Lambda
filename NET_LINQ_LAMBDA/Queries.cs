using System;
using System.Linq;
using System.Collections.Generic;
using NET_LINQ_LAMBDA.Models;
using NET_LINQ_LAMBDA.Repositories;

namespace NET_LINQ_LAMBDA
{
    public class Queries
    {
        private static readonly Queries queries = new Queries();

        private List<Airline> airlines;
        private List<Country> countries;
        private List<Flight> flights;

        private Queries()
        {
            this.flights = FlightRepository.GetRepository().GetFlights();
            this.airlines = AirlineRepository.GetRepository().GetAirlines();
            this.countries = CountryRepository.GetRepository().GetCountries();
        }

        public static Queries GetInstance()
        {
            return queries;
        }

        public int GetCountryID(string Name)
        {
            var countriesList = this.countries.Where(ctry => ctry.Name == Name);

            if(countriesList == null || countriesList.Count() == 0)
                return 0;

            Country country = countriesList.First();

            return country == null ? 0 : country.ID;
        }

        public int GetAirlineID(string Name)
        {
            var airlineList = this.airlines.Where(aline => aline.Name == Name);

            if(airlineList == null || airlineList.Count() == 0)
                return 0;

            Airline airline = airlineList.First();

            return airline == null ? 0 : airline.ID;
        }

        public List<string> GetAirlinesWithFlightsToCountry(int countryID)
        {
            var flightsToCountry = 
                from flight in this.flights
                join airline in this.airlines
                    on flight.AirlineID equals airline.ID
                where flight.CountryToID == countryID
                group airline by airline.Name into airlineGroup
                select airlineGroup.Key;

            return flightsToCountry.ToList();
        }

        public List<string> GetFlightsByAirline(int airlineID)
        {
            var airlineFlights =
                from flight in this.flights
                join countryTo in this.countries
                    on flight.CountryToID equals countryTo.ID
                join countryFrom in this.countries
                    on flight.CountryFromID equals countryFrom.ID
                where flight.AirlineID == airlineID
                select countryFrom.Name + " --> " + countryTo.Name;

            return airlineFlights.ToList();
        }

        public List<string> GetCountriesFromWhereIcanFlyToAnother(int countryToID)
        {
            var countriesFrom =
                this.flights.Where(flg => flg.CountryToID == countryToID)
                    .Join(this.countries, flg => flg.CountryFromID, ctry => ctry.ID, 
                    (flg, ctry) => new
                    {
                        ctry.Name
                    })
                    .GroupBy(ctr => ctr.Name)
                    .Select(grp => grp.First());

            if(countriesFrom == null ||countriesFrom.Count() == 0)
                return new List<string>();

            return countriesFrom.Select( x => x.Name).ToList();
        }
    }
}
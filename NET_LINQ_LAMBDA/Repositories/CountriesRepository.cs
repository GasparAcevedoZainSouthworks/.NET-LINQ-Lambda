using System;
using System.Collections.Generic;
using NET_LINQ_LAMBDA.Models;

namespace NET_LINQ_LAMBDA.Repositories
{
    public class CountryRepository
    {
        private static readonly CountryRepository countryRepository = new CountryRepository();

        private List<Country> countries;

        private CountryRepository()
        {
            countries = new List<Country>()
            {
                new Country(1, "Argentina"),
                new Country(2, "Brasil"),
                new Country(3, "Chile"),
                new Country(4, "Uruguay")
            };
        }

        public static CountryRepository GetRepository()
        {
            return countryRepository;
        }

        public List<Country> GetCountries()
        {
            return this.countries;
        }
    }
}
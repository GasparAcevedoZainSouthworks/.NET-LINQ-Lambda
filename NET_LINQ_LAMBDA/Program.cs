using System;

namespace NET_LINQ_LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Queries queries = Queries.GetInstance();

            Console.WriteLine("Airlines which have flights to Chile:");
            foreach(string country in 
                    queries.GetAirlinesWithFlightsToCountry(queries.GetCountryID("Chile")))
            {
                Console.WriteLine("\n\t*" + country);
            }

            Console.WriteLine("Flights of 'Argentinian Airways':");
            foreach(string flight in 
                    queries.GetFlightsByAirline(queries.GetAirlineID("Argentinian Airways")))
            {
                Console.WriteLine("\n\t*" + flight);
            }

            Console.WriteLine("Countries from where I can fly to Brasil");
            foreach(string ctry in 
                    queries.GetCountriesFromWhereIcanFlyToAnother(queries.GetCountryID("Brasil")))
            {
                Console.WriteLine("\n\t*" + ctry);
            }
        }
    }
}

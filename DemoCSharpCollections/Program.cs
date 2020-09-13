using System;

namespace DemoCSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new CsvReader(@"../BeginningCSharpCollections/Pop by Largest Final.csv");
            
            var countries = reader.ReadAllCountriesFromCsv();

            foreach (var country in countries)
            {
                System.Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
            }
        }
    }
}

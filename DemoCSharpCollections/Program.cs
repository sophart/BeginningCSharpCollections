﻿using System;

namespace DemoCSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new CsvReader(@"C:\Users\Sophart\Desktop\Dev\pluralsight\BeginningCSharpCollections\Pop by Largest Final.csv");
            
            var countries = reader.ReadNCountriesFromCsv(10);

            foreach (var country in countries)
            {
                System.Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)} : {country.Name}");
            }
        }
    }
}

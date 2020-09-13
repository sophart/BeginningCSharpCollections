using System.Collections.Generic;
using System.IO;

namespace DemoCSharpCollections
{
    class CsvReader
    {
        private string _filePath;

        public CsvReader(string filePath)
        {
            _filePath = filePath;
        }

        public List<Country> ReadAllCountriesFromCsv()
        {
            var countries = new List<Country>();

            using (var sr = new StreamReader(_filePath))
            {
                //Read Header Line
                sr.ReadLine();

                while(sr.ReadLine() != null)
                {
                    var country  = ReadCountryFromCsvLine(sr.ReadLine());
                    countries.Add(country);
                }
            }
            return countries;
        }

        private Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            var name = parts[0];
            var code = parts[1];
            var region = parts[2];
            var population = int.Parse(parts[3]);
            return new Country(name, code, region, population);
        }
    }
}
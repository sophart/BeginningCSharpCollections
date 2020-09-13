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

        public Country[] ReadNCountriesFromCsv(int nCountries)
        {
            var countries = new Country[nCountries];

            using (var sr = new StreamReader(_filePath))
            {
                //Read Header Line
                sr.ReadLine();

                for (int i = 0; i < nCountries; i++)
                {
                    var country  = ReadCountryFromCsvLine(sr.ReadLine());
                    countries[i] = country;
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
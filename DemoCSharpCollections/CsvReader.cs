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
            return null;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
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
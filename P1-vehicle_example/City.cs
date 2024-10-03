namespace Practice1 {
    class City: IMessageWritter {

        private PoliceStation cityPoliceStation;
        private string cityName;
        private List<string> taxyLicenses;

        public City(string cityName) {
            this.cityName = cityName;
            cityPoliceStation = new PoliceStation();
            taxyLicenses = new List<string>();
        }

        public void RegisterTaxiLicense(string license) {
            taxyLicenses.Add(license);
            Console.WriteLine(WriteMessage($"Taxi license {license} registered."));
        }

        public void TakeTaxiLicense(string license) {
            taxyLicenses.Remove(license);
            Console.WriteLine(WriteMessage($"Taxi license {license} taken."));
        }

        public string WriteMessage(string message) {
            return $"{cityName}: {message}";
        }


    }
}

namespace Practice1 {
    class City: IMessageWritter {

        private string cityName;
        private List<string> taxyLicenses;
        private List<PoliceStation> policeStations; 

        public City(string cityName) {
            this.cityName = cityName;
            taxyLicenses = new List<string>();
            policeStations = new List<PoliceStation>();
        }

        public void AddPoliceStation(PoliceStation policeStation) {
            policeStations.Add(policeStation);
            Console.WriteLine(WriteMessage($"Police station {policeStation.GetStationName()} added."));
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

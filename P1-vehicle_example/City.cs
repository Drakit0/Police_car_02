namespace Practice1 {
    class City: IMessageWritter {

        private string cityName;
        private List<string> taxiLicenses;
        private List<PoliceStation> policeStations; 

        public City(string cityName) {
            this.cityName = cityName;
            taxiLicenses = new List<string>();
            policeStations = new List<PoliceStation>();
        }

        public void AddPoliceStation(PoliceStation policeStation) {
            policeStations.Add(policeStation);
            Console.WriteLine(WriteMessage($"Police station {policeStation.GetStationName()} added."));
        }

        public void RegisterTaxiLicense(string license) {
            taxiLicenses.Add(license);
            Console.WriteLine(WriteMessage($"Taxi license {license} registered."));
        }

        public void TakeTaxiLicense(string license) {
            taxiLicenses.Remove(license);
            Console.WriteLine(WriteMessage($"Taxi license {license} taken."));
        }

        public string WriteMessage(string message) {
            return $"{cityName}: {message}";
        }

    }
}

namespace Practice1 {
    class PoliceStation: IMessageWritter {

        private string stationName;
        private List<PoliceCar> policeCars;
        private Dictionary<string, List<PoliceCar> > chasedVehicles;

        public PoliceStation(string stationName) {
            policeCars = new List<PoliceCar>();
            chasedVehicles = new Dictionary<string, List<PoliceCar>>();
            this.stationName = stationName;
        }

        public string GetStationName() {
            return stationName;
        }

        public void AddPoliceCar(PoliceCar policeCar) {
        policeCars.Add(policeCar);
        Console.WriteLine(WriteMessage($"{policeCar} with plate {policeCar.GetPlate()} registered."));
        }

        public void SendInfraction(string plate) {
            if (plate != "") {
                List<PoliceCar> freePoliceCars = new List<PoliceCar>();

                foreach (PoliceCar policeCar in policeCars) {
                    policeCar.ChaseVehicle(plate);
                    if (policeCar.IsPatrolling() && !policeCar.IsChasing()) {
                        freePoliceCars.Add(policeCar);
                    }
                }

                chasedVehicles[plate] = freePoliceCars;

                Console.WriteLine(WriteMessage($"Infraction sent for vehicle with plate {plate}."));
            }
        }

        public void DeactivateInfraction(string plate) {
            foreach (PoliceCar policeCar in chasedVehicles[plate]) {
                policeCar.StopChassing();
            }

            Console.WriteLine(WriteMessage($"Infraction deactivated for vehicle with plate {plate}."));

        }
        public string WriteMessage(string message) {
            return $"Police station {this.stationName} : {message}";
        }
    }
}

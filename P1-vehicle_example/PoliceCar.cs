namespace Practice1 {
    class PoliceCar : VehicleWithPlate {

        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private string radarType;
        private bool isChasing;
        private string chasedVehicle;
        private SpeedRadar speedRadar;
        private AlcoholRadar alcoholRadar;

        public PoliceCar(string plate, string radarType = null) : base(typeOfVehicle, plate) {
            isPatrolling = false;
            this.radarType = radarType;

            if (radarType == "Speed") {
                speedRadar = new SpeedRadar();

            }

            else if (radarType == "Alcohol") {
                alcoholRadar = new AlcoholRadar();
            }
        }

        public string UseRadar(VehicleWithPlate vehicle) {
            if (isPatrolling && (radarType is not null)) {
                string message;

                if (radarType == "Speed") {
                    speedRadar.TriggerRadar(vehicle);
                    message= speedRadar.GetLastReading();
                }

                else {
                    alcoholRadar.TriggerRadar(vehicle);
                    message  = alcoholRadar.GetLastReading();
                }

                Console.WriteLine(WriteMessage($"Triggered radar. Result: {message}"));

                return vehicle.GetPlate();

            }

            else {
                Console.WriteLine(WriteMessage($"has no active radar."));

                return "";
            }
        }

        public bool IsPatrolling() {
            return isPatrolling;
        }

        public bool IsChasing() {
            return isChasing;
        }

        public void StartPatrolling() {
            if (!isPatrolling) {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }

            else {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling() {
            if (isPatrolling) {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }

            else {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory() {
            if (radarType is not null) {
                Console.WriteLine(WriteMessage("Report radar speed history:"));

                foreach (float speed in speedRadar.ValuesHistory) {
                    Console.WriteLine(speed);
                }
            }
        }

        public void ChaseVehicle(string plate) {
            if (isPatrolling && !isChasing) {
                chasedVehicle = plate;
                isChasing = true;
                Console.WriteLine(WriteMessage($"started chasing {chasedVehicle}."));
            }

            else if (isPatrolling && isChasing) {
                Console.WriteLine(WriteMessage($"is already chasing {chasedVehicle}."));
            }

            else {
                Console.WriteLine(WriteMessage($"is not patrolling."));
            }
        }

        public void StopChassing() {
            if (isPatrolling && isChasing) {
                Console.WriteLine(WriteMessage($"stopped chasing {chasedVehicle}."));
                chasedVehicle = "";
                isChasing = false;
            }

            else if (isPatrolling && !isChasing) {
                Console.WriteLine(WriteMessage($"was not chasing."));
            }

            else {
                Console.WriteLine(WriteMessage($"is not patrolling."));
            }
        }
    }
}
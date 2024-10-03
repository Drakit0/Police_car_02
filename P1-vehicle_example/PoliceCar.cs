namespace Practice1
    {
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private bool hasRadar;
        private SpeedRadar speedRadar;
        private AlcoholRadar alcoholRadar;

        public PoliceCar(string plate, string radarType = null) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            hasRadar = false;

            if (radarType == "Speed") {
                speedRadar = new SpeedRadar();
                hasRadar = true;
            }
            else if (radarType == "Alcohol") {
                alcoholRadar = new AlcoholRadar();
                hasRadar = true;
            }
        }

        public void UseRadar(VehicleWithPlate vehicle)
        {
            if (isPatrolling & hasRadar)
            {
                speedRadar.TriggerRadar(vehicle);
                string meassurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if (hasRadar) { 
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.ValuesHistory)
                {
                    Console.WriteLine(speed);
                }
            }
        }
    }
}
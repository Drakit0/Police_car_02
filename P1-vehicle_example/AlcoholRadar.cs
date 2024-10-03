namespace Practice1 {
    class AlcoholRadar : Radar, IMessageWritter {

        private const float legalAlcohol = 0.5f;

        public AlcoholRadar() : base(legalAlcohol) {}

        public override void TriggerRadar(VehicleWithPlate vehicle) {
            plate = vehicle.GetPlate();
            value = vehicle.GetSpeed();
            ValuesHistory.Add(value);
        }

        public override string GetLastReading() {
            if (base.value > legalAlcohol) {
                return WriteMessage("Catched above legal alcohol level.");
            }
            else {
                return WriteMessage("Driving legally.");
            }
        }

        public virtual string WriteMessage(string radarReading) {
            return $"Vehicle with plate {plate} at {value.ToString()} g/l. {radarReading}";
        }
    }
}
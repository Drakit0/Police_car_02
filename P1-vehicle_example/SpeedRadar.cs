namespace Practice1 {
    class SpeedRadar : Radar, IMessageWritter {

        private const float legalSpeed = 50.0f;

        public SpeedRadar() : base(legalSpeed) {}

        public override void TriggerRadar(VehicleWithPlate vehicle) {
            plate = vehicle.GetPlate();
            value = vehicle.GetSpeed();
            ValuesHistory.Add(value);
        }

        public override string GetLastReading() {
            if (base.value > legalSpeed) {
                return WriteMessage("Catched above legal speed.");
            }
            else {
                return WriteMessage("Driving legally.");
            }
        }

        public virtual string WriteMessage(string radarReading) {
            return $"Vehicle with plate {plate} at {value.ToString()} km/h. {radarReading}";
        }
    }
}
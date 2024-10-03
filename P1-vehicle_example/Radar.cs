namespace Practice1 {
    class Radar {

        public string plate;
        public float value;
        private float legalValue;
        public List<float> ValuesHistory { get; private set; }

        public Radar(float legalValue) {
            plate = "";
            value = 0f;
            this.legalValue = legalValue;
            ValuesHistory = new List<float>();
        }

        public virtual void TriggerRadar(VehicleWithPlate vehicle) {}

        public virtual string GetLastReading() {
            return "";
        }

    }
}
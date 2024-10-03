namespace Practice1 {
    abstract class Vehicle {
        private string typeOfVehicle;
        private float alcohol;
        private float speed;

        public Vehicle(string typeOfVehicle, float alcohol = 0.0f) {
            this.typeOfVehicle = typeOfVehicle;
            speed = 0f;
            this.alcohol = alcohol;

        }

        public string GetTypeOfVehicle() {
            return typeOfVehicle;
        }

        public float GetAlcohol() {
            return alcohol;
        }

        public void SetAlcohol(float alcohol) {
            this.alcohol = alcohol;
        }

        public float GetSpeed() {
            return speed;
        }

        public void SetSpeed(float speed) {
            this.speed = speed;
        }

    }
}
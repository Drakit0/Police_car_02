namespace Practice1 {
      class VehicleNoPlate : Vehicle, IMessageWritter { //Scooter to respect the Liskov Substitution Principle

        private string typeOfVehicle;
        public VehicleNoPlate(string typeOfVehicle) : base(typeOfVehicle) {
            this.typeOfVehicle = typeOfVehicle;
        }

        public override string ToString() {
            return $"{GetTypeOfVehicle()}";
        }

        //Implment interface with Vechicle message structure
        public string WriteMessage(string message) {
            return $"{this} with no plate: {message}";
        }
    }
}

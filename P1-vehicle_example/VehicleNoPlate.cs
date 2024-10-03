namespace Practice2 {
      class VehicleNoPlate : Vehicle, IMessageWritter {

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

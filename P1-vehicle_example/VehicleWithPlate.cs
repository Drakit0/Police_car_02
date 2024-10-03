namespace Practice1 {
    abstract class VehicleWithPlate : Vehicle, IMessageWritter{

        private string plate;
        private string typeOfVehicle;

        public VehicleWithPlate(string typeOfVehicle, string plate) : base(typeOfVehicle){
            this.typeOfVehicle = typeOfVehicle;
            this.plate = plate;
        }

        public string GetPlate(){
            return plate;
        }

        public override string ToString() {
            return $"{GetTypeOfVehicle()}";
        }

        public string WriteMessage(string message){
            return $"{this} with plate {GetPlate()}: {message}";
        }
    }
    }

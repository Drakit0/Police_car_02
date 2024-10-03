namespace Practice2 {
    abstract class VehicleWithPlate : Vehicle, IMessageWritter{

        private string typeOfVehicle;
        private string plate;

        public VehicleWithPlate(string typeOfVehicle, string plate) : base(typeOfVehicle){
            this.typeOfVehicle = typeOfVehicle;
            this.plate = plate;
        }

        public override string ToString() {
            return $"{GetTypeOfVehicle()}";
        }

        public string GetPlate(){
            return plate;
        }

        //Implment interface with Vechicle message structure
        public string WriteMessage(string message){
            return $"{this} with plate {GetPlate()}: {message}";
        }
    }
    }

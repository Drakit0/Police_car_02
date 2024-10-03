namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            // Agents initialization
            City city = new City("Taxi Cab city"); 
            PoliceStation policeStation = new PoliceStation("Pig-station");
            city.AddPoliceStation(policeStation);


            Taxi taxi1 = new Taxi("BBB0001");
            city.RegisterTaxiLicense(taxi1.GetPlate());
            taxi1.StartRide();

            Taxi taxi2 = new Taxi("CBB0010");
            city.RegisterTaxiLicense(taxi2.GetPlate());

            Taxi taxi3 = new Taxi("DBB0011");
            city.RegisterTaxiLicense(taxi3.GetPlate());
            taxi3.StartRide();

            Taxi taxi4 = new Taxi("FBB0100");
            city.RegisterTaxiLicense(taxi4.GetPlate());

            Taxi taxi5 = new Taxi("GBB0101");
            city.RegisterTaxiLicense(taxi5.GetPlate());
            taxi5.StartRide();
            taxi5.StartRide();

            Taxi taxi6 = new Taxi("HBB0110");
            city.RegisterTaxiLicense(taxi6.GetPlate());


            PoliceCar policeCar1 = new PoliceCar("AAA0001");
            policeStation.AddPoliceCar(policeCar1);
            policeCar1.StartPatrolling();

            PoliceCar policeCar2 = new PoliceCar("EAA0010", "Speed");
            policeStation.AddPoliceCar(policeCar2);
            policeCar2.StartPatrolling();

            PoliceCar policeCar3 = new PoliceCar("IAA0011", "Alcohol");
            policeStation.AddPoliceCar(policeCar3);
            policeCar3.StartPatrolling();
            PoliceCar policeCar4 = new PoliceCar("OAA0100");
            policeStation.AddPoliceCar(policeCar4);


            Console.WriteLine();


            // Start chase
            policeCar1.UseRadar(taxi1);
            string chasedPlate = policeCar2.UseRadar(taxi3);
            policeStation.SendInfraction(chasedPlate);


            Console.WriteLine("\nPress any key to end the chase");

            Console.ReadLine();


            // Stop chase
            policeStation.DeactivateInfraction(chasedPlate);
            city.TakeTaxiLicense(chasedPlate);

        }
    }
}
    


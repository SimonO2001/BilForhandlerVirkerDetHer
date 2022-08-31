namespace Bilforhandler
{
    internal class CarSpecifications
    {

        

        

        public int Price 
        {
            get
            {
                Random rnd = new Random();
                int price = rnd.Next(15000, 999999);

                return price;

            }

        }

        public string? Color 
        {
            get
            {
                Random rnd = new Random();
                int color = rnd.Next(0, 6);

                string[] Colors = { "Black", "White", "Red", "Blue", "Yellow", "Green" };



                return Colors[color];
            }
        }

        public string? Transmission 
        {
            get 
            {
                Random rnd = new Random();
                int trans = rnd.Next(0, 2);

                string[] Transmissions = { "Manual", "Automatic" };

                return Transmissions[trans];
            }

        }

        public string? Fuel 
        {
            get 
            {
                Random rnd = new Random();
                int fuel = rnd.Next(0, 2);

                string[] DriveFuel = { "Gasoline", "Diesel" };

                return DriveFuel[fuel];

            }
        }


        public void GetCarEquipment()
        {
            List<string> carEquipment = new List<string>();
            carEquipment.Add("Heated Seats");
            carEquipment.Add("Touch Screen");
            carEquipment.Add("18'' Aluminium Rims");
            carEquipment.Add("Sun Roof");
            carEquipment.Add("Heated Steering Wheel");
            carEquipment.Add("Leather Seats");
            carEquipment.Add("Upgraded Audio");
            carEquipment.Add("Tinted Windows");
            carEquipment.Add("Metalic Paint");
            carEquipment.Add("Sports Package");

            Random rnd = new Random();
            int ranNum = rnd.Next(0, 11);

            List<string> finalCarEquipment = new List<string>();

            for (int i = 0; i < ranNum; i++)
            {
                finalCarEquipment.Add(carEquipment[i]);
            }


            for (int i = 0; i < finalCarEquipment.Count; i++)
            {
                Console.WriteLine(finalCarEquipment[i]);
            }
        }

        public int HorsePower
        {
            get
            {
                Random rnd = new Random();
                int hp = rnd.Next(0, 1000);

                return hp;

            }

        }

        public int Torque
        {
            get
            {
                Random rnd = new Random();
                int tor = rnd.Next(0, 1000);

                return tor;

            }

        }



    }

    


}

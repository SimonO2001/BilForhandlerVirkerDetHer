namespace Bilforhandler
{
    internal class CarDealer : CarSpecifications
    {

        CarSpecifications car = new CarSpecifications();
        CarPictures picture = new CarPictures();

        public List<string> saveCar = new List<string>();

        public void LoadMenu()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("#######################################################################################################################");
                Thread.Sleep(10);
            }
            Console.Clear();
            
        }

        public void LoadMenu2()
        {
            Console.WriteLine(" ░█████╗░██╗░░██╗░██████╗███████╗███╗░░██╗██╗░██████╗ ");
            Thread.Sleep(30);
            Console.WriteLine(" ██╔══██╗██║░██╔╝██╔════╝██╔════╝████╗░██║╚█║██╔════╝ ");
            Thread.Sleep(30);
            Console.WriteLine(" ██║░░██║█████═╝░╚█████╗░█████╗░░██╔██╗██║░╚╝╚█████╗░ ");
            Thread.Sleep(30);
            Console.WriteLine(" ██║░░██║██╔═██╗░░╚═══██╗██╔══╝░░██║╚████║░░░░╚═══██╗ ");
            Thread.Sleep(30);
            Console.WriteLine(" ╚█████╔╝██║░╚██╗██████╔╝███████╗██║░╚███║░░░██████╔╝ ");
            Thread.Sleep(30);
            Console.WriteLine(" ░╚════╝░╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚══╝░░░╚═════╝░ ");
            Thread.Sleep(30);
            Console.WriteLine("");
            Thread.Sleep(30);
            Console.WriteLine(" ░█████╗░░█████╗░██████╗░██████╗░███████╗░█████╗░██╗░░░░░███████╗██████╗░ ");
            Thread.Sleep(30);
            Console.WriteLine(" ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗██║░░░░░██╔════╝██╔══██╗ ");
            Thread.Sleep(30);
            Console.WriteLine(" ██║░░╚═╝███████║██████╔╝██║░░██║█████╗░░███████║██║░░░░░█████╗░░██████╔╝ ");
            Thread.Sleep(30);
            Console.WriteLine(" ██║░░██╗██╔══██║██╔══██╗██║░░██║██╔══╝░░██╔══██║██║░░░░░██╔══╝░░██╔══██╗ ");
            Thread.Sleep(30);
            Console.WriteLine(" ╚█████╔╝██║░░██║██║░░██║██████╔╝███████╗██║░░██║███████╗███████╗██║░░██║ ");
            Thread.Sleep(30);
            Console.WriteLine(" ░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝\n ");

            Console.WriteLine(" ┌──┐░░░░░░░┌┐░┌┐░░░┌──┐░░░░░░┌─┐░░┌─┐░░░░┌─┐░░ ");
            Console.WriteLine(" └┐┌┼┬┬─┬─┐┌┘│░│└┬─┐│┌┐├┬┬─┬┬┬┤─┼─┐│┌┼─┐┌┬┤─┤░░ ");
            Console.WriteLine(" ░│││││┼│┴┤└┐│░│┌┤┼││┌┐│┌┤┼│││├─│┴┤│└┤┼└┤┌┼─│┌┐ ");
            Console.WriteLine(" ░└┘├┐│┌┴─┘░││░└─┴─┘└──┴┘└─┴──┴─┴─┘└─┴──┴┘└─┘└┘ ");
            Console.WriteLine(" ░░░└─┴┘░░░┌┘└┐░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░ ");

            Console.WriteLine();
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    BrowseCars();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    
                    break;
                default:
                    break;
            }


        }

        public void BrowseCars()
        {
            Console.Clear();
            GetCarPicture();

            if (car.Price > 500000)
            {
                Console.WriteLine($"Buy now: {car.Price}, expensive maybe");
            }
            else
            {
                Console.WriteLine($"Buy now: {car.Price}, cheap cheap");
            }

            Console.WriteLine($"Color: {car.Color}");

            Console.WriteLine($"The cars transmission is: {car.Transmission}");

            Console.WriteLine($"This car have {car.HorsePower} HP / {car.Torque} TORQUE");

            Console.WriteLine($"And the car drives on {car.Fuel}");


            Console.WriteLine("List of equipment(s)");
            GetCarEquipment();


            Console.WriteLine("Want to add to list? (Y/N)");
            

            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                

                saveCar.Add(car.Color);



            }
            Console.WriteLine(saveCar[0]);
        }

        public void GetCarPicture()
        {
            if (car.HorsePower > 500)
            {
                Console.WriteLine(picture.super);
            }
            else
            {
                Console.WriteLine("Du lugter");
            }



        }




    }
}


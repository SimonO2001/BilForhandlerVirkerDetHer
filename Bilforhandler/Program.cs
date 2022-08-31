namespace Bilforhandler
{
    public class program
    {
        static void Main(string[] args)
        {

            CarSpecifications car = new CarSpecifications();
            CarDealer carDealer = new CarDealer();


            //carDealer.LoadMenu();

            //carDealer.LoadMenu2();

            carDealer.BrowseCars();

            


            //Console.WriteLine(car.Price);
            //Console.WriteLine(car.Color);
            //Console.WriteLine(car.Transmission);
            //Console.WriteLine(car.Fuel);
            ////Console.WriteLine(car.CarEquipment);
        }




    }



}
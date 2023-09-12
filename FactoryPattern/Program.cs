namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose what type of vehicle you want my the amount of tiers it has ");
            int vehicle = int.Parse(Console.ReadLine());
            IVehicle vehicle1 = VehicleFactory.GetVehicle(vehicle);

            Console.WriteLine();
            Console.WriteLine($"{vehicle1.Name}");
            vehicle1.NumOfTiers();
            Console.WriteLine($"{vehicle1.Discription}");

        }
    }
}

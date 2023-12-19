namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The Orange Cessna flys past you. Weeeeeeee!");
        }

        public override void Stop()
        {
            Console.WriteLine("The Orange Cessna carefully stopped.");
        }

    }
}
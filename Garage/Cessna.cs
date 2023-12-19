namespace Garage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }

         public string Name { get; set; } = string.Empty;

        public void RefuelTank()
        {
              CurrentTankPercentage = 100.0;
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
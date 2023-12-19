namespace Garage
{
    public class Ram : Vehicle, IGas // Gas powered truck
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
            Console.WriteLine("The Red Ram growls past you. Rrrrrrumble!");
        }

        public override void Stop()
        {
            Console.WriteLine("The Red Ram carefully stopped.");
        }
    }
}
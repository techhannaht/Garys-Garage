namespace Garage
{
    public class Tesla : Vehicle, IElectric // Electric car
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }

        public string Name { get; set; } = string.Empty;
        public void ChargeBattery()
        {
            // Charging logic
            CurrentChargePercentage = 100.0;
        }
        public override void Drive()
        {
            Console.WriteLine("The White Tesla zooms past you. Zoooooom!");
        }

    }

}
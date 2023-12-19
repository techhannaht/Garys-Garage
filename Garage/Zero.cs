namespace Garage
{
    public class Zero : Vehicle, IElectric // Electric motorcycle
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
            Console.WriteLine("The Blue Zero skates past you. WUSHHHHHHHHH!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine("TThe Blue Zero forgot to turn!!!!!");
        }

    }
}
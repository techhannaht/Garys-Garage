namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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
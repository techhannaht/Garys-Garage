namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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
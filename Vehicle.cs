namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; } = string.Empty;
        public int MaximumOccupancy { get; set; }

         public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

         public virtual void Turn(string direction)
        {
            Console.WriteLine("The car quickly veers right.");
        }

         public virtual void Stop()
        {
            Console.WriteLine("The vehicle abruptly comes to a stop.");
        }

    }
}





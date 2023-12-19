using System.Runtime.CompilerServices;

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

        public virtual void Electric()
        {
            Console.WriteLine("I am Electric.");
        }

          public virtual void Gas()
        {
            Console.WriteLine("I am gas car.");
        }

    }

    public interface IElectric
    {
        void Electric();
        double CurrentChargePercentage { get; set; }
        void ChargeBattery();
        string Name { get; set; }

    }

       public interface IGas
    {
        void Gas();
        double CurrentTankPercentage { get; set; }
        void RefuelTank();
        string Name { get; set; }

    }
}





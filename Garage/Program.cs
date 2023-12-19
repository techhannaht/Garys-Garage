namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();


            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

            modelS.Name = "modelS";
            fx.Name = "fx";
            fxs.Name = "fxs";

            fx.CurrentChargePercentage = 50;
            fxs.CurrentChargePercentage = 70;
            modelS.CurrentChargePercentage = 75;

            Console.WriteLine("Electric Vehicles");
            Console.WriteLine("_________________");
            Console.WriteLine("Current Battery Percent:");

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.Name}:{ev.CurrentChargePercentage}%");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            Console.WriteLine("_________________");
            Console.WriteLine("After Charge:");

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.Name}:{ev.CurrentChargePercentage}%");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
            };

            ram.Name = "ram";
            ram.CurrentTankPercentage = 50;
            cessna150.Name = "cessna150";
            cessna150.CurrentTankPercentage = 60;


            Console.WriteLine("Gas Vehicles");
            Console.WriteLine("_________________");
            Console.WriteLine("Current Tank Percentage:");


            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.Name}:{gv.CurrentTankPercentage}%");
            }

            foreach (IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

              Console.WriteLine("_________________");
            Console.WriteLine("After Refuel:");

            foreach (IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.Name}:{gv.CurrentTankPercentage}%");
            }
        }
    }
}
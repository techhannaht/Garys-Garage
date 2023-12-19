namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram Rx50 = new Ram();

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();


            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

            Rx50.Drive();
            Rx50.Turn("left");
            Rx50.Stop();
        }
    }
}
using FacadePattern.Models.Contracts;

namespace FacadePattern.Models
{
    public class FuelPump : IFuelPump
    {
        private const string FuelPumpStarted = "Fuel pump started";
        private const string FuelPumpStopped = "Fuel pump stopped";
        public void Start()
        {
            Console.WriteLine($"\t{FuelPumpStarted}");
        }

        public void Stop()
        {
            Console.WriteLine($"\t{FuelPumpStopped}");
        }
    }
}

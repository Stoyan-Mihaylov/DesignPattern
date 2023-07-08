using FacadePattern.Models.Contracts;

namespace FacadePattern.Models
{
    public class CoolingPump : ICoolingPump
    {
        private const string CoolingPumpStarted = "Cooling pump started";
        private const string CoolingPumpStopped = "Cooling pump stopped";
        public void Start()
        {
            Console.WriteLine($"\t{CoolingPumpStarted}");
        }

        public void Stop()
        {
            Console.WriteLine($"\t{CoolingPumpStopped}");
        }
    }
}

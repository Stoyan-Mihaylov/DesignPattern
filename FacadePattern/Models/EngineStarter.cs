using FacadePattern.Models.Contracts;

namespace FacadePattern.Models
{
    public class EngineStarter : IEngineStarter
    {
        private const string EngineStarterStarted = "Engine starter enabled";
        public void Start()
        {
            Console.WriteLine($"\t{EngineStarterStarted}");
        }
    }
}

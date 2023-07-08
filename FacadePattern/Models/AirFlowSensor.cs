using FacadePattern.Models.Contracts;

namespace FacadePattern.Models
{
    public class AirflowSensor : IAirflowSensor
    {
        private const string AirFlowSensorEnabled = "Airflow sensor enabled";
        private const string AirFlowSensorDisabled = "Airflow sensor disabled";
        public void Enable()
        {
            Console.WriteLine($"\t{AirFlowSensorEnabled}");
        }

        public void Disable()
        {
            Console.WriteLine($"\t{AirFlowSensorDisabled}");
        }
    }
}

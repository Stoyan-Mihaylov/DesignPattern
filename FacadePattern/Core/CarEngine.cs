using FacadePattern.Models.Contracts;

namespace FacadePattern.Core
{
    public class CarEngine : ICarEngine
    {
        private readonly IAirflowSensor _airflowSensor;
        private readonly ICoolingPump _coolingPump;
        private readonly IEngineStarter _engineStarter;
        private readonly IFuelPump _fuelPump;

        public CarEngine(
            IAirflowSensor airflowSensor,
            ICoolingPump coolingPump,
            IEngineStarter engineStarter,
            IFuelPump fuelPump)
        {
            _airflowSensor = airflowSensor;
            _coolingPump = coolingPump;
            _engineStarter = engineStarter;
            _fuelPump = fuelPump;
        }
        public void Start()
        {
            Console.WriteLine("Car engine started:");
            _airflowSensor.Enable();
            _fuelPump.Start();
            _engineStarter.Start();
            _coolingPump.Start();
        }

        public void Stop()
        {
            Console.WriteLine("Car engine stopped:");
            _fuelPump.Stop();
            _coolingPump.Stop();
            _airflowSensor.Disable();
        }
    }
}

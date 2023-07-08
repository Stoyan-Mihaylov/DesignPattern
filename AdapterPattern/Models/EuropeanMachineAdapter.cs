using AdapterPattern.Models.Contracts;

namespace AdapterPattern.Models
{
    public class EuropeanMachineAdapter : IAdapter
    {
        private readonly UsMachineCalculator _usMachineCalculator;

        public EuropeanMachineAdapter(UsMachineCalculator usMachineCalculator)
        {
            _usMachineCalculator = usMachineCalculator;
        }

        public decimal GetSpeed(decimal distanceInMiles, decimal timeInHours)
        {
            var kilometerMultiplier = 1.60934m;
            decimal speedInMph = _usMachineCalculator.GetSpeed(distanceInMiles, timeInHours);
            decimal speedInKmPerHour = speedInMph * kilometerMultiplier;

            return speedInKmPerHour;
        }
    }
}

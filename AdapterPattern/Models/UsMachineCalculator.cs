namespace AdapterPattern.Models
{
    public class UsMachineCalculator
    {
        public decimal GetSpeed(decimal distanceInMiles, decimal timeInHours)
        {
            return distanceInMiles / timeInHours;
        }
    }
}

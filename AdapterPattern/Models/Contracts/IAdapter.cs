namespace AdapterPattern.Models.Contracts
{
    public interface IAdapter
    {
        public decimal GetSpeed(decimal distanceInMiles, decimal timeInHours);
    }
}

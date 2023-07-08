using AdapterPattern.Models;
using AdapterPattern.Models.Contracts;
using System;

namespace AdapterPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            UsMachineCalculator usMachineCalculator = new UsMachineCalculator();
            IAdapter europeMachineAdapter = new EuropeanMachineAdapter(usMachineCalculator);

            var distanceInMiles = 100m;
            var timeInHours = 2m;

            var speedInMph = (int)usMachineCalculator.GetSpeed(distanceInMiles, timeInHours);
            var speedInKmh = (int)europeMachineAdapter.GetSpeed(distanceInMiles, timeInHours);

            Console.WriteLine($"Speed in mp/h: {speedInMph}");
            Console.WriteLine($"Speed in km/h: {speedInKmh}");
        }
    }
}
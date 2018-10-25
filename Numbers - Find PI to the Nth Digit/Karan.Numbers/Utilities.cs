using System;

namespace Karan.Numbers
{
    public static class Utilities
    {
        public static string GetPiToTheNthDigit(int n)
        {
            if(n < 1 || n > 14)
            {
                throw new ArgumentException("Must be between 1 and 14", nameof(n));
            }

            // PI can be calculated independently as (4 * Math.Atan(1d/5) - Math.Atan(1d/239)) * 4
            // TODO: find way to calculate and store more than the digit limit for double
            return Math.PI.ToString().Substring(0, n + 2);
        }
    }
}

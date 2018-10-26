using System;

namespace Karan.FindEToTheNthDigit
{
    public static class Utilities
    {
        public static string GetEToTheNthDigit(int n)
        {
            if (n < 1 || n > 14)
            {
                throw new ArgumentException("Must be between 1 and 14", nameof(n));
            }

            // TODO: find way to calculate E independently
            // TODO: find way to calculate and store more than the digit limit for double
            return Math.E.ToString().Substring(0, n + 2);
        }
    }
}

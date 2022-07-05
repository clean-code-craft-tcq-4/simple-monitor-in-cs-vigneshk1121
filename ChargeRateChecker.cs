using System;

namespace Checker
{
    public class ChargeRateChecker
    {
        public ChargeRateChecker()
        {

        }

        public bool IsValueWithinRange(float value)
        {
            var result = (value > Limits.PERMISSIBLE_CHARGE_RATE);
            if (result)
            {
                Console.WriteLine("Charge Rate is out of range!");
            }

            return result;
        }
    }
}

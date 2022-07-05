using System;

namespace Checker
{
    public class TemperatureChecker : CheckerBase
    {
        public TemperatureChecker() : base(Limits.MIN_TEMPERATURE, Limits.MAX_TEMPERATURE)
        {

        }

        public new bool IsValueWithinRange(float value)
        {
            bool val = base.IsValueWithinRange(value);
            if (val)
            {
                Console.WriteLine("Temperature is out of range!");
            }
            return val;
        }
    }
}

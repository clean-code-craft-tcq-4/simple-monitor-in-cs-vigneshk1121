using System;

namespace Checker
{
    public class CheckerBase
    {
        public float? MinValue { get; set; }

        public float MaxValue { get; set; }

        public CheckerBase(float minValue, float maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public bool IsValueWithinRange(float value)
        {
            return (value < MinValue || value > MaxValue);
        }
    }

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

    public class SocChecker : CheckerBase
    {
        public SocChecker() : base(Limits.MIN_SOC, Limits.MAX_SOC)
        {

        }

        public new bool IsValueWithinRange(float value)
        {
            bool val = base.IsValueWithinRange(value);
            if (val)
            {
                Console.WriteLine("State of Charge is out of range!");
            }
            return val;
        }
    }

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

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
    }

    public class SocChecker : CheckerBase
    {
        public SocChecker() : base(Limits.MIN_SOC, Limits.MAX_SOC)
        {

        }
    }

    public class ChargeRateChecker
    {
        public ChargeRateChecker()
        {

        }

        public bool IsValueWithinRange(float value)
        {
            return (value > Limits.PERMISSIBLE_CHARGE_RATE);
        }
    }
}

namespace Checker
{

    public abstract class CheckerBase
    {
        public float? MinValue { get; set; }

        public float MaxValue { get; set; }

        protected CheckerBase(float? minValue, float maxValue)
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
        public TemperatureChecker(float minValue, float maxValue) : base(minValue, maxValue)
        {

        }
    }

    public class SocChecker : CheckerBase
    {
        public SocChecker(float minValue, float maxValue) : base(minValue, maxValue)
        {

        }
    }

    public class ChargeRateChecker : CheckerBase
    {
        public ChargeRateChecker(float? minValue, float maxValue) : base(minValue, maxValue)
        {

        }
    }
}

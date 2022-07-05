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
}

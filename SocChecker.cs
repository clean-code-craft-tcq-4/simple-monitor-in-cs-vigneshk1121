using System;

namespace Checker
{
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
}

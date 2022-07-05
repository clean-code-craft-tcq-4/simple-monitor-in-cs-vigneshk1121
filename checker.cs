using System;

namespace Checker
{
    internal static class Checker
    {
        static bool BatteryIsOk(float temperature, float soc, float chargeRate)
        {
            return !(new TemperatureChecker().IsValueWithinRange(temperature)
                || new SocChecker().IsValueWithinRange(soc)
                || new ChargeRateChecker().IsValueWithinRange(chargeRate));
        }

        static void ExpectedResult(bool expression, bool expectedResult)
        {
            if (expression && !expectedResult)
            {
                Console.WriteLine("Expected" + expectedResult.ToString() + " , but got" + !expectedResult);
                Environment.Exit(1);
            }
        }

        static int Main()
        {
            ExpectedResult(BatteryIsOk(25, 70, 0.7f), true);
            ExpectedResult(BatteryIsOk(50, 85, 0.0f), false);
            Console.WriteLine("All ok");
            return 0;
        }
    }
}

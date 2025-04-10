using System;
using d;

namespace a
{
    class DeviationChecker
    {
        static double meanValue;
        public static bool calculate(List<double> list, int length, int range, double currentValue, double threshold)
        {
            if(length + 1 <= 3)
            {
                return false;
            }
            
            double sum = 0;
            int i = 0;

            while(i < range)
            {
                sum += list[length - i];
                i++;
            }
            
            meanValue = sum / range;

            double absValue = Math.Abs(meanValue - currentValue);
            if( absValue < threshold)
                return true;
            else
                return false;
        }
    }
}
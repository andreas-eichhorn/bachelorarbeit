using System;
using processing;

namespace processing
{
    class DeviationChecker
    {
        private double meanValue;
        public static bool calculate(List<double> list, int length, int range, double currentValue, double threshold)
        {
            if(length + 1 <= 3)
            {
                return false;
            }

            double meanValue = DeviationChecker.calculateMean(list, length, range);
            return DeviationChecker.isDeviationWithinThreshold(currentValue, meanValue, threshold);
        }

        private static double calculateMean(List<double> list, int length, int range)
        {
                        
            double sum = 0;
            int i = 0;

            while(i < range)
            {
                sum += list[length - i];
                i++;
            }
            
            return sum / range;
        }
        
        private static bool isDeviationWithinThreshold(double currentValue, double meanValue, double threshold)
        {
            double absValue = Math.Abs(meanValue - currentValue);
            if( absValue < threshold)
                return true;
            return false;
        }
    }
}
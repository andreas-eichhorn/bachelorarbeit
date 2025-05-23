public class InputProcessor
{
    private static Counter counter = new Counter();
    private static List<double> convertedInputs = new List<double>();
    private static List<object> rawInputs = new List<object>();
    private const int HistoryLength = 3;
    private const double deviationThreshold = 10;
    public bool processInput(int l, object input)
    {
        if(counter.getChance() != 0 || counter.getCounter() != 0)
        {
            counter.setCounter(l);
            storeInput(input);
            double parsedDouble = convertInputToDouble(input);
            convertedInputs.Add(parsedDouble);
            validateDeviation(parsedDouble);
            counter.decreaseCounter();
            return true;
        }
        return false;
    }

    public static void storeInput(object input)
    {
        rawInputs.Add(input);
    }

    public void validateDeviation(double currentValue)
    {
        int lastIndex = convertedInputs.Count() - 1;
        if(DeviationChecker.calculate(convertedInputs, lastIndex, HistoryLength, convertedInputs[lastIndex], deviationThreshold) || DeviationChecker.calculate(convertedInputs, lastIndex, lastIndex+1, convertedInputs[lastIndex], deviationThreshold))
        {
            counter.decreaseChance();
        }
        else
        {
            counter.resetChance();
        }
    }
    public static double convertInputToDouble(object input)
    {
        double result;
        if(double.TryParse(input.ToString(), out result))
        {
            return result;
        }
        else
        {
            return StringToDoubleConverter.StringToDouble(input.ToString());
        }
    }
}
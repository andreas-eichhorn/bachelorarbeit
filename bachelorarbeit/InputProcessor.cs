using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using processing;
using Microsoft.VisualBasic;

namespace processing 
{
    class InputProcessor
    {
        static int counter;
        public static int chance = 3;
        static List<double> convertedInputs = new List<double>();
        static List<object> rawInputs = new List<object>();
        private const int HistoryLength = 3;
        private const double deviationThreshold = 10;
        public static void processInput(int counter, object input)
        {
            initializeCounter(counter);
            storeInput(input);

            double parsedDouble = convertInputToDouble(input);
            convertedInputs.Add(parsedDouble);
            
            validateDeviation(parsedDouble);

            //Console.WriteLine(InputProcessor.counter + " " + InputProcessor.chance);
            InputProcessor.counter--;
        }

        public static void initializeCounter(int counter)
        {
            if(InputProcessor.counter == 0)
            {
                InputProcessor.counter = counter;
            }
        }

        public static void storeInput(object input)
        {
            rawInputs.Add(input);
        }

        public static void validateDeviation(double currentValue)
        {
            int lastIndex = convertedInputs.Count() - 1;
            if(DeviationChecker.calculate(convertedInputs, lastIndex, HistoryLength, convertedInputs[lastIndex], deviationThreshold) || DeviationChecker.calculate(convertedInputs, lastIndex, lastIndex+1, convertedInputs[lastIndex], deviationThreshold))
            {
                InputProcessor.chance--;
            }
            else
            {
                InputProcessor.chance = 3;
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
}
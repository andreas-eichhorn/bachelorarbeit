using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using a;
using b;
using c;
using Microsoft.VisualBasic;

namespace d 
{
    class InputProcessor
    {
        static int counter;
        public static int chance = 3;
        static List<double> listOfConvertedInput = new List<double>();
        static List<object> listOfInput = new List<object>();
        public static void test(int counter, object input)
        {
            if(InputProcessor.counter == 0)
            {
                InputProcessor.counter = counter;
            }

            listOfInput.Add(input);
            string inputString = input.ToString(); 
            double a = 0;

            if(double.TryParse(inputString, out a))
            {
                //double
                listOfConvertedInput.Add(a);
            }
            else
            {
                //string
                double value = StringToDoubleConverter.StringToDouble(inputString);
                listOfConvertedInput.Add(value);
            }
            
            int length = listOfConvertedInput.Count() - 1;
            if(DeviationChecker.calculate(listOfConvertedInput, length, 3, listOfConvertedInput[length], 10))
            {
                InputProcessor.chance--;
            }
            else
            {
                if(DeviationChecker.calculate(listOfConvertedInput, length, length+1, listOfConvertedInput[length], 10))
                {
                    InputProcessor.chance--;
                }
                else
                {
                    InputProcessor.chance = 3;
                }
            }

            //Console.WriteLine(InputProcessor.counter + " " + InputProcessor.chance);
            InputProcessor.counter--;
        }
    }
}
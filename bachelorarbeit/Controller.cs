using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using a;
using b;
using c;
using Microsoft.VisualBasic;

namespace d 
{
    class Controller
    {
        static int counter;
        static int chance;
        static List<double> listOfConvertedInput = new List<double>();
        static List<object> listOfInput = new List<object>();
        public static void test(int counter, object input)
        {
            if(Controller.counter == 0)
            {
                Controller.counter = counter;
            }

            listOfInput.Add(input);
            string inputString = input.ToString(); 
            double a = 0;

            if(double.TryParse(inputString, out a))
            {
                Console.WriteLine("Double");
                listOfConvertedInput.Add(a);
            }
            else
            {
                Console.WriteLine("String");
                a = Converter.StringToDouble(inputString);
                listOfConvertedInput.Add(a);

                if(listOfInput.Count() >= 2)
                {
                    
                }
            }











            listOfInput.Add(1.5);
            listOfInput.Add("test");
            int z = listOfInput.Count() - 1;
            Console.WriteLine(listOfInput[z].GetType());
            Console.WriteLine(listOfInput[z-1].GetType());
            Controller.counter--;
        }
    }
}
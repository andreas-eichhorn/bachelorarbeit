using System.Text;

namespace Converter
{
    class Converter
    {
        public static int StringToInt(string text)
        {
            int result = 0;
            int positionOfNumber = 1;
            UTF8Encoding utf8 = new UTF8Encoding();
            var ListOfNumbers = utf8.GetBytes(text);
            foreach(var number in ListOfNumbers)
            {
                result += positionOfNumber * number;
                positionOfNumber++;
            }
            return result;
        }
        /*public static void Main()
        {
            Converter converter = new Converter();
            var result = converter.StringToInt("foo");
            Console.WriteLine(result);
        }*/
    }
}    
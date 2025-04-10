using System.Text;

namespace processing
{
    class StringToDoubleConverter
    {
        public static double StringToDouble(string text)
        {
            int encodedValue = 0;
            int positionOfNumber = 1;
            UTF8Encoding utf8 = new UTF8Encoding();
            var encodedBytes = utf8.GetBytes(text);
            foreach(var Byte in encodedBytes)
            {
                encodedValue += positionOfNumber * Byte;
                positionOfNumber++;
            }
            return encodedValue;
        }
        /*public static void Main()
        {
            Converter converter = new Converter();
            var result = converter.StringToInt("foo");
            Console.WriteLine(result);
        }*/
    }
}    
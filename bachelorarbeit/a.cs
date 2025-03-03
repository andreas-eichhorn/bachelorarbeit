using gibt;
using Converter;

class a
{
    public static void Main()
    {
        var x = 32322332;
        if(x is int)
        {
            Console.WriteLine("int");
        }
        if(x is string)
        {
            Console.WriteLine("string");
        }
    }
}
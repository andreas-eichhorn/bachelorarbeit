/**using a;
using b;
using c;

class Controller
{
    public static void Main()
    {
        List<string> listOfInputString = [];
        List<double> listOfInputDouble = [];
        double threshold = 61;
        int chanceCounter = 3;
        int iterationCounter = 10;
        //eingabe
        var input = "";
        bool isStable;
        while(chanceCounter != 0 && iterationCounter != 0)
        {
            Console.Write("Eingabe: ");
            input = Console.ReadLine();
            if(input is double || input is int)
            {
                Console.WriteLine("int");
                if(listOfInputDouble.Count() >= 2)
                {
                    
                    isStable = AverageValue.CalculateAverageValue(listOfInputDouble, threshold);
                    if(isStable)
                    {
                        chanceCounter--;
                    }
                    else
                    {
                        chanceCounter = 3;
                    }
                }
            }
            else
            {
                listOfInputString.Add(input);
                double stringValue = Converter.StringToInt(input);
                listOfInputDouble.Add(stringValue);
                if(listOfInputString.Count() >= 2)
                {   
                    string levenshteinInput01 = listOfInputString[listOfInputString.Count() - 2];
                    string levenshteinInput02 = listOfInputString[listOfInputString.Count() - 1];
                    int levenshteinDistance = LevenshteinDistance.Calculate(levenshteinInput01, levenshteinInput02);
                    if(levenshteinDistance <= 2)
                    {
                        /*double stringValue = Converter.StringToInt(input);
                        listOfInputDouble.Add(stringValue);
                        isStable = AverageValue.CalculateAverageValue(listOfInputDouble, threshold);
                        if(isStable)
                        {
                            chanceCounter--;
                        }
                        else
                        {
                            chanceCounter = 3;
                        }
                    }
                    else
                    {
                            chanceCounter = 3;
                    }
                }
            }
            iterationCounter--;
            foreach(double a in listOfInputDouble)
            {
                Console.WriteLine(a);
            }
        }
    }
}**/
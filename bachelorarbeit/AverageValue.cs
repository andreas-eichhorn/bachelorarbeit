using System;
class AverageValue
{
    public static bool CalculateAverageValue(float[] listOfValues, float threshold)
    {
        //überspringt die berechnung bis mindestens 3 werte in der liste
        if(listOfValues.Length < 3)
        {
            return false;
        }
        float sumOfValues = 0;
        //länge der übergebenen liste
        int numberOfValues = listOfValues.Length;
        //aktuellster wert aus der liste
        float currentValue = listOfValues[0];
        //iteration durch die liste
        foreach(float value in listOfValues)
        {
            //summieren der einzelnen werte
            sumOfValues += value;
        }
        float average = sumOfValues / numberOfValues;
        //aufruf der check funktion
        return distance(average, currentValue, threshold);
    }

    private static bool distance(float value01, float value02, float threshold)
    {   
        //betrag aus mittelwert und aktuellen wert
        float absValue = Math.Abs(value01 - value02);
        if( absValue < threshold)
            //wert ist nicht stabil
            return false;
        else
            //wert ist stabil
            return true;
    }
    public static void Main()
    {
        
    }
}
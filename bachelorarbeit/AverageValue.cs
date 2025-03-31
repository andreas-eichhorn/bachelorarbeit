/**using System;

namespace a
{
    class AverageValue
    {
        public static bool CalculateAverageValue(List<double> listOfValues, double threshold)
        {
            //überspringt die berechnung bis mindestens 3 werte in der liste
            if(listOfValues.Count() < 3)
            {
                return false;
            }
            double sumOfValues = 0;
            //länge der übergebenen liste
            int numberOfValues = listOfValues.Count();
            int indexOfLastValue = numberOfValues - 1;
            //aktuellster wert aus der liste
            double currentValue = listOfValues[indexOfLastValue];
            //iteration durch die liste
            foreach(double value in listOfValues)
            {
                //summieren der einzelnen werte
                sumOfValues += value;
            }
            double average = sumOfValues / numberOfValues;
            //aufruf der check funktion
            Console.WriteLine("average: " + average);
            return distance(average, currentValue, threshold);
        }

        private static bool distance(double average, double currentValue, double threshold)
        {   
            //betrag aus mittelwert und aktuellen wert
            double absValue = Math.Abs(average - currentValue);
            if( absValue < threshold)
                //wert ist nicht stabil
                return true;
            else
                //wert ist stabil
                return false;
        }
    }
}**/
/*https://gist.github.com/Davidblkx/e12ab0bb2aff7fd8072632b396538560 aufgerufen am 03.03.2025 um 05:07Uhr*/
using System;

namespace gibt
{
    class LevenshteinDistance
    {
        public static int Calculate(string source1, string source2)
        {
            var source1Length = source1.Length;
            var source2Length = source2.Length;
            var matrix = new int[source1Length + 1, source2Length + 1];
            if (source1Length == 0)
                return source2Length;
            if (source2Length == 0)
                return source1Length;
            for (var i = 0; i <= source1Length; matrix[i, 0] = i++){}
            for (var j = 0; j <= source2Length; matrix[0, j] = j++){}
            for (var i = 1; i <= source1Length; i++)
            {
                for (var j = 1; j <= source2Length; j++)
                {
                    var cost = (source2[j - 1] == source1[i - 1]) ? 0 : 1;
                    matrix[i, j] = Math.Min(
                            Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1),
                            matrix[i - 1, j - 1] + cost);
                }
            }
            return matrix[source1Length, source2Length];
        }
            
        /*public static void Main()
        {
            LevenshteinDistance result = new LevenshteinDistance();
            Console.WriteLine(result.Calculate("Buch", "Zuück"));
        }*/
    }
}        
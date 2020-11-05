/* AverageDiff.cs       Author:Doyle
 * Ten scores are entered. Average is calculated.
 * A table is printed showing how far each 
 * value is from the mean. 
 */

using System;
using static System.Console;


namespace AverageDiff
{
    class AverageDiff
    {
        static void Main( )
        {
            int total = 0;
            double avg;
            double distance;
            string inValue;
            int[ ] score = new int[10];

            // Values are entered
            for (int i = 0; i < score.Length; i++)
            {
                Write("Enter Score{0}: ", i + 1);
                inValue = ReadLine();
                if (int.TryParse(inValue, out score[i]) == false)
                   WriteLine("Invalid data entered - 0 stored in array");
            }

           
            // Values are summed
            for (int i = 0; i < score.Length; i++)
            {
                total += score[i];
            }

            avg = (double) total / score.Length;

            WriteLine();
            WriteLine("Average: {0}", avg.ToString("F0"));

            // Output is array element and how far the value
            // is from the mean (absolute value).
            WriteLine();
            WriteLine("Score\tDist. from Avg.");
            for (int i = 0; i < score.Length; i++)
            {
                distance = Math.Abs((avg - score[i]));
                WriteLine("{0}\t\t{1}", score[i], distance.ToString("F0"));
            }
            ReadKey();
        }
    }
}
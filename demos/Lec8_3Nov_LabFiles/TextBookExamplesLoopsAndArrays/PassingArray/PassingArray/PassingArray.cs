/* PassingArray.cs      Author:  Doyle
 * Demonstrates passing arrays to methods - references
 */

using System;
using static System.Console;

namespace PassingArray
{
    class PassingArray
    {
        static void Main( )
        {
            int[ ] temperature = new int[5];
            int[ ] t = new int[5];

            InputValues(temperature);

            //Array t will reference the same array 
            //as the temperature array
            t = temperature;

            t[1] = 44;
            WriteLine("Value stored in temperature[1]: {0}", 
                                temperature[1]);
            ReadKey();
        }
        public static void InputValues(int[ ] temp)
        {
            string inValue;

            for (int i = 0; i < temp.Length; i++)
            {
                Write("Enter temperature {0}: ", i + 1);
                inValue = ReadLine();
                if (int.TryParse(inValue, out temp[i]) == false)
                    WriteLine("Invalid data entered - " +  
                                        "0 stored in array element");
            }
        }
    }
}
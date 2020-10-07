/* StatePicker.cs		Author:	Doyle	
 * Allows the user to enter a state
 * abbreviation. A switch statement 
 * is used to display the full name
 * of the state. 
 * *********************************/
using System;
using static System.Console;

namespace StatePicker
{
    class StatePicker
    {
        static void Main( )
        {
            string stateAbbrev;

            WriteLine("Enter the state abbreviation. ");
            WriteLine("Its full name will be displayed.");
            WriteLine();
            stateAbbrev = ReadLine();

            switch (stateAbbrev)
            {
                case "AL":
                case "aL":
                case "Al":
                case "al":
                    WriteLine("Alabama");
                    bLreak;
                case "FL":
                    WriteLine("Florida");
                    break;
                case "GA":
                    WriteLine("Georgia");
                    break;
                case "IL":
                    WriteLine("Illinois");
                    break;
                case "KY":
                    WriteLine("Kentucky");
                    break;
                case "MI":
                    WriteLine("Michigan");
                    break;
                case "OK":
                    WriteLine("Oklahoma");
                    break;
                case "TX":
                    WriteLine("Texas");
                    break;
                default:
                    WriteLine("No match");
                    break;
            }
            Console.ReadKey();
        }
    }
}

using System;
using static System.Console;

namespace ForLoop
{
    class ForLoop
    {
        static void Main( )
        {
            for (int counter = 0; counter < 11; counter++)			// Line 1
            {
                WriteLine("{0,5}\t{1,5}\t{2,5}",					// loop body
                          counter,
                          Math.Pow(counter, 2),
                          Math.Pow(counter, 3));			

            }
		
		

			////int counter;
			////WriteLine(counter);

			//// Example 6.11 - illustrating how this could be done with a while loop
			//int counter = 0;
			//while (counter < 11)
			//{
			//    WriteLine("{0}\t{1}\t{2}",
			//    counter,
			//    Math.Pow(counter, 2),
			//    Math.Pow(counter, 3));
			//    counter++;
			//}

			ReadKey( );
        }
    }
}
/* Parameters.cs
* Author Doyle
* This class demonstrates the differences between the
* default, ref, and out parameter types */

using System;
using static System.Console;

namespace Parameters
{
    class Parameters
    {
        static void Main( )
        {
            int testValue = 1;
			WriteLine("Original Value: {0}", testValue);

			TestDefault(testValue);
			WriteLine("Upon return from TestDefault "
                + "Value: {0}", testValue);

			WriteLine();
			WriteLine("Original Value: {0}", testValue);

			TestRef(ref testValue);
            WriteLine("Upon return from TestRef Value: {0}", 
					  testValue);

			WriteLine();
			// variable does not have to be initialized
			// for out parameter type

			int testValue2;
			// however,  you cannot display its
			// value yet!
            // WriteLine("Original Value: {0}",
            //			 testValue2);
            TestOut(out testValue2);
            WriteLine("Upon return from TestOut Value: " +
					  " {0}", testValue2);
            Console.Read();
        }

        static void TestDefault(int aValue)
        {
            aValue = 111;
            WriteLine("In TestDefault -"
                + "Value: "
                + "{0}", aValue);
        }

		static void TestRef(ref int aValue)
        {
            aValue = 333;
            WriteLine("Inside TestRef -"
                + "Value: "
                + "{0}", aValue);
        }

		static void TestOut(out int aValue)
        {
            aValue = 222;
            WriteLine("In TestOut -"
                + "Value: "
                + " {0} ", aValue);
        } 
    }
}

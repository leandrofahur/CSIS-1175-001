using System;

namespace ExceptionHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insert an integer: ");
                int number = char.Parse(Console.ReadLine());

            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                Console.WriteLine("Bye bye...");
            }
        }
    }
}

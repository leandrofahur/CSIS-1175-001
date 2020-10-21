using System;
using System.Threading.Channels;

namespace TicketingApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string ticketAcc = "";
            bool keepRunning = true;
            while(keepRunning)
            {
                Console.WriteLine("\nDo you have any ticket to enter?");
                Console.Write("Press y/n: ");

                char choice = char.Parse(Console.ReadLine());
                choice = char.ToLower(choice);

                if(choice == 'y')
                {
                    GetTicketDetails(out string studentId, out char studentCat, out int speedLimit, out int speedReported);
                    Ticket ticket = new Ticket(studentId, studentCat, speedLimit, speedReported);
                    Console.WriteLine(ticket);
                    ticketAcc += ticket.ToString() + "\n\n";
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Leaving the application...");
                    Console.Write("\n");
                    Console.WriteLine(ticketAcc);
                    keepRunning = false;
                }
            }
        }
        static void GetTicketDetails(out string studentId, out char studentCat, out int speedLimit, out int speedReported)
        {
            Console.WriteLine("\n");
            Console.Write("Please insert the student id: ");
            studentId = Console.ReadLine();
            while(studentId == "")
            {
                Console.Write("Please insert a valid student id: ");
                studentId = Console.ReadLine();
            }
            Console.WriteLine("\n");
            Console.Write("Please insert a valid student category: ");
            while (!char.TryParse(Console.ReadLine(), out studentCat) && !studentCat.Equals('1') && !studentCat.Equals('2') && !studentCat.Equals('3') && !studentCat.Equals('4'))
            {
                Console.Write("Please insert a valid student category: ");
            }
            Console.WriteLine("\n");
            Console.Write("Please insert a valid speed limit: ");
            while (!int.TryParse(Console.ReadLine(), out speedLimit) || speedLimit < 0)
            {
                Console.Write("Please insert a valid speed limit: ");
            }
            Console.WriteLine("\n");
            Console.Write("Please insert a valid speed reported: ");
            while (!int.TryParse(Console.ReadLine(), out speedReported) || speedReported < 0)
            {
                Console.Write("Please insert a valid speed reported: ");
            }
        }
    }
}

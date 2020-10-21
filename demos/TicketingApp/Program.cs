using System;

namespace TicketingApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Ticket ticket = new Ticket("300326045", '1', 50, 100);
            Console.WriteLine(ticket);
        }
    }
}

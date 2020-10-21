using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TicketingApp
{
    public class Ticket
    {
        // auto-properties (read-write):
        public string StudentId
        {
            get;
            set;
        }

        // auto-properties (read-write):
        public char StudentCategory
        {
            get;
            set;
        }

        // auto-properties (read-write):
        public int SpeedLimit
        {
            get;
            set;
        }

        // auto-properties (read-write):
        public int SpeedReported
        {
            get;
            set;
        }

        // auto-properties (read-only):
        public string CategoryName
        {
            get
            {
                //Console.WriteLine(StudentCategory);
                //return "Freshman";
                if (StudentCategory == '1')
                {
                    return "Freshman";
                }
                else if (StudentCategory == '2')
                {
                    return "Sophomore";
                }
                else if (StudentCategory == '3')
                {
                    return "Junior";
                }
                else if (StudentCategory == '4')
                {
                    return "Senior";
                }
                else
                {
                    return "Error";
                }
            }
        }

        // auto-property (read-only):
        public double Fine
        {
            get
            {
                int speed = SpeedReported - SpeedLimit;
                double fine = ((double)speed / 5 * 87.50) + 75.50;

                if (CategoryName == "Senior")
                {
                    if (speed > 20)
                    {
                        fine += 200;
                    }
                    else
                    {
                        fine += 50;
                    }

                }
                else if (CategoryName == "Freshman")
                {
                    if (speed < 20)
                    {
                        fine -= 50;
                    }
                    else
                    {
                        fine += 100;
                    }
                }
                else
                {
                    if (speed > 19)
                    {
                        fine += 100;
                    }
                }

                return fine;
            }
        }

        // default constructor:
        public Ticket()
        {

        }

        // non-default constructors:
        public Ticket(string studentId, char studentCategory, int speedLimit, int speedReported)
        {
            StudentId = studentId;
            StudentCategory = studentCategory;
            SpeedLimit = speedLimit;
            SpeedReported = speedReported;
        }

        // ovveriden ToString() method:
        public override string ToString()
        {
            return String.Format("Student Id: {0}\n"
                 + "Student Category: {1}\n"
                 + "Speed Limit: {2}\n"
                 + "Speed Reported: {3}\n"
                 + "Fine: {4:C}",
                 StudentId,
                 StudentCategory,
                 SpeedLimit,
                 SpeedReported,
                 Fine);
        }
    }
}

using System;

namespace StudentApp
{
    public class Student
    {
        //Data members, data fields, or characteristics 
        //Backing fields represent the private data inside a class
        //backing field name is typically camel case
        //Backing field is private data
        private string studentNumber;
        private string studentLastName;
        private string studentFirstName;
        private int score1;
        private int score2;
        private int score3;
        private string major;


        //no return type in constructor definition
        //same name as the class
        //constructor is used to create objects of the class with initial values using the parameters
        //access modifier for Constructor needs to be public

        //Default constructor
        //parameterless constructor
        public Student()
        {
            //infact there is no method body even
            //If this constructor is called to create a student object
            //all numeric data are initialized to 0
            //all string data are initialized to "" (empty literal) " " - double quotes with space inside is not empty literal 
        }

        //Constructor with one argument
        public Student(string sID)
        {
            studentNumber = sID;
            //all other data members are initialized to 0 if numeric
            //and "" empty literal if string
        }

        //Constructor with three arguments
        public Student(string sID, string lastName, string firstName)
        {
            studentNumber = sID;
            studentLastName = lastName;
            studentFirstName = firstName;
            //all other data members get default values of 0 or empty literal
        }

        //Constructor with six arguments
        public Student(string sID, string lastName, string firstName,
					   int s1, int s2, int s3, string maj)
        {
            studentNumber = sID;
            studentLastName = lastName;
            studentFirstName = firstName;
            score1 = s1;
            score2 = s2;
            score3 = s3;
            major = maj;
        }

        //Properties
        //Property is public accesssible data of the backfield
        //each private backing field is typically mapped to a public property
        //Public property should ideally have a similar name as the corresponding field
        //But property name cannot be exactly the same as backing field name
        //Note all identifiers, method names and keywords in c# are case-sensitive
        //Property typically has pascal case
        //Backing field and property should have the same data type
        public string StudentLastName
        {
            //getter is defined to get the value of the corresponding field
            //should have return statement
            //should return the backing field value
            get
            {
                //return 25.6; cannot return a double value when property data type is string
                return studentLastName;
            }
            //setter is used to set the value of the backing field
            set
            {
                //the value assigned to the property is assigned to the backing field
                //value is a a keyword and lower case
                studentLastName = value;
            }
        }

        public string StudentFirstName
        {
            //this proerty is mapped to studentFirstName backing field
            get
            {
                return studentFirstName;
            }
            set
            {
                studentFirstName = value;
            }
        }

        public string StudentNumber
        {
            get
            {
                return studentNumber;
            }
            set
            {
                studentNumber = value;
            }
        }

        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        public int Score1
        {
            get
            {
                return score1;
            }
            set
            {
                score1 = value;
            }
        }

        public int Score2
        {
            get
            {
                return score2;
            }
            set
            {
                score2 = value;
            }
        }

        public int Score3
        {
            get
            {
                return score3;
            }
            set
            {
                score3 = value;
            }
        }

        public double CalculateAverage()
        {
            //this class method computes the average of the three scores stored
            //in the object of this class
            return (score1 + score2 + score3) / 3.0;
        }
        //ToString() method has return string
        public override string ToString()
        {
            //purpose of ToString() method is to combine all or a subset of the data of an object
            //and return one String value that represents information stored in the object
            return "Name: " +
                studentFirstName + " " + studentLastName +
                "\nMajor: " + major +
                "\nScore Average: " +
                CalculateAverage().ToString("F2");
        }
    }
}

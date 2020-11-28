using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UserWindowsFormsApp
{
    public partial class Form1 : Form
    {
        //Declare a List of UserInfo to maintain a list of users added thus far
        List<UserInfo> UserList = new List<UserInfo>(); //this creates an empty list of user info objects
        
        public Form1()
        {
            InitializeComponent();
        }

        private void displayDetailsBtn_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter the user id");
            } else if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter user name");
            } else if (userAgeTextBox.Text == "")
            {
                MessageBox.Show("Please enter user age");
            } else if (!int.TryParse(userAgeTextBox.Text,out int userAge))
            {
                MessageBox.Show("User age must be an integer");
            }
            else
            {
                //is entered only if both user name and user age has text entered
                //Clear the outputListBox
                outputListBox.Items.Clear();
                //Add user details as two lines in the listbox
                outputListBox.Items.Add("User Id: " + userIdTextBox.Text);
                outputListBox.Items.Add("User Name: " + userNameTextBox.Text);
                int newAge = userAge + 10; //numerical addition of 10 to integer age
                outputListBox.Items.Add("User Age: " + newAge.ToString()); //Text property is always a string
                //update status label text to say "User details added..."
                statusLabel.Text = "Added user details to listbox....";

                //Create UserInfo object with these user details of id, name and age (int)
                UserInfo eachUserInfo = new UserInfo(userIdTextBox.Text, 
                                                    userNameTextBox.Text, userAge);
                UserList.Add(eachUserInfo);
                //UserList.Add("hello"); //cannot add a string to list of userinfo objects

                MessageBox.Show("Total UserInfo objects in the list is " + UserList.Count);

                //Call a method in Form1 class to load all user info objects into the listbox
                LoadAllUsersToListBox();

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //practice exercise: Add a Label for AverageAge and a 
        //Button that says "Find Avg Age" in the form
        //Write a method in the form that goes through the list of user info objects
        //finds the average age
        //Note that UserList[0].UserAge refers to age property of the first user object in the list
        //Or you can use foreach and user.UserAge will give you the age

        private void LoadAllUsersToListBox()
        {
            //clear the listbox first
            outputListBox.Items.Clear();

            //add a header line in the listbox
            outputListBox.Items.Add("UserId\tUserName\tAge");

            //set up a foreach loop to add each user to the listbox
            foreach(UserInfo user in UserList)
            {
                outputListBox.Items.Add(user.ToString());
            }
        }

        private void writeToFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                //First Declare StreamWriter
                using(StreamWriter myOutputStream = new StreamWriter("useroutput.txt"))
                {
                    //header line written just once outside the foreach loop
                    string headerLine = "Id,Name,Age";
                    myOutputStream.WriteLine(headerLine); //this writes the headerLine to the output stream writer
                    foreach(UserInfo user in UserList)
                    {

                        //myOutputStream.WriteLine(user.ToString()); //calls ToString() - tab separated for each user in the list
                        myOutputStream.WriteLine(user.UserId + "," + user.UserName + "," + user.UserAge);
                    }
                    statusLabel.Text = "Written " + UserList.Count + " Users to the text file...";
                    outputListBox.Items.Clear(); //clear list box
                    UserList.Clear(); //clears the UserList
                }


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

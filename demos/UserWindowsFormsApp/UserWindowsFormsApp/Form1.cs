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
        //Declare a list of user info to maintain a list of users added thus far
        List<UserInfo> UserList = new List<UserInfo>(); // this creates an empty list of user info objects



        public Form1()
        {
            InitializeComponent();
        }

        // Do not double click before changing the name on design. If done, the result is going to be like
        //the name below, the default name that is not the one you would like to.
        private void button1_Click(object sender, EventArgs e)
        {
            if (userIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter the user id");
            } else if (userNameTextbox.Text == "")
            {
                MessageBox.Show("Please enter user name");
            }
            else if (userAgeTextBox.Text == "")
            {
                MessageBox.Show("Please enter user age");
            }
            else if (!int.TryParse(userAgeTextBox.Text, out int userAge))
            {
                MessageBox.Show("User age must be an integer");

            }
            else
            {
                //MessageBox.Show("Hello, " + userNameTextbox.Text);

                //is entered only if both user name and user age has text entered
                //Clear the outputListBox
                outputListBox.Items.Clear();
                //Add user details as two lines in the listbox

                outputListBox.Items.Add("User Id: " + userIdTextBox.Text);
                outputListBox.Items.Add("User Name: " + userNameTextbox.Text);
                int newAge = userAge + 10;
                outputListBox.Items.Add("User Age: " + newAge.ToString());

               
                //update status label text to say "User Details added"
                statusLabel.Text = "User Details added";

                //create userinfo object with these user details of id, name and age (int)
                UserInfo eachUserInfo = new UserInfo(userIdTextBox.Text, userNameTextbox.Text, userAge);

                UserList.Add(eachUserInfo);
                //UserList.add("hello"; // cannot add a string to list of userinfo objects

                MessageBox.Show("Total UserInfo objects in the list is " + UserList.Count);

                //Call a method in Form1 class to load all user info objects into the listbox
                LoadAllUsersToListBox();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //practice exercise: Add a label for averageage in the form
        //and a button that says "Find Avg Age" in the form
        //Write a method in the form that goes through the list of user info objects
        //finds the average age

        //Note that UserList[0].UserAge refers to age property of the first user object in the list
        //Or you can use foreach and user.UserAge will give you the age 

        private void LoadAllUsersToListBox()
        {
            //clear the listbox first
            outputListBox.Items.Clear();

            //add a header line in the listboxs
            outputListBox.Items.Add("UserId\tUserName\tAge");

            //setup a foreach loop to add each user to the listbox
            foreach (UserInfo user in UserList)
            {
                outputListBox.Items.Add(user.ToString());
            }
        }

        private void writeToFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                //First Declare StreamWriter
                using(StreamWriter myOutputStream = new StreamWriter("useroutput,txt"))
                {
                    //headerline writter just once outside the foreach loop
                    string headerLine = "Id, Name, Age";
                    myOutputStream.WriteLine(headerLine); //this writes the headerLine to the output string
                    foreach (UserInfo user in UserList)
                    {
                       // myOutputStream.WriteLine(user.ToString()); //calls ToString() for each user - tab separated
                        myOutputStream.WriteLine(user.UserId + "," + user.UserName + "," + user.UserAge); //comma separated
                    }
                    statusLabel.Text = "Written" + UserList.Count + "Users to the text file..";
                    outputListBox.Items.Clear(); //clear list box
                    UserList.Clear(); //clears the userlist 
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

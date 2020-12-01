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
            //this event handler says button1_Click
            //because that was the name of the button
            //when the click event handler (this method)
            //was created

            //Renaming the button after the handler is created
            //won't change the name of the handler
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
            //outputListBox.SelectedIndex = 1; //default selection
        }
        private void LoadAllUsersToListBox(List<UserInfo> anyList)
        {
            outputListBox.Items.Clear();
            outputListBox.Items.Add("UserId\tUserName\tUserAge");
            foreach(UserInfo user in anyList)
            {
                outputListBox.Items.Add(user);
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
                    UserList.Clear(); //clears the UserList, note if the list cleared before updating the status label
                }


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readFromFileButton_Click(object sender, EventArgs e)
        {
            //Clear the User List before reading from file and creating user info object
            //and adding it to the list
            UserList.Clear();
            try
            {
                using(StreamReader myInputStream = new StreamReader("userinfo.csv"))
                {
                    string eachLine; //to keep track of each line that is read from the stream
                    //if EndOfStream is not reached
                    if (!myInputStream.EndOfStream)
                    {
                        //means there is data to read and process
                        //this if block is entered to read the first line
                        //possibly header line
                        eachLine = myInputStream.ReadLine(); //reads one line at a time until \n is encountered and the stream moves to the next line
                        MessageBox.Show(eachLine);
                    }

                    //after the above if statement, the current location of the stream is line 2
                    while (!myInputStream.EndOfStream)
                    {
                        //while is entered as long as there are more lines to read
                        eachLine = myInputStream.ReadLine();
                        string[] userFieldsArray = eachLine.Split(','); //split eachLine based on comma
                        string id = userFieldsArray[0]; //based on first field/column in the CSV file
                        string name = userFieldsArray[1];
                        int.TryParse(userFieldsArray[2], out int age);
                        UserInfo eachUserInfo = new UserInfo(id, name, age);
                        UserList.Add(eachUserInfo); //note here you can add only an user info object into the list
                    }

                } //end of using block for reading file
                LoadAllUsersToListBox();
                
                //just to check the number of objects (list) and items (listbox)
                MessageBox.Show("UserList Num Of Users = " + UserList.Count);
                MessageBox.Show("ListBox Items Count = " + outputListBox.Items.Count);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void outputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //outputListBox.SelectedIndex = 2; //you may set the SelectedIndex for default selection but it does not make to do it in the handler
            if (outputListBox.SelectedIndex > 0)
            {
                statusLabel.Text = "Selected item index in listbox is " + outputListBox.SelectedIndex +
                                        "\n User Name is " + UserList[outputListBox.SelectedIndex - 1].UserName;
            } else if (outputListBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select any line other than header");
            }
        }

        private void add10ToEachAgeButton_Click(object sender, EventArgs e)
        {
            //Here, I want to access each user object from the list and
            //increase it by 10
            //using a loop
            for (int i = 0; i < UserList.Count; i++)
            {
                UserList[i].UserAge = UserList[i].UserAge + 10; //UserAge is a public property
            }

            //Load the new user list onto ListBox
            LoadAllUsersToListBox();
        }

        private void subtract10FromSelectedAgeButton_Click(object sender, EventArgs e)
        {
            int selIndex = outputListBox.SelectedIndex;
            //MessageBox.Show(selIndex + " is the selected index");
            if (selIndex == -1 || selIndex == 0)
            {
                MessageBox.Show("Please select a user");
            } else
            {
                UserList[selIndex - 1].UserAge -= 10;
                //LoadAllUsersToListBox(); //this is wasteful
                outputListBox.Items[selIndex] = UserList[selIndex - 1]; //automatically uses the ToString() method defined in UserInfo class
            }
        }

        private void sortByAgeBtn_Click(object sender, EventArgs e)
        {
            //this sorted list is only visible in this method
            //not accessible from other methods
            List<UserInfo> SortedUserList = UserList.OrderBy(user => user.UserAge).ToList();

            //this sorted list needs to be loaded to listbox
            LoadAllUsersToListBox(SortedUserList); //calling the version of load that loads the sorted list into the listbox
            UserList = SortedUserList;
        }
    }
}

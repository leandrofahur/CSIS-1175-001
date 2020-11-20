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

namespace ApplicationForm
{
    public partial class Form1 : Form
    {
        private List<User> userList = new List<User>();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if(firstNameTextBox.Text == "")
            {
                MessageBox.Show("Please insert your first name!");
                isValid = false;
            }
            if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Please insert your last name!");
                isValid = false;
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please insert a password!");
                isValid = false;
            }
            if (reenterPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please reenter the password!");
                isValid = false;
            }
            if (passwordTextBox.Text != reenterPasswordTextBox.Text)
            {
                MessageBox.Show("The password needs to be the same!");
                isValid = false;
            }

            if(isValid)
            {
                User user = new User(firstNameTextBox.Text, lastNameTextBox.Text, passwordTextBox.Text);
                userList.Add(user);
                listBox1.Items.Add(user);
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void reenterPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            reenterPasswordTextBox.PasswordChar = '*';
        }

        private void passwordVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(passwordVisibleCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void reenterPasswordVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (reenterPasswordVisibleCheckBox.Checked)
            {
                reenterPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                reenterPasswordTextBox.PasswordChar = '*';
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {            
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            passwordTextBox.Clear();
            reenterPasswordTextBox.Clear();
            passwordVisibleCheckBox.Checked = false;
            reenterPasswordVisibleCheckBox.Checked = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool isFound = false;

            int index = -1;
            for (int i = 0; i <= userList.Count-1; i++)
            {
                if(userList[i].FirstName == firstNameTextBox.Text ||
                   userList[i].LastName == lastNameTextBox.Text ||
                   userList[i].Password == firstNameTextBox.Text)
                {
                    index = i;
                    isFound = true;
                    break;
                }
            }

            if(isFound)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(userList[index]);
            }
            else
            {
                MessageBox.Show("User not found!");
            }
            
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter("userFormOutput.txt"))
                {
                    string headline = "Name,Password";
                    streamWriter.WriteLine(headline);
                    foreach(object user in userList)
                    {
                        streamWriter.WriteLine(user.ToString());
                    }
                    listBox1.Items.Clear();
                    userList.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("userFormOutput.txt"))
                {
                    string line;
                    while((line = streamReader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

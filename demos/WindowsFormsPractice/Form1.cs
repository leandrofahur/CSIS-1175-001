using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if(insertTaskTextBox.Text == "")
            {
                MessageBox.Show("Please insert a task before adding it to the list!");
            }
            else
            {
                taskListBox.Items.Add(insertTaskTextBox.Text);
                insertTaskTextBox.Text = "";
            }
        }

        private void clearTaskButton_Click(object sender, EventArgs e)
        {
            if(insertTaskTextBox.Text == "")
            {
                // ... do nothing
            }
            else
            {
                insertTaskTextBox.Text = "";
            }
        }

        private void searchTaskButton_Click(object sender, EventArgs e)
        {
            if(searchTaskTextBox.Text == "")
            {
                MessageBox.Show("Please insert a task to search for in the list!");
            }
            else
            {
                // logic to iterate over the listbox item
            }
        }

        private void deleteTaskListBoxButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.Items.Count == 0)
            {
                MessageBox.Show("The task list is already empty!");
            }
            else
            {
                taskListBox.Items.Clear();

                //taskListBox.BeginUpdate();
                //try
                //{
                //    foreach(var item in taskListBox.Items)
                //    {
                //        taskListBox.Items.Remove(item);
                //    }
                //}
                //finally
                //{
                //    taskListBox.EndUpdate();
                //}

                //for(int i = 0; i < taskListBox.Items.Count; i++)
                //{
                //    taskListBox.Items.RemoveAt(i);
                //}
            }
        }
    }
}

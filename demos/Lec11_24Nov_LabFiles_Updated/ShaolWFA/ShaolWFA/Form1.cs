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

namespace ShaolWFA
{
    public partial class Form1 : Form
    {
        List<Shoal> ShoalList = new List<Shoal>(); //maintains a list of all shoal objects added so far, called field property of the form

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            //if you accidentally create a method like this, leave it alone.
            //if you need to remove it, it needs to be removed in the Designer code and here.
            //better to leave it alone for now
            //changing the name of a control after you create handler will not rename the event handler
            //for this reason, you must always create the control, change its name to the appropriate name,
            //before create the event handler for this control
        }

        private void AddShoalButton_Click(object sender, EventArgs e)
        {
            //MessageBox just for testing button click
            //MessageBox.Show("You clicked " +
            //    "on the add shoal button");

            //When this button is clicked, values from the textboxes are used, parsed if numeric, and 
            //used to create one shoal object, then that object is added to the list of shoal objects (ShoalList)


            //Create Shoal Object and add it to a list of shoals (ShoalList)
            AddItem();

            //Load all shoal objects from ShoalList list to output list box, 
            //ListBox contains a list of items, each item corresponds to one object coverted to String using
            //ToString() method defined in the class.
            LoadToListBox();

            //Clear TextBox Fields. Note that we do not want to clear the textbox text property unil the item is added to the list
            ClearFields();

            statusLabel.Text = "Added shoal object to the list and output list box";

        }

        private void AddItem()
        {
            //This method gets all values from TextBoxes, converts numeric values into numbers from string
            //got from Text property, create a shoal object, and then add it to the list

            //you can add several else if for validation if you like

            if (locationTextBox.Text == "")
            {
                MessageBox.Show("Location cannot be empty");
            }
            else
            {

                //Two New 4 element arrays to maintain low tide and high tide depths
                double[] lowTides = new double[4];
                double[] highTides = new double[4];

                //mileMarker is int so needs to be parsed from Text property of mile marker text box
                double mileMarker;

                try
                {
                    //just using Parse to show use with try catch. Better to use TryParse in c# though.

                    lowTides[0] = double.Parse(lowTidesTB1.Text);
                    lowTides[1] = double.Parse(lowTidesTB2.Text);
                    lowTides[2] = double.Parse(lowTidesTB3.Text);
                    lowTides[3] = double.Parse(lowTidesTB4.Text);
                    highTides[0] = double.Parse(highTidesTB1.Text);
                    highTides[1] = double.Parse(highTidesTB2.Text);
                    highTides[2] = double.Parse(highTidesTB3.Text);
                    highTides[3] = double.Parse(highTidesTB4.Text);
                    //  mileMarker = double.Parse(mileMarkerTextBox.Text);
                    double.TryParse(mileMarkerTextBox.Text, out mileMarker); //example using TryParse
                    string location = locationTextBox.Text;
                    string state = stateTextBox.Text;
                    //creating a shoal object with all this information, check Shoal Class definition, and constructor definition to see
                    //how the constructor is used o create shoal object

                    Shoal eachShoal = new Shoal(location, state, mileMarker,
                                            lowTides, highTides);
                    // MessageBox.Show(eachShoal.ToString());

                    //This shoal list maintains a list of shoal objects added so far.
                    ShoalList.Add(eachShoal); //no new list, list is created when Form1 is created
                                              //ShoalList.Add("Any shoal"); //ShoalList can only have a shoal object added to it

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadToListBox()
        {
            //clear listbox and then load all shoal objects 
            //from shoal list to list box 

            //After clearing output list box, load all shoal objects from ShoalList list to output list box, 
            //ListBox contains a list of items, each item corresponds to one object coverted to String using
            //ToString() method defined in the class, and then add the string to the listbox
            //Make sure you understand the purpose of listbox and list of shoal objects, and the difference between
            //ShoalList and outputListBox here. outputListBox is just for viewing the data
            //ShoalList is the actual data

            outputListBox.Items.Clear(); //first clear previous items from listbox
            string headerStr = "Location\tState\tMileMarker....add rest of fields"; //creating header string, does not add it to the listbox
            outputListBox.Items.Add(headerStr); //this is what adds header line to the listbox

            foreach (Shoal shoualObj in ShoalList)
            {
                outputListBox.Items.Add(shoualObj.ToString()); //because is ToString() is defined in the Shoal class
            }

        }

        private void ClearFields()
        {
            //all textboxes are rest to empty strings
            locationTextBox.Text = ""; //resets the location textbox to empty
            stateTextBox.Text = "";
            mileMarkerTextBox.Text = "";
            lowTidesTB1.Text = "";
            lowTidesTB2.Text = "";
            lowTidesTB3.Text = "";
            lowTidesTB4.Text = "";
            highTidesTB1.Text = "";
            highTidesTB2.Text = "";
            highTidesTB3.Text = "";
            highTidesTB4.Text = "";
        }





        private void OutputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = outputListBox.SelectedIndex; //value will be -1 if nothing selected

            //Load Item into Textboxes. This way whatever item is selected can be easily updated in the listbox when 
            //update button is clicked

            LoadItem(index-1); //ith item in listbox corresponds to (i-1)th item in the list
        }
        private void LoadItem(int index)
        {
            if (index != -1)
            {
                locationTextBox.Text = ShoalList[index].Location; //takes the indexth item from ShoalList (not listbox) and assigns it to Text property of textbox
                stateTextBox.Text = ShoalList[index].State;
                mileMarkerTextBox.Text
                    = ShoalList[index].MileMarker.ToString();
                lowTidesTB1.Text
                    = ShoalList[index].DepthLowTides[0].ToString();
                lowTidesTB2.Text
                    = ShoalList[index].DepthLowTides[1].ToString();
                lowTidesTB3.Text
                    = ShoalList[index].DepthLowTides[2].ToString();
                lowTidesTB4.Text
                    = ShoalList[index].DepthLowTides[3].ToString();
                highTidesTB1.Text
                    = ShoalList[index].DepthHighTides[0].ToString();
                highTidesTB2.Text
                    = ShoalList[index].DepthHighTides[1].ToString();
                highTidesTB3.Text
                    = ShoalList[index].DepthHighTides[2].ToString();
                highTidesTB4.Text
                    = ShoalList[index].DepthHighTides[3].ToString();
            } else
            {
                ClearFields(); //call clear fields if header line is selected in the listbox
            }
        }

        

        private void updateSelectedItemButton_Click(object sender, EventArgs e)
        {
            UpdateItem(); //updates selected item in the list (not list box)

            LoadToListBox(); //loads the list to listbox

            statusLabel.Text = "Updated the selected item in the list and loaded list into output listbox";
        }

        private void UpdateItem()
        {
            int listIndex = outputListBox.SelectedIndex - 1;
            if (listIndex < 0)
            {
                MessageBox.Show("Please select item from output listbox to update");
            }
            else
            {
                double[] lowTides = new double[4];
                double[] highTides = new double[4];
                double mileMarker;
                try
                {
                    double.TryParse(lowTidesTB1.Text, out lowTides[0]);
                    double.TryParse(lowTidesTB2.Text, out lowTides[1]);
                    double.TryParse(lowTidesTB3.Text, out lowTides[2]);
                    double.TryParse(lowTidesTB4.Text, out lowTides[3]);
                    double.TryParse(highTidesTB1.Text, out highTides[0]);
                    double.TryParse(highTidesTB2.Text, out highTides[1]);
                    double.TryParse(highTidesTB3.Text, out highTides[2]);
                    double.TryParse(highTidesTB4.Text, out highTides[3]);
                    mileMarker = double.Parse(mileMarkerTextBox.Text);
                    string location = locationTextBox.Text;
                    string state = stateTextBox.Text;
                    Shoal eachShoal = new Shoal(location, state, mileMarker,
                                            lowTides, highTides);
                    // MessageBox.Show(eachShoal.ToString());
                    ShoalList[listIndex] = eachShoal;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
        
        private void BtnReadFromFile_Click(object sender, EventArgs e)
        {
            //Read from file method using file name
            ReadFromFile("ShoalInputFile.csv");
            //load to listbox
            LoadToListBox();

            statusLabel.Text = "Read " + ShoalList.Count() + " records from input file";
        }

        private void ReadFromFile(string fileName)
        {
            try
            {
                //This allocates a new list to ShoalList, it resets already added contents to nothing by assigning it to a new list
                ShoalList = new List<Shoal>(); 

                using (StreamReader myInputStream 
                        = new StreamReader(fileName))
                {

                    string eachLine, headerLine;
                    if (!myInputStream.EndOfStream)
                    {
                        //Header Line or first line of file typically has column names or header names (no numeric data), 
                        //so it must be treated different 
                        //than other lines in the file
                        headerLine = myInputStream.ReadLine();
                    }
                    while (!myInputStream.EndOfStream)
                    {
                        eachLine = myInputStream.ReadLine();
                        double[] lowTides = new double[4];
                        double[] highTides = new double[4];
                        string[] fieldsArray = eachLine.Split(',');
                        string location = fieldsArray[0];
                        string state = fieldsArray[1];
                        double.TryParse(fieldsArray[2], 
                            out double mileMarker);
                        string lowTidesStr = fieldsArray[3];
                        string highTidesStr = fieldsArray[4];
                        string[] lowTidesStrArray 
                                = lowTidesStr.Split('-');
                        for (int i = 0; i < lowTidesStrArray.Length; i++)
                        {
                            double.TryParse(lowTidesStrArray[i],
                                out lowTides[i]);
                        }
                        string[] highTidesStrArray
                                = highTidesStr.Split('-');
                        for (int i = 0; i < highTidesStrArray.Length; i++)
                        {
                            double.TryParse(highTidesStrArray[i],
                                out highTides[i]);
                        }
                        Shoal eachShoal = new Shoal(location, state, 
                                        mileMarker, lowTides, highTides);

                        ShoalList.Add(eachShoal);

                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnWriteFile_Click(object sender, EventArgs e)
        {
            WriteToFile("OutputShoal.txt");
            statusLabel.Text = "Written "
                        + ShoalList.Count + " Items to file \n"
                        + "Thank you!";
            //Create an object of SecondForm class
            SecondForm mySecondForm = new SecondForm();

            //using that object, modify the goodByeLabel, make sure the modifier property of the label in the other form is set to internal before you can modify it
            mySecondForm.goodByeLabel.Text = "Written "
                        + ShoalList.Count + " Items to file \n"
                        + "Thank you!";

            
            //Show the second form object
            mySecondForm.Show(); //this means second form is shown but both first and second form can be made active and execution proceeds regardless of second form being closed

            //Using ShowDialog()
           // mySecondForm.ShowDialog(); //opens a modal second form i.e., second form will be active until it is closed. execution stays at ShowDialog() until second form is closed

            //hide form 1 object after second form is shown
            this.Hide(); //hides the current object (this refers to current object), which is the current form 1 object

        }
        private void WriteToFile(string fileName)
        {
            try
            {
                using(StreamWriter myOutputStream 
                    = new StreamWriter(fileName))
                {
                    string headerLine = "Location\tState\tMileMarker" +
                        "\tLT1-LT2-LT3-LT4\tHT1-HT2-HT3"; //temp. header variable that is a string
                    myOutputStream.WriteLine(headerLine); //writes header to the file
                    foreach(Shoal eachShoal in ShoalList)
                    {
                        myOutputStream.WriteLine(eachShoal);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //accidentally created when form was double clicked
            //will talk about this in the online session
        }
    }
}

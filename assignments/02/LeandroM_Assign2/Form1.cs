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

namespace LeandroM_Assign2
{
    public partial class Form1 : Form
    {
        // List of RetailProduct to keep track to read and write from file and display in the listbox:
        private List<RetailProduct> retailProductList = new List<RetailProduct>();

        // Utilities class:
        // this class updates the listbox based on the list:
        private void UpdateListBox()
        {
            //retailStockListBox.Items.Clear();
            retailStockListBox.BeginUpdate();
            foreach (RetailProduct retailProduct in retailProductList)
            {
                retailStockListBox.Items.Add(retailProduct);
            }
            //retailStockListBox.Update();
        }

        public Form1()
        {
            InitializeComponent();

            // Maintain statusLabel size:
            // https://stackoverflow.com/questions/1169543/how-do-you-fix-the-height-and-width-of-a-winforms-label-to-accept-variable-lengt
            statusLabel.AutoSize = false;

            // Keep it align with the center:
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.label.textalign?view=net-5.0
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        // Loads the .csv file into the List private attribute:
        private void loadDataButton_Click(object sender, EventArgs e)
        {
            // clear list before search, otherwise if the user hits the button twice, it will double all data...
            retailProductList.Clear();
            try
            {
                // create the streamer and read the file from the folder /bin/debug
                using (StreamReader streamReader = new StreamReader("retailStock_input.csv"))
                {
                    string streamLine = "";
                    bool isHeadline = true;
                    while((streamLine = streamReader.ReadLine()) != null)
                    {
                        // break the stream line into tokens:
                        // ps.: needs to add the available qty and sales colunms
                        string[] token = streamLine.Split(',');

                        // the first iteration will give the headline:
                        if(!isHeadline)
                        {
                            // if it is not the first iteration, then we can fill the list and display it on the listbox:
                            // iI put it as the first condition because this if will not enter only one time.
                            RetailProduct retailProduct = new RetailProduct(token[0], token[1], int.Parse(token[2]), int.Parse(token[3]), int.Parse(token[4]), int.Parse(token[5]), double.Parse(token[6]));
                            //retailStockListBox.Items.Add(retailProduct);
                            retailProductList.Add(retailProduct);
                        } 
                        else
                        {
                            // The header needs the same formating as the override method toString() in the class:
                            string headLine = string.Format("{0,-10}\t{1,-16}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-10:C}\t{7,-10}\t{8:C}", token[0], token[1], token[2], token[3], token[4], token[5], token[6], "Available Qty", "Sales");
                            retailStockListBox.Items.Add(headLine);
                            isHeadline = false;
                        }
                    }

                    UpdateListBox();
                }

                // update status label:
                statusLabel.Text = "Loaded " + retailProductList.Count + " items from the input file";
            }
            catch(IOException ex)
            {
                // catch exceptions with the IO 
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
            catch(Exception ex)
            {
                // generic exception
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
        }

        private void updateSoldQtyButton_Click(object sender, EventArgs e)
        {
            if(retailStockListBox.SelectedIndex == 0)
            {
                statusLabel.Font = new Font("Microsoft Sans Serif", 12);
                statusLabel.Text = "Please select a retail product item to increment sold qty";
            }
            else
            {
                // for simplicity, the mapping between the index on the listbox and the list is done here:
                int index = retailStockListBox.SelectedIndex - 1;
                int soldQty;

                statusLabel.Text = index.ToString();

                int.TryParse(soldQtyTextBox.Text, out soldQty);
                if(soldQty <= 0 || soldQty > retailProductList[index].AvailableQty)
                {
                    statusLabel.Font = new Font("Microsoft Sans Serif", 12);
                    statusLabel.Text = "Please reenter an integer sold qty > 0 and less than available qty";
                }
                else
                {
                    retailProductList[index].SoldQty = soldQty;
                    statusLabel.Font = new Font("Microsoft Sans Serif", 12);
                    statusLabel.Text = "Incremented Sold Qty for Item with Product Code " + retailProductList[index].ProductCode;                    
                    UpdateListBox();
                }
            }
        }
    }
}
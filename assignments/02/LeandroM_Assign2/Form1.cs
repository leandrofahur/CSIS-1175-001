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

        // Utilities classes:
        // this class updates the listbox based on the list:
        private void UpdateListBox()
        {
            // clear previous items
            retailStockListBox.Items.Clear();
            string headLine = string.Format("{0,-10}\t{1,-16}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-10:C}\t{7,-10}\t{8:C}", "Product Code", "Product Name", "Starting Qty", "Min Qty", "Sold Qty", "Restocked Qty", "Unit Price", "Available Qty", "Sales");
            retailStockListBox.Items.Add(headLine);
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

        // Create restock oportunity button:
        // ps.: even though I changed the name of the button, still open this metod
        private void button7_Click(object sender, EventArgs e)
        {
            // accumulator to display the number of rows are going to be written in the file
            int acc = 0;
            try
            {
                // create the streamer and write the file in the folder /bin/debug
                using (StreamWriter streamWriter = new StreamWriter("restock_report.csv"))
                {
                    // create the headline for the output file:
                    string headLine = string.Format("{0},{1},{2},{3}", "Product Code", "Product Name", "Min Qty", "Available Price");
                    streamWriter.WriteLine(headLine);
                    foreach (RetailProduct retailProduct in retailProductList)
                    {
                        if (retailProduct.SoldQty > 0)
                        {
                            // configure the row with a comma separated way:
                            string row = string.Format("{0},{1},{2},{3}", retailProduct.ProductCode, retailProduct.ProductName, retailProduct.MinQty, retailProduct.AvailableQty);
                            streamWriter.WriteLine(row);
                            acc += 1;
                        }
                    }
                    statusLabel.Text = "Saved " + acc + " records into the restock needed output file";
                }
            }
            catch (IOException ex)
            {
                // catch exceptions with the IO 
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
            catch (Exception ex)
            {
                // generic exception
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
        }

        // Create sales oportunity button:
        // ps.: even though I changed the name of the button, still open this metod
        private void button6_Click(object sender, EventArgs e)
        {
            // accumulator to display the number of rows are going to be written in the file
            int acc = 0;
            try
            {
                // create the streamer and write the file in the folder /bin/debug
                using (StreamWriter streamWriter = new StreamWriter("sales_report.csv"))
                {
                    // create the headline for the output file:
                    string headLine = string.Format("{0},{1},{2},{3},{4}", "Product Code", "Product Name", "Sold Qty", "Unit Price", "Sales");
                    streamWriter.WriteLine(headLine);
                    foreach (RetailProduct retailProduct in retailProductList)
                    {
                        if(retailProduct.AvailableQty < retailProduct.MinQty)
                        {
                            // configure the row with a comma separated way:
                            string row = string.Format("{0},{1},{2},{3},{4}", retailProduct.ProductCode, retailProduct.ProductName, retailProduct.SoldQty, retailProduct.UnitPrice.ToString("C"), retailProduct.Sales.ToString("C"));
                            streamWriter.WriteLine(row);
                            acc += 1;
                        }
                    }
                    statusLabel.Text = "Saved " + acc + " records into the output retailneeded output file";
                }
            }
            catch (IOException ex)
            {
                // catch exceptions with the IO 
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
            catch (Exception ex)
            {
                // generic exception
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
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
            if(retailStockListBox.SelectedIndex <= 0)
            {
                // statusLabel.Font = new Font("Microsoft Sans Serif", 12);
                statusLabel.Text = "Please select a retail product item to increment sold qty";
            }
            else
            {
                // for simplicity, the mapping between the index on the listbox and the list is done here:
                int index = retailStockListBox.SelectedIndex - 1;
                int soldQty;

                int.TryParse(soldQtyTextBox.Text, out soldQty);
                if(soldQty <= 0 || soldQty > retailProductList[index].AvailableQty)
                {
                    // statusLabel.Font = new Font("Microsoft Sans Serif", 10);
                    statusLabel.Text = "Please reenter an integer sold qty > 0 and less than available qty";
                }
                else
                {
                    retailProductList[index].SoldQty = soldQty;
                    // statusLabel.Font = new Font("Microsoft Sans Serif", 12);
                    statusLabel.Text = "Incremented Sold Qty for Item with Product Code " + retailProductList[index].ProductCode;                    
                    UpdateListBox();
                }
            }
        }

        private void updateRestokedQtyButton_Click(object sender, EventArgs e)
        {
            if (retailStockListBox.SelectedIndex <= 0)
            {
                // statusLabel.Font = new Font("Microsoft Sans Serif", 10);
                statusLabel.Text = "Please select a retail product item to increment restokced qty";
            }
            else
            {
                // for simplicity, the mapping between the index on the listbox and the list is done here:
                int index = retailStockListBox.SelectedIndex - 1;
                int restockedQty;

                int.TryParse(restockedQtyTextBox.Text, out restockedQty);
                if (restockedQty <= 0 )
                {
                    // statusLabel.Font = new Font("Microsoft Sans Serif", 10);
                    statusLabel.Text = "Please reenter an integer restocked qty > 0 and less than available qty";
                }
                else
                {
                    retailProductList[index].RestockedQty = restockedQty;
                    // statusLabel.Font = new Font("Microsoft Sans Serif", 10);
                    statusLabel.Text = "Incremented Restocked Qty for Item with Product Code " + retailProductList[index].ProductCode;
                    UpdateListBox();
                }
            }
        }

        private void deleteSelectedItemButton_Click(object sender, EventArgs e)
        {
            if (retailStockListBox.SelectedIndex <= 0)
            {
                // statusLabel.Font = new Font("Microsoft Sans Serif", 12);
                statusLabel.Text = "Please select a retail product item to delete";
            }
            else
            {
                // for simplicity, the mapping between the index on the listbox and the list is done here:
                int index = retailStockListBox.SelectedIndex - 1;
                // statusLabel.Font = new Font("Microsoft Sans Serif", 12);
                statusLabel.Text = "Deleted Item with Product Code " + retailProductList[index].ProductCode;
                retailProductList.RemoveAt(index);
                UpdateListBox();
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            // sort by ascending:
            retailProductList.Sort((x, y) => x.Sales.CompareTo(y.Sales));
            // revert to create the descending:
            retailProductList.Reverse();

            // statusLabel.Font = new Font("Microsoft Sans Serif", 12);
            statusLabel.Text = "List Sorted in Descending Order of Sales";
            UpdateListBox();
        }

        private void saveRetailStockDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                // create the streamer and write the file in the folder /bin/debug
                using (StreamWriter streamWriter = new StreamWriter("retailStock_output.csv"))
                {
                    // create the headline for the output file:
                    string headLine = string.Format("{0},{1},{2},{3},{4},{5},{6}", "Product Code", "Product Name", "Starting Qty", "Min Qty", "Sold Qty", "Restocked Qty", "Unit Price");
                    streamWriter.WriteLine(headLine);
                    foreach (RetailProduct retailProduct in retailProductList)
                    {
                        // configure the row with a comma separated way:
                        string row = string.Format("{0},{1},{2},{3},{4},{5},{6}", retailProduct.ProductCode, retailProduct.ProductName, retailProduct.StartingQty, retailProduct.MinQty, retailProduct.SoldQty, retailProduct.RestockedQty, retailProduct.UnitPrice.ToString("C"));
                        streamWriter.WriteLine(row);
                    }
                    statusLabel.Text = "Saved " + retailProductList.Count + " records into the output retail stock file";
                }
            }
            catch (IOException ex)
            {
                // catch exceptions with the IO 
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
            catch (Exception ex)
            {
                // generic exception
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
        }
    }
}
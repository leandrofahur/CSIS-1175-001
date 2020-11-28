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

        public Form1()
        {
            InitializeComponent();
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
            // Header:
            
            try
            {
                using (StreamReader streamReader = new StreamReader("retailStock_input.csv"))
                {
                    string streamLine = "";
                    bool isHeadline = true;
                    while((streamLine = streamReader.ReadLine()) != null)
                    {
                        // break the stream line into tokens:
                        string[] token = streamLine.Split(',');
                        // the first iteration will give the headline:
                        if(!isHeadline)
                        {
                            //RetailProduct retailProduct = new RetailProduct(token[0], token[1], int.Parse(token[2]), int.Parse(token[3]), int.Parse(token[4]), int.Parse(token[5]), double.Parse(token[6]));
                            //retailStockListBox.Items.Add(retailProduct);
                            //retailProductList.Add(retailProduct);

                            //string row = string.Format("{0,12}{1,16}{2,30}{3,35}{4,40}{5,45}{6}", token[0], token[1], token[2], token[3], token[4], token[5], token[6]);
                            string row = string.Format("{0,-12}\t{1,-16}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-10}\t{6:C}", token[0], token[1], token[2], token[3], token[4], token[5], token[6]);
                            retailStockListBox.Items.Add(row);
                        } else
                        {
                            //string headLine = string.Format("{0,12}{1,16}{2,30}{3,35}{4,40}{5,45}{6}", token[0], token[1], token[2], token[3], token[4], token[5], token[6]);
                            string headLine = string.Format("{0,-12}\t{1,-16}\t{2,-10}\t{3,-10}\t{4,-10}\t{5,-10}\t{6:C}", token[0], token[1], token[2], token[3], token[4], token[5], token[6]);
                            retailStockListBox.Items.Add(headLine);
                            isHeadline = false;
                        }
                    }
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception Thrown: " + ex.Message);
            }
        }
    }
}
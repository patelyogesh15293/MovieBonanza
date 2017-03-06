// Appllication Name:   Movie Bonanza
// Author's Name:       Yogeshkumar Patel
// Student ID:          200334362
// Date:                March 05, 2017
// Description:         This application provide facility to user for make selection of favourite movie 
//                      and also provide some extra features to add addinational things and at last
//                      shows their selection
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public partial class OrderForm : Form
    {
        // Create a new stream form object
        private StreamForm myStreamForm = new StreamForm();
        private Form previousForm;

        public Form PreviousForm
        {
            set
            {
                previousForm = value;
            }
        }
        public OrderForm()
        {
            InitializeComponent();
        }

        // Create dictionary to fill the data from previous form(selection form)
        public Dictionary<string, Object> Movie
        {
            // set value to all define textbox
            set
            {
                TitleTextBox.Text = (String)value["Title"];
                CategoryTextBox.Text = (String)value["Category"];
                CostTextBox.Text = (String)value["Cost"];
                LargePictureBox.Image = (System.Drawing.Image)value["Picture"];

                // Create private variable hold value for cost
                double _holdValue = Convert.ToDouble(CostTextBox.Text.Substring(1));
                
                // IF condition for checked checkbox checked or not
                if (DVDCheckBox.Checked)
                {
                    _holdValue += 10;
                }

                SubTotalTextBox.Text = "$" + Convert.ToString(_holdValue);
                SalesTaxTextBox.Text = "$" + Convert.ToString(0.13 * _holdValue);
                GrandTotalTextBox.Text = "$" + Convert.ToString(1.13 * _holdValue);
            }
        }

        /// <summary>
        /// Handler for print tool menu button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// Handler for checked checkbox event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double holdValue = Convert.ToDouble(CostTextBox.Text.Substring(1));

            if (DVDCheckBox.Checked == true)
            {
                holdValue += 10;
                SubTotalTextBox.Text = "$" + Convert.ToString(holdValue);
                SalesTaxTextBox.Text = "$" + Convert.ToString(0.13 * holdValue);
                GrandTotalTextBox.Text = "$" + Convert.ToString(1.13 * holdValue);
            }
            else
            {
                SubTotalTextBox.Text = "$" + Convert.ToString(holdValue);
                SalesTaxTextBox.Text = "$" + Convert.ToString(0.13 * holdValue);
                GrandTotalTextBox.Text = "$" + Convert.ToString(1.13 * holdValue);
            }
        }

        /// <summary>
        /// Handler for stream button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamButton_Click(object sender, EventArgs e)
        {
            // for hide current form
            this.Hide();
            // Create a new directory to catch data for next form
            myStreamForm.Movie = new Dictionary<string, string>
            {
                {"Title", TitleTextBox.Text},
                {"Cost", GrandTotalTextBox.Text}
            };
            myStreamForm.Show();

        }

        /// <summary>
        /// Handler for back button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {           
            previousForm.Show();
            this.Hide();
            
        }

        /// <summary>
        /// Handler for cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handler for about menu button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        /// <summary>
        /// Handler for 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your reciept:" + "\n" + "Movie Ordered: " + TitleTextBox.Text +
              "\n" + "Genre: " + CategoryTextBox.Text + "\n" +
              "Total Cost: " + SubTotalTextBox.Text);
        }

        private void StreamStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected movie stream sending to printer.!!");
        }

    }
}

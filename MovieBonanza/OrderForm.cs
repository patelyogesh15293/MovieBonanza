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
        public SelectionForm selectionForm;
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
            set
            {
                TitleTextBox.Text = (String)value["Title"];
                CategoryTextBox.Text = (String)value["Category"];
                CostTextBox.Text = (String)value["Cost"];
                LargePictureBox.Image = (System.Drawing.Image)value["Picture"];

                double holdValue = Convert.ToDouble(CostTextBox.Text.Substring(1));
                if (DVDCheckBox.Checked)
                {
                    holdValue += 10;
                }

                SubTotalTextBox.Text = "$" + Convert.ToString(holdValue);
                SalesTaxTextBox.Text = "$" + Convert.ToString(0.13 * holdValue);
                GrandTotalTextBox.Text = "$" + Convert.ToString(1.13 * holdValue);
            }
        }

        /// <summary>
        /// Handler for print tool menu button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your reciept:" + "\n" + "Movie Ordered: " + TitleTextBox.Text + 
                "\n" + "Genre: " + CategoryTextBox.Text + "\n" + 
                "Total Cost: " + SubTotalTextBox.Text);
        }

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
            this.Hide();
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
            selectionForm.Show();
            this.Hide();
            selectionForm.
        }

        /// <summary>
        /// Handler for cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handler for about menu button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}

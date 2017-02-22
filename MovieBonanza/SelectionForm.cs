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
    public partial class SelectionForm : Form
    {

        // Reference to previous created form
        public Form previousForm;

        public SelectionForm()
        {
            InitializeComponent();
        }

        private void SelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "confirm", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Program.mySplashForm.Close();
            }
            else
            {
                e.Cancel = true;               
            }
            
        }
    }
}

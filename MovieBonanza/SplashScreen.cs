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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Onload event handler for display welcome message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            // Initialize next form
            SelectionForm selectionForm = new SelectionForm();

            // Create a refernace to the parentform
            selectionForm.previousForm = this;
            // Splash screen timer enablees set to false
            this.SplashScreenTimer.Enabled = false;
            selectionForm.Show();
            this.Hide();

        }
    }
}

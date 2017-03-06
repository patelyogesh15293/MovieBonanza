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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        public Dictionary<string, string> Movie
        {
            set
            {
                CostLabel.Text = (String)value["Cost"];
                MovieLabel.Text = (String)value["Title"];
            }
            
        }
        /// <summary>
        /// Handler for ok button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

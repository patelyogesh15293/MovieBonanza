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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a field to set text value 
        /// </summary>
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

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
        //create a new order form
        OrderForm myOrderForm = new OrderForm();

        // Reference to previous created form
        public Form previousForm;

        public SelectionForm()
        {
            InitializeComponent();

            // Initialize a movies list box component
            CurrentMoviesListBox.DataSource = genres.Keys.ToArray();
        }

       // genres dictionary contain movie name and type for key value
        Dictionary<String, String> genres = new Dictionary<string, string>
        {
            {"Season of the Witch", "Sci-Fi"},
            {"The Green Hornet", "Action"},
            {"The Dilemma", "Comedy"},
            {"Death Race 2", "Action"},
            {"Company Men", "Drama"},
            {"No Strings Attached", "Comedy"},
            {"The Way Back", "Drama"},
            {"The Mechanic", "Action"},
            {"The Rite", "Horror"},
            {"Sanctum", "Action"},
            {"The Other Woman", "Action"},
            {"The Roommate", "Thriller"},
            {"Wairing for Forever", "Drama"},
            {"Cedar Rapids", "Comedy"},
            {"Gnomeo and Juliet", "Family"},
            {"Just Go With It", "Comedy"},
            {"The Eagle", "Action"},
            {"I am Number Four", "Sci-Fi"},
            {"Footloose", "New Releases"},
            {"Real Steel", "New Releases"}
        };

        //Create cost directory for store each movie cost
        Dictionary<String, String> costs = new Dictionary<string, string>
        {
            {"Comedy", "1.99"},
            {"Drama", "1.99"},
            {"Action", "2.99"},
            {"Sci-Fi", "2.99"},
            {"Horror", "2.99"},
            {"Thriller", "1.99"},
            {"Family", "0.99"},
            {"New Releases", "4.99"}            
        };

        private void CurrentMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            String movie = (String)listBox.SelectedItem;

            TitleTextBox.Text = movie;
            CategoryTextBox.Text = genres[movie];
            CostTextBox.Text = "$" + costs[genres[movie]];
            getImages();
        }

        /// <summary>
        /// Create a method for a get picture in picture box
        /// </summary>
        public void getImages()
        {
            
        }

        /// <summary>
        /// Hendler fo next button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            myOrderForm.Movie = new Dictionary<String, object>
            {
                {"Title", TitleTextBox.Text },
                {"Category", CategoryTextBox.Text },
                {"Cost", CostTextBox.Text },
                {"Picture", SmallPictureBox.Image }

            };
            myOrderForm.Show();
        }
    }
}

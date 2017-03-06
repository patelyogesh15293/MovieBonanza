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
    public partial class SelectionForm : Form
    {
        ////create a new order form
        //OrderForm myOrderForm = new OrderForm();

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
            // Object for catch user selected value
            ListBox listBox = (ListBox)sender;
            String movie = (String)listBox.SelectedItem;

            // Assign all text fields 
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
            //Conditions for checked textbox value and display picture 

            if (TitleTextBox.Text == "Cedar Rapids")
            {
                SmallPictureBox.Image = Properties.Resources.CedarRapids;
                Program.Movies.Poster = Properties.Resources.CedarRapids;
            }
            if (TitleTextBox.Text == "Company Men")
            {
                SmallPictureBox.Image = Properties.Resources.TheCompanyMen;
                Program.Movies.Poster = Properties.Resources.TheCompanyMen;
            }
            if (TitleTextBox.Text == "Death Race 2")
            {
                SmallPictureBox.Image = Properties.Resources.DeathRace2;
                Program.Movies.Poster = Properties.Resources.DeathRace2;
            }
            if (TitleTextBox.Text == "Footloose")
            {
                SmallPictureBox.Image = Properties.Resources.Footloose;
                Program.Movies.Poster = Properties.Resources.Footloose;
            }
            if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                SmallPictureBox.Image = Properties.Resources.GnomeoAndJuliet;
                Program.Movies.Poster = Properties.Resources.GnomeoAndJuliet;
            }
            if (TitleTextBox.Text == "I am Number Four")
            {
                SmallPictureBox.Image = Properties.Resources.IAmNumberFour;
                Program.Movies.Poster = Properties.Resources.IAmNumberFour;
            }
            if (TitleTextBox.Text == "Just Go With It")
            {
                SmallPictureBox.Image = Properties.Resources.JustGoWithIt;
                Program.Movies.Poster = Properties.Resources.JustGoWithIt;
            }
            if (TitleTextBox.Text == "No Strings Attached")
            {
                SmallPictureBox.Image = Properties.Resources.NoStringsAttached;
                Program.Movies.Poster = Properties.Resources.NoStringsAttached;

            }
            if (TitleTextBox.Text == "Real Steel")
            {
                SmallPictureBox.Image = Properties.Resources.RealSteel;
                Program.Movies.Poster = Properties.Resources.RealSteel;
            }
            if (TitleTextBox.Text == "Sanctum")
            {
                SmallPictureBox.Image = Properties.Resources.Sanctum;
                Program.Movies.Poster = Properties.Resources.Sanctum;
            }
            if (TitleTextBox.Text == "Season of the Witch")
            {
                SmallPictureBox.Image = Properties.Resources.SeasonOfTheWitch;
                Program.Movies.Poster = Properties.Resources.SeasonOfTheWitch;
            }
            if (TitleTextBox.Text == "The Dilemma")
            {
                SmallPictureBox.Image = Properties.Resources.TheDilemma;
                Program.Movies.Poster = Properties.Resources.TheDilemma;
            }
            if (TitleTextBox.Text == "The Eagle")
            {
                SmallPictureBox.Image = Properties.Resources.TheEagle;
                Program.Movies.Poster = Properties.Resources.TheEagle;
            }
            if (TitleTextBox.Text == "The Green Hornet")
            {
                SmallPictureBox.Image = Properties.Resources.TheGreenHornet;
                Program.Movies.Poster = Properties.Resources.TheGreenHornet;
            }
            if (TitleTextBox.Text == "The Mechanic")
            {
                SmallPictureBox.Image = Properties.Resources.TheMechanic;
                Program.Movies.Poster = Properties.Resources.TheMechanic;
            }
            if (TitleTextBox.Text == "The Other Woman")
            {
                SmallPictureBox.Image = Properties.Resources.TheOtherWoman;
                Program.Movies.Poster = Properties.Resources.TheOtherWoman;
            }
            if (TitleTextBox.Text == "The Rite")
            {
                SmallPictureBox.Image = Properties.Resources.TheRite;
                Program.Movies.Poster = Properties.Resources.TheRite;
            }
            if (TitleTextBox.Text == "The Roommate")
            {
                SmallPictureBox.Image = Properties.Resources.TheRoommate;
                Program.Movies.Poster = Properties.Resources.TheRoommate;
            }
            if (TitleTextBox.Text == "The Way Back")
            {
                SmallPictureBox.Image = Properties.Resources.TheWayBack;
                Program.Movies.Poster = Properties.Resources.TheWayBack;
            }
            if (TitleTextBox.Text == "Waiting for Forever")
            {
                SmallPictureBox.Image = Properties.Resources.WaitingForForever;
                Program.Movies.Poster = Properties.Resources.WaitingForForever;
            }

        }

        /// <summary>
        /// Hendler fo next button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm myOrderForm = new OrderForm();
            myOrderForm.Movie = new Dictionary<String, object>
            {
                {"Title", TitleTextBox.Text },
                {"Category", CategoryTextBox.Text },
                {"Cost", CostTextBox.Text },
                {"Picture", SmallPictureBox.Image }

            };
            myOrderForm.PreviousForm = this;

            this.Hide();
            myOrderForm.Show();
        }

    }
}

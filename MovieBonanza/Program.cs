using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public static class Program
    {
        // Declare public static form
        public static SplashForm mySplashForm;
        // Declare public static form
        public static SelectionForm mySelectionForm;

        // Create a instance of movie class
        //public static Movies ovieSeter = new Movies();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize splashform
            Program.mySplashForm = new SplashForm();
            // Initialize selection form
            Program.mySelectionForm = new SelectionForm();
            Application.Run(Program.mySplashForm);
        }
    }
}

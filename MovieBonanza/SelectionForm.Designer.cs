namespace MovieBonanza
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectionHeaderLabel = new System.Windows.Forms.Label();
            this.MovieHeaderSelectionLabel = new System.Windows.Forms.Label();
            this.CurrentMoviesListBox = new System.Windows.Forms.ListBox();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.SmallPictureBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.YourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionHeaderLabel
            // 
            this.SelectionHeaderLabel.AutoSize = true;
            this.SelectionHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.SelectionHeaderLabel.Name = "SelectionHeaderLabel";
            this.SelectionHeaderLabel.Size = new System.Drawing.Size(462, 18);
            this.SelectionHeaderLabel.TabIndex = 0;
            this.SelectionHeaderLabel.Text = "Choose the movies you wish to STREAM from the list below";
            // 
            // MovieHeaderSelectionLabel
            // 
            this.MovieHeaderSelectionLabel.AutoSize = true;
            this.MovieHeaderSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieHeaderSelectionLabel.Location = new System.Drawing.Point(12, 60);
            this.MovieHeaderSelectionLabel.Name = "MovieHeaderSelectionLabel";
            this.MovieHeaderSelectionLabel.Size = new System.Drawing.Size(123, 18);
            this.MovieHeaderSelectionLabel.TabIndex = 1;
            this.MovieHeaderSelectionLabel.Text = "Current Movies";
            // 
            // CurrentMoviesListBox
            // 
            this.CurrentMoviesListBox.FormattingEnabled = true;
            this.CurrentMoviesListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men ",
            "Death Race 2",
            "Footloose ",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite Horror Sanctum",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.CurrentMoviesListBox.Location = new System.Drawing.Point(15, 81);
            this.CurrentMoviesListBox.Name = "CurrentMoviesListBox";
            this.CurrentMoviesListBox.Size = new System.Drawing.Size(130, 186);
            this.CurrentMoviesListBox.Sorted = true;
            this.CurrentMoviesListBox.TabIndex = 2;
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Controls.Add(this.CategoryTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.TitleTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CostTextBox);
            this.YourSelectionGroupBox.Controls.Add(this.CategoryLabel);
            this.YourSelectionGroupBox.Controls.Add(this.TitleLabel);
            this.YourSelectionGroupBox.Controls.Add(this.CostLabel);
            this.YourSelectionGroupBox.Controls.Add(this.SmallPictureBox);
            this.YourSelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(174, 102);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(521, 165);
            this.YourSelectionGroupBox.TabIndex = 3;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "Your Selection";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(160, 121);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(175, 24);
            this.CategoryTextBox.TabIndex = 6;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(160, 55);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(338, 24);
            this.TitleTextBox.TabIndex = 5;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(398, 121);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 24);
            this.CostTextBox.TabIndex = 4;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(157, 100);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(76, 18);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(157, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(40, 18);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(395, 100);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(44, 18);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Cost";
            // 
            // SmallPictureBox
            // 
            this.SmallPictureBox.Location = new System.Drawing.Point(24, 32);
            this.SmallPictureBox.Name = "SmallPictureBox";
            this.SmallPictureBox.Size = new System.Drawing.Size(100, 113);
            this.SmallPictureBox.TabIndex = 0;
            this.SmallPictureBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextButton.Location = new System.Drawing.Point(620, 296);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 331);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.CurrentMoviesListBox);
            this.Controls.Add(this.MovieHeaderSelectionLabel);
            this.Controls.Add(this.SelectionHeaderLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza - Your Online Streaming Service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectionForm_FormClosing);
            this.YourSelectionGroupBox.ResumeLayout(false);
            this.YourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmallPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectionHeaderLabel;
        private System.Windows.Forms.Label MovieHeaderSelectionLabel;
        private System.Windows.Forms.ListBox CurrentMoviesListBox;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.PictureBox SmallPictureBox;
        private System.Windows.Forms.Button NextButton;
    }
}


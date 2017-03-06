namespace MovieBonanza
{
    partial class StreamForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.ThanksLabel = new System.Windows.Forms.Label();
            this.YourMovieLabel = new System.Windows.Forms.Label();
            this.CreditCardLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(146, 170);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(60, 26);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ThanksLabel
            // 
            this.ThanksLabel.AutoSize = true;
            this.ThanksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanksLabel.Location = new System.Drawing.Point(44, 34);
            this.ThanksLabel.Name = "ThanksLabel";
            this.ThanksLabel.Size = new System.Drawing.Size(262, 16);
            this.ThanksLabel.TabIndex = 1;
            this.ThanksLabel.Text = "Thanks for choosing Movie Bonanza!";
            // 
            // YourMovieLabel
            // 
            this.YourMovieLabel.AutoSize = true;
            this.YourMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourMovieLabel.Location = new System.Drawing.Point(122, 122);
            this.YourMovieLabel.Name = "YourMovieLabel";
            this.YourMovieLabel.Size = new System.Drawing.Size(203, 16);
            this.YourMovieLabel.TabIndex = 1;
            this.YourMovieLabel.Text = " will begin streaming shortly!";
            // 
            // CreditCardLabel
            // 
            this.CreditCardLabel.AutoSize = true;
            this.CreditCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardLabel.Location = new System.Drawing.Point(29, 79);
            this.CreditCardLabel.Name = "CreditCardLabel";
            this.CreditCardLabel.Size = new System.Drawing.Size(237, 16);
            this.CreditCardLabel.TabIndex = 1;
            this.CreditCardLabel.Text = "Your Credit Card will be Charged ";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(272, 79);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(73, 16);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "[X Dollar]";
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieLabel.Location = new System.Drawing.Point(29, 122);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(96, 16);
            this.MovieLabel.TabIndex = 3;
            this.MovieLabel.Text = "[Your Movie]";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 208);
            this.ControlBox = false;
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CreditCardLabel);
            this.Controls.Add(this.YourMovieLabel);
            this.Controls.Add(this.ThanksLabel);
            this.Controls.Add(this.OkButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StreamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label ThanksLabel;
        private System.Windows.Forms.Label YourMovieLabel;
        private System.Windows.Forms.Label CreditCardLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label MovieLabel;
    }
}
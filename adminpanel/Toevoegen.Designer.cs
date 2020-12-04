namespace adminpanel
{
    partial class Toevoegen
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
            this.Rekeningnmr = new System.Windows.Forms.TextBox();
            this.Pin = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.roleBox = new System.Windows.Forms.CheckBox();
            this.Pin2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userExistsLabel = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.countryRoadsTakeMeHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rekeningnmr
            // 
            this.Rekeningnmr.Location = new System.Drawing.Point(320, 141);
            this.Rekeningnmr.Name = "Rekeningnmr";
            this.Rekeningnmr.Size = new System.Drawing.Size(141, 20);
            this.Rekeningnmr.TabIndex = 0;
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(320, 192);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(141, 20);
            this.Pin.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(320, 300);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(141, 20);
            this.Email.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rekening nummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pincode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(348, 359);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Verstuur";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // roleBox
            // 
            this.roleBox.AutoSize = true;
            this.roleBox.Location = new System.Drawing.Point(320, 326);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(61, 17);
            this.roleBox.TabIndex = 7;
            this.roleBox.Text = "Admin?";
            this.roleBox.UseVisualStyleBackColor = true;
            // 
            // Pin2
            // 
            this.Pin2.Location = new System.Drawing.Point(320, 246);
            this.Pin2.Name = "Pin2";
            this.Pin2.Size = new System.Drawing.Size(141, 20);
            this.Pin2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Herhaal pincode";
            // 
            // userExistsLabel
            // 
            this.userExistsLabel.AutoSize = true;
            this.userExistsLabel.ForeColor = System.Drawing.Color.Red;
            this.userExistsLabel.Location = new System.Drawing.Point(335, 385);
            this.userExistsLabel.Name = "userExistsLabel";
            this.userExistsLabel.Size = new System.Drawing.Size(105, 13);
            this.userExistsLabel.TabIndex = 10;
            this.userExistsLabel.Text = "Gebruiker bestaat al!";
            this.userExistsLabel.Visible = false;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(320, 89);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(141, 20);
            this.fullName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Full name";
            // 
            // countryRoadsTakeMeHome
            // 
            this.countryRoadsTakeMeHome.Location = new System.Drawing.Point(12, 12);
            this.countryRoadsTakeMeHome.Name = "countryRoadsTakeMeHome";
            this.countryRoadsTakeMeHome.Size = new System.Drawing.Size(142, 23);
            this.countryRoadsTakeMeHome.TabIndex = 13;
            this.countryRoadsTakeMeHome.Text = "Main menu";
            this.countryRoadsTakeMeHome.UseVisualStyleBackColor = true;
            this.countryRoadsTakeMeHome.Click += new System.EventHandler(this.countryRoadsTakeMeHome_Click);
            // 
            // Toevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countryRoadsTakeMeHome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.userExistsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pin2);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.Rekeningnmr);
            this.Name = "Toevoegen";
            this.Text = "Toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Rekeningnmr;
        private System.Windows.Forms.TextBox Pin;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckBox roleBox;
        private System.Windows.Forms.TextBox Pin2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userExistsLabel;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button countryRoadsTakeMeHome;
    }
}
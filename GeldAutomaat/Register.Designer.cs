namespace GeldAutomaat
{
    partial class Register
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
            this.emailInput = new System.Windows.Forms.TextBox();
            this.accountNumberInput = new System.Windows.Forms.TextBox();
            this.pinInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.pinInput2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userExistsLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(408, 149);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(211, 20);
            this.emailInput.TabIndex = 1;
            // 
            // accountNumberInput
            // 
            this.accountNumberInput.Location = new System.Drawing.Point(408, 188);
            this.accountNumberInput.Name = "accountNumberInput";
            this.accountNumberInput.Size = new System.Drawing.Size(211, 20);
            this.accountNumberInput.TabIndex = 0;
            // 
            // pinInput
            // 
            this.pinInput.Location = new System.Drawing.Point(470, 227);
            this.pinInput.Name = "pinInput";
            this.pinInput.Size = new System.Drawing.Size(100, 20);
            this.pinInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pin";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(470, 301);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Register";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // pinInput2
            // 
            this.pinInput2.Location = new System.Drawing.Point(470, 266);
            this.pinInput2.Name = "pinInput2";
            this.pinInput2.Size = new System.Drawing.Size(100, 20);
            this.pinInput2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repeat Pin";
            // 
            // userExistsLabel
            // 
            this.userExistsLabel.AutoSize = true;
            this.userExistsLabel.ForeColor = System.Drawing.Color.Red;
            this.userExistsLabel.Location = new System.Drawing.Point(472, 340);
            this.userExistsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userExistsLabel.Name = "userExistsLabel";
            this.userExistsLabel.Size = new System.Drawing.Size(105, 13);
            this.userExistsLabel.TabIndex = 27;
            this.userExistsLabel.Text = "Gebruiker bestaat al!";
            this.userExistsLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GeldAutomaat.Properties.Resources.colored_flagscape_v2;
            this.pictureBox1.Location = new System.Drawing.Point(89, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 151);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userExistsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pinInput2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinInput);
            this.Controls.Add(this.accountNumberInput);
            this.Controls.Add(this.emailInput);
            this.Name = "Register";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox accountNumberInput;
        private System.Windows.Forms.TextBox pinInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox pinInput2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userExistsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace GeldAutomaat
{
    partial class saldo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.saldoLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TakeMeHomeCountryRoads = new GeldAutomaat.RoundButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huidig saldo:";
            // 
            // saldoLbl
            // 
            this.saldoLbl.AutoSize = true;
            this.saldoLbl.Location = new System.Drawing.Point(226, 163);
            this.saldoLbl.Name = "saldoLbl";
            this.saldoLbl.Size = new System.Drawing.Size(0, 13);
            this.saldoLbl.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TakeMeHomeCountryRoads
            // 
            this.TakeMeHomeCountryRoads.Location = new System.Drawing.Point(12, 12);
            this.TakeMeHomeCountryRoads.Name = "TakeMeHomeCountryRoads";
            this.TakeMeHomeCountryRoads.Size = new System.Drawing.Size(85, 83);
            this.TakeMeHomeCountryRoads.TabIndex = 12;
            this.TakeMeHomeCountryRoads.Text = "Homepagina";
            this.TakeMeHomeCountryRoads.UseVisualStyleBackColor = true;
            this.TakeMeHomeCountryRoads.Click += new System.EventHandler(this.TakeMeHomeCountryRoads_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saldoLbl);
            this.groupBox1.Location = new System.Drawing.Point(127, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 563);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GeldAutomaat.Properties.Resources.colored_flagscape_v2;
            this.pictureBox1.Location = new System.Drawing.Point(89, -41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 151);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1083, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TakeMeHomeCountryRoads);
            this.Name = "saldo";
            this.Text = "saldo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label saldoLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private RoundButton TakeMeHomeCountryRoads;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
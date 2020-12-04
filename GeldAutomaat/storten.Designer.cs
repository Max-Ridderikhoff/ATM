namespace GeldAutomaat
{
    partial class storten
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
            this.hoerin = new GeldAutomaat.RoundButton();
            this.TakeMeHomeCountryRoads = new GeldAutomaat.RoundButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // hoerin
            // 
            this.hoerin.BackColor = System.Drawing.SystemColors.Control;
            this.hoerin.Location = new System.Drawing.Point(986, 227);
            this.hoerin.Name = "hoerin";
            this.hoerin.Size = new System.Drawing.Size(85, 83);
            this.hoerin.TabIndex = 22;
            this.hoerin.Text = "Voer in";
            this.hoerin.UseVisualStyleBackColor = false;
            this.hoerin.Click += new System.EventHandler(this.hoerin_Click);
            // 
            // TakeMeHomeCountryRoads
            // 
            this.TakeMeHomeCountryRoads.Location = new System.Drawing.Point(12, 227);
            this.TakeMeHomeCountryRoads.Name = "TakeMeHomeCountryRoads";
            this.TakeMeHomeCountryRoads.Size = new System.Drawing.Size(85, 83);
            this.TakeMeHomeCountryRoads.TabIndex = 13;
            this.TakeMeHomeCountryRoads.Text = "Homepagina";
            this.TakeMeHomeCountryRoads.UseVisualStyleBackColor = true;
            this.TakeMeHomeCountryRoads.Click += new System.EventHandler(this.TakeMeHomeCountryRoads_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(122, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 565);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GeldAutomaat.Properties.Resources.colored_flagscape_v2;
            this.pictureBox2.Location = new System.Drawing.Point(89, -41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 150);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // storten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1083, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hoerin);
            this.Controls.Add(this.TakeMeHomeCountryRoads);
            this.Name = "storten";
            this.Text = "storten";
            this.Load += new System.EventHandler(this.storten_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton TakeMeHomeCountryRoads;
        private RoundButton hoerin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
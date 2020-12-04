namespace GeldAutomaat
{
    partial class userDashboard
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
            this.storten = new System.Windows.Forms.Label();
            this.trans = new System.Windows.Forms.Label();
            this.laatste3 = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            this.Logout = new GeldAutomaat.RoundButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // storten
            // 
            this.storten.AutoSize = true;
            this.storten.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.storten.ForeColor = System.Drawing.Color.Crimson;
            this.storten.Location = new System.Drawing.Point(350, 198);
            this.storten.Name = "storten";
            this.storten.Size = new System.Drawing.Size(79, 23);
            this.storten.TabIndex = 10;
            this.storten.Text = "Storten";
            this.storten.Click += new System.EventHandler(this.storten_Click_1);
            // 
            // trans
            // 
            this.trans.AutoSize = true;
            this.trans.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.trans.ForeColor = System.Drawing.Color.Crimson;
            this.trans.Location = new System.Drawing.Point(350, 60);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(76, 23);
            this.trans.TabIndex = 9;
            this.trans.Text = "Pinnen";
            this.trans.Click += new System.EventHandler(this.trans_Click_1);
            // 
            // laatste3
            // 
            this.laatste3.AutoSize = true;
            this.laatste3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laatste3.ForeColor = System.Drawing.Color.Crimson;
            this.laatste3.Location = new System.Drawing.Point(350, 480);
            this.laatste3.Name = "laatste3";
            this.laatste3.Size = new System.Drawing.Size(259, 23);
            this.laatste3.TabIndex = 8;
            this.laatste3.Text = "Tonen laatste 3 transacties";
            this.laatste3.Click += new System.EventHandler(this.laatste3_Click_1);
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.saldo.ForeColor = System.Drawing.Color.Crimson;
            this.saldo.Location = new System.Drawing.Point(350, 347);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(194, 23);
            this.saldo.TabIndex = 7;
            this.saldo.Text = "Tonen huidig saldo";
            this.saldo.Click += new System.EventHandler(this.saldo_Click_1);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(85, 83);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Uitloggen";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.trans);
            this.groupBox1.Controls.Add(this.storten);
            this.groupBox1.Controls.Add(this.saldo);
            this.groupBox1.Controls.Add(this.laatste3);
            this.groupBox1.Location = new System.Drawing.Point(175, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 579);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GeldAutomaat.Properties.Resources.colored_flagscape_v2;
            this.pictureBox2.Location = new System.Drawing.Point(89, -41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 151);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // userDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1247, 576);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logout);
            this.Name = "userDashboard";
            this.Text = "userDashboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton Logout;
        private System.Windows.Forms.Label storten;
        private System.Windows.Forms.Label trans;
        private System.Windows.Forms.Label laatste3;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
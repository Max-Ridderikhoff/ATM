namespace GeldAutomaat
{
    partial class laatste3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridTransacties = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TakeMeHomeCountryRoads = new GeldAutomaat.RoundButton();
            this.dataTableAdapter1 = new Ivony.Data.Common.DataTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransacties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dataGridTransacties);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(124, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 568);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // dataGridTransacties
            // 
            this.dataGridTransacties.AllowUserToOrderColumns = true;
            this.dataGridTransacties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransacties.ColumnHeadersHeight = 35;
            this.dataGridTransacties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.money,
            this.date});
            this.dataGridTransacties.Location = new System.Drawing.Point(245, 222);
            this.dataGridTransacties.Name = "dataGridTransacties";
            this.dataGridTransacties.RowHeadersVisible = false;
            this.dataGridTransacties.RowHeadersWidth = 70;
            this.dataGridTransacties.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridTransacties.Size = new System.Drawing.Size(447, 157);
            this.dataGridTransacties.TabIndex = 26;
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
            // TakeMeHomeCountryRoads
            // 
            this.TakeMeHomeCountryRoads.Location = new System.Drawing.Point(12, 12);
            this.TakeMeHomeCountryRoads.Name = "TakeMeHomeCountryRoads";
            this.TakeMeHomeCountryRoads.Size = new System.Drawing.Size(85, 83);
            this.TakeMeHomeCountryRoads.TabIndex = 13;
            this.TakeMeHomeCountryRoads.Text = "Homepagina";
            this.TakeMeHomeCountryRoads.UseVisualStyleBackColor = true;
            this.TakeMeHomeCountryRoads.Click += new System.EventHandler(this.TakeMeHomeCountryRoads_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // money
            // 
            this.money.HeaderText = "Geld in €";
            this.money.MinimumWidth = 10;
            this.money.Name = "money";
            // 
            // date
            // 
            this.date.HeaderText = "Datum en Tijd";
            this.date.MinimumWidth = 10;
            this.date.Name = "date";
            // 
            // laatste3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1083, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TakeMeHomeCountryRoads);
            this.Name = "laatste3";
            this.Text = "laatste3";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransacties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton TakeMeHomeCountryRoads;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridTransacties;
        private Ivony.Data.Common.DataTableAdapter dataTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}
namespace TelephoneBook
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upateNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNumbers = new System.Windows.Forms.DataGridView();
            this.C_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNumberToolStripMenuItem,
            this.removeNumberToolStripMenuItem,
            this.upateNumberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNumberToolStripMenuItem
            // 
            this.addNumberToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addNumberToolStripMenuItem.Name = "addNumberToolStripMenuItem";
            this.addNumberToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.addNumberToolStripMenuItem.Text = "Add Number";
            this.addNumberToolStripMenuItem.Click += new System.EventHandler(this.addNumberToolStripMenuItem_Click);
            // 
            // removeNumberToolStripMenuItem
            // 
            this.removeNumberToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.removeNumberToolStripMenuItem.Name = "removeNumberToolStripMenuItem";
            this.removeNumberToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.removeNumberToolStripMenuItem.Text = "Remove Number";
            this.removeNumberToolStripMenuItem.Click += new System.EventHandler(this.removeNumberToolStripMenuItem_Click);
            // 
            // upateNumberToolStripMenuItem
            // 
            this.upateNumberToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.upateNumberToolStripMenuItem.Name = "upateNumberToolStripMenuItem";
            this.upateNumberToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.upateNumberToolStripMenuItem.Text = "Upate Number";
            this.upateNumberToolStripMenuItem.Click += new System.EventHandler(this.upateNumberToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewNumbers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numbers";
            // 
            // dataGridViewNumbers
            // 
            this.dataGridViewNumbers.AllowUserToAddRows = false;
            this.dataGridViewNumbers.AllowUserToDeleteRows = false;
            this.dataGridViewNumbers.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Id,
            this.C_Name,
            this.C_Surname,
            this.C_Number});
            this.dataGridViewNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNumbers.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNumbers.Name = "dataGridViewNumbers";
            this.dataGridViewNumbers.ReadOnly = true;
            this.dataGridViewNumbers.Size = new System.Drawing.Size(794, 407);
            this.dataGridViewNumbers.TabIndex = 0;
            // 
            // C_Id
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            this.C_Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.C_Id.HeaderText = "ID";
            this.C_Id.Name = "C_Id";
            this.C_Id.ReadOnly = true;
            // 
            // C_Name
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            this.C_Name.DefaultCellStyle = dataGridViewCellStyle2;
            this.C_Name.HeaderText = "NAME";
            this.C_Name.Name = "C_Name";
            this.C_Name.ReadOnly = true;
            // 
            // C_Surname
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            this.C_Surname.DefaultCellStyle = dataGridViewCellStyle3;
            this.C_Surname.HeaderText = "SURNAME";
            this.C_Surname.Name = "C_Surname";
            this.C_Surname.ReadOnly = true;
            // 
            // C_Number
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            this.C_Number.DefaultCellStyle = dataGridViewCellStyle4;
            this.C_Number.HeaderText = "NUMBER";
            this.C_Number.Name = "C_Number";
            this.C_Number.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upateNumberToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Number;
    }
}


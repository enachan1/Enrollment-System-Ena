namespace Enrollment_System
{
    partial class Balances
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balances));
            this.balanceLst = new System.Windows.Forms.DataGridView();
            this.col0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bal = new System.Windows.Forms.TextBox();
            this.paymentText = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.balanceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeldas = new System.Windows.Forms.Label();
            this.pstuNum = new System.Windows.Forms.TextBox();
            this.pProg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.balanceLst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // balanceLst
            // 
            this.balanceLst.AllowUserToAddRows = false;
            this.balanceLst.AllowUserToDeleteRows = false;
            this.balanceLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceLst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col0,
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.balanceLst.Location = new System.Drawing.Point(11, 80);
            this.balanceLst.Margin = new System.Windows.Forms.Padding(2);
            this.balanceLst.Name = "balanceLst";
            this.balanceLst.ReadOnly = true;
            this.balanceLst.RowHeadersVisible = false;
            this.balanceLst.RowHeadersWidth = 51;
            this.balanceLst.RowTemplate.Height = 24;
            this.balanceLst.Size = new System.Drawing.Size(1150, 304);
            this.balanceLst.TabIndex = 42;
            this.balanceLst.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.balanceLst_CellClick);
            // 
            // col0
            // 
            this.col0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col0.DataPropertyName = "stunum";
            this.col0.HeaderText = "Student Number";
            this.col0.Name = "col0";
            this.col0.ReadOnly = true;
            // 
            // col1
            // 
            this.col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1.DataPropertyName = "name";
            this.col1.HeaderText = "Name";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col2.DataPropertyName = "program";
            this.col2.HeaderText = "Program";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col3.DataPropertyName = "balance";
            this.col3.HeaderText = "Balance";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.DataPropertyName = "id";
            this.col4.HeaderText = "id";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            this.col4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Balances";
            // 
            // searchBar
            // 
            this.searchBar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(729, 47);
            this.searchBar.Margin = new System.Windows.Forms.Padding(2);
            this.searchBar.Multiline = true;
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(262, 29);
            this.searchBar.TabIndex = 39;
            this.searchBar.Text = "Search...";
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            this.searchBar.Enter += new System.EventHandler(this.searchBar_Enter);
            this.searchBar.Leave += new System.EventHandler(this.searchBar_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.balanceLst);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 721);
            this.panel1.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Student Number",
            "Name"});
            this.comboBox1.Location = new System.Drawing.Point(996, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 30);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.Tag = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 394);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(39, 394);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 22);
            this.label14.TabIndex = 50;
            this.label14.Text = "Student\'s Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bal);
            this.panel2.Controls.Add(this.paymentText);
            this.panel2.Controls.Add(this.printBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.balanceText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labeldas);
            this.panel2.Controls.Add(this.pstuNum);
            this.panel2.Controls.Add(this.pProg);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.pName);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Location = new System.Drawing.Point(16, 422);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 278);
            this.panel2.TabIndex = 49;
            // 
            // bal
            // 
            this.bal.Enabled = false;
            this.bal.Font = new System.Drawing.Font("Montserrat", 20F);
            this.bal.Location = new System.Drawing.Point(942, 130);
            this.bal.Margin = new System.Windows.Forms.Padding(2);
            this.bal.Multiline = true;
            this.bal.Name = "bal";
            this.bal.ShortcutsEnabled = false;
            this.bal.Size = new System.Drawing.Size(152, 51);
            this.bal.TabIndex = 69;
            this.bal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bal.Visible = false;
            // 
            // paymentText
            // 
            this.paymentText.Font = new System.Drawing.Font("Montserrat", 20F);
            this.paymentText.Location = new System.Drawing.Point(942, 130);
            this.paymentText.Margin = new System.Windows.Forms.Padding(2);
            this.paymentText.Multiline = true;
            this.paymentText.Name = "paymentText";
            this.paymentText.ShortcutsEnabled = false;
            this.paymentText.Size = new System.Drawing.Size(152, 51);
            this.paymentText.TabIndex = 68;
            this.paymentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paymentText.TextChanged += new System.EventHandler(this.paymentText_TextChanged);
            this.paymentText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paymentText_KeyPress);
            // 
            // printBtn
            // 
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printBtn.Location = new System.Drawing.Point(930, 203);
            this.printBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(164, 40);
            this.printBtn.TabIndex = 67;
            this.printBtn.Text = "        Print Receipt";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(978, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Payment";
            // 
            // balanceText
            // 
            this.balanceText.Enabled = false;
            this.balanceText.Font = new System.Drawing.Font("Montserrat", 20F);
            this.balanceText.Location = new System.Drawing.Point(942, 41);
            this.balanceText.Margin = new System.Windows.Forms.Padding(2);
            this.balanceText.Multiline = true;
            this.balanceText.Name = "balanceText";
            this.balanceText.ShortcutsEnabled = false;
            this.balanceText.Size = new System.Drawing.Size(152, 51);
            this.balanceText.TabIndex = 64;
            this.balanceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.balanceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(986, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Balance";
            // 
            // labeldas
            // 
            this.labeldas.AutoSize = true;
            this.labeldas.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldas.Location = new System.Drawing.Point(16, 8);
            this.labeldas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeldas.Name = "labeldas";
            this.labeldas.Size = new System.Drawing.Size(135, 20);
            this.labeldas.TabIndex = 62;
            this.labeldas.Text = "Student Number:";
            // 
            // pstuNum
            // 
            this.pstuNum.Enabled = false;
            this.pstuNum.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pstuNum.Location = new System.Drawing.Point(16, 30);
            this.pstuNum.Margin = new System.Windows.Forms.Padding(2);
            this.pstuNum.Multiline = true;
            this.pstuNum.Name = "pstuNum";
            this.pstuNum.Size = new System.Drawing.Size(358, 32);
            this.pstuNum.TabIndex = 61;
            // 
            // pProg
            // 
            this.pProg.Enabled = false;
            this.pProg.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pProg.Location = new System.Drawing.Point(434, 101);
            this.pProg.Margin = new System.Windows.Forms.Padding(2);
            this.pProg.Multiline = true;
            this.pProg.Name = "pProg";
            this.pProg.Size = new System.Drawing.Size(408, 32);
            this.pProg.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(432, 79);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 55;
            this.label12.Text = "Program:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 51;
            this.label13.Text = "Name:";
            // 
            // pName
            // 
            this.pName.Enabled = false;
            this.pName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pName.Location = new System.Drawing.Point(15, 101);
            this.pName.Margin = new System.Windows.Forms.Padding(2);
            this.pName.Multiline = true;
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(359, 32);
            this.pName.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(9, 19);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 20);
            this.label21.TabIndex = 49;
            // 
            // Balances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Balances";
            this.Size = new System.Drawing.Size(1178, 721);
            this.Load += new System.EventHandler(this.Balances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balanceLst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labeldas;
        public System.Windows.Forms.TextBox pstuNum;
        public System.Windows.Forms.TextBox pProg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox balanceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.TextBox paymentText;
        private System.Windows.Forms.DataGridViewTextBoxColumn col0;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        public System.Windows.Forms.DataGridView balanceLst;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox bal;
    }
}

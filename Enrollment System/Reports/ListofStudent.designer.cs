namespace Enrollment_System
{
    partial class ListofStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListofStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBy = new System.Windows.Forms.ComboBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameDelete = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listofStd = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtdfg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthplaceasd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asdgxccvb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listofStd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchBy);
            this.panel1.Controls.Add(this.printBtn);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nameDelete);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 758);
            this.panel1.TabIndex = 3;
            // 
            // searchBy
            // 
            this.searchBy.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBy.FormattingEnabled = true;
            this.searchBy.Items.AddRange(new object[] {
            "Name",
            "Birthday",
            "Address"});
            this.searchBy.Location = new System.Drawing.Point(801, 107);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(165, 30);
            this.searchBy.TabIndex = 45;
            this.searchBy.Tag = "";
            this.searchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBy_KeyPress);
            // 
            // printBtn
            // 
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printBtn.Location = new System.Drawing.Point(828, 659);
            this.printBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(138, 32);
            this.printBtn.TabIndex = 44;
            this.printBtn.Text = "     Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(545, 71);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(184, 662);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Name:";
            // 
            // nameDelete
            // 
            this.nameDelete.Enabled = false;
            this.nameDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDelete.Location = new System.Drawing.Point(252, 658);
            this.nameDelete.Margin = new System.Windows.Forms.Padding(2);
            this.nameDelete.Multiline = true;
            this.nameDelete.Name = "nameDelete";
            this.nameDelete.Size = new System.Drawing.Size(401, 32);
            this.nameDelete.TabIndex = 41;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Location = new System.Drawing.Point(797, 79);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 22);
            this.label22.TabIndex = 36;
            this.label22.Text = "Search by:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(672, 658);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(138, 32);
            this.deleteBtn.TabIndex = 40;
            this.deleteBtn.Text = "      Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(222, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listofStd);
            this.panel2.Location = new System.Drawing.Point(194, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 511);
            this.panel2.TabIndex = 1;
            // 
            // listofStd
            // 
            this.listofStd.AllowUserToAddRows = false;
            this.listofStd.AllowUserToDeleteRows = false;
            this.listofStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listofStd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.rtg,
            this.rtdfg,
            this.Birthplaceasd,
            this.redf,
            this.asdgxccvb,
            this.gname,
            this.Cont,
            this.em});
            this.listofStd.Location = new System.Drawing.Point(17, 34);
            this.listofStd.Margin = new System.Windows.Forms.Padding(2);
            this.listofStd.Name = "listofStd";
            this.listofStd.ReadOnly = true;
            this.listofStd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listofStd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listofStd.RowHeadersVisible = false;
            this.listofStd.RowHeadersWidth = 51;
            this.listofStd.RowTemplate.Height = 24;
            this.listofStd.Size = new System.Drawing.Size(733, 448);
            this.listofStd.TabIndex = 0;
            this.listofStd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClick);
            // 
            // col1
            // 
            this.col1.DataPropertyName = "id";
            this.col1.HeaderText = "id";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Visible = false;
            // 
            // col2
            // 
            this.col2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col2.DataPropertyName = "Full_Name";
            this.col2.HeaderText = "Name";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col3.DataPropertyName = "Gender";
            this.col3.HeaderText = "Gender";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.DataPropertyName = "Civil_Status";
            this.col4.HeaderText = "Civil Status";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            this.col4.Visible = false;
            // 
            // rtg
            // 
            this.rtg.DataPropertyName = "Citizenship";
            this.rtg.HeaderText = "Citizenship";
            this.rtg.Name = "rtg";
            this.rtg.ReadOnly = true;
            this.rtg.Visible = false;
            // 
            // rtdfg
            // 
            this.rtdfg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rtdfg.DataPropertyName = "Birthday";
            this.rtdfg.HeaderText = "Birthday";
            this.rtdfg.Name = "rtdfg";
            this.rtdfg.ReadOnly = true;
            // 
            // Birthplaceasd
            // 
            this.Birthplaceasd.DataPropertyName = "Birthplace";
            this.Birthplaceasd.HeaderText = "Birthplace";
            this.Birthplaceasd.Name = "Birthplaceasd";
            this.Birthplaceasd.ReadOnly = true;
            this.Birthplaceasd.Visible = false;
            // 
            // redf
            // 
            this.redf.DataPropertyName = "Religion";
            this.redf.HeaderText = "Religion";
            this.redf.Name = "redf";
            this.redf.ReadOnly = true;
            this.redf.Visible = false;
            // 
            // asdgxccvb
            // 
            this.asdgxccvb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asdgxccvb.DataPropertyName = "Address";
            this.asdgxccvb.HeaderText = "Address";
            this.asdgxccvb.Name = "asdgxccvb";
            this.asdgxccvb.ReadOnly = true;
            // 
            // gname
            // 
            this.gname.DataPropertyName = "Guardian_Name";
            this.gname.HeaderText = "Guradian Name";
            this.gname.Name = "gname";
            this.gname.ReadOnly = true;
            this.gname.Visible = false;
            // 
            // Cont
            // 
            this.Cont.DataPropertyName = "Contact";
            this.Cont.HeaderText = "Contact";
            this.Cont.Name = "Cont";
            this.Cont.ReadOnly = true;
            this.Cont.Visible = false;
            // 
            // em
            // 
            this.em.DataPropertyName = "Email";
            this.em.HeaderText = "Email";
            this.em.Name = "em";
            this.em.ReadOnly = true;
            this.em.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(545, 103);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 32);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.Text = "Search Student...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtChange);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // ListofStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListofStudent";
            this.Size = new System.Drawing.Size(1178, 758);
            this.Load += new System.EventHandler(this.ListofStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listofStd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtdfg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthplaceasd;
        private System.Windows.Forms.DataGridViewTextBoxColumn redf;
        private System.Windows.Forms.DataGridViewTextBoxColumn asdgxccvb;
        private System.Windows.Forms.DataGridViewTextBoxColumn gname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn em;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView listofStd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox nameDelete;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox searchBy;
        private System.Windows.Forms.Button printBtn;
    }
}

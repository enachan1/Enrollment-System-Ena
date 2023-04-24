namespace Enrollment_System
{
    partial class ManageSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSubject));
            this.panel2 = new System.Windows.Forms.Panel();
            this.subjectList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hoursText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.daysCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.programCB = new System.Windows.Forms.ComboBox();
            this.sectionCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.addProgramBTN = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.subjectList);
            this.panel2.Location = new System.Drawing.Point(174, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 335);
            this.panel2.TabIndex = 50;
            // 
            // subjectList
            // 
            this.subjectList.AllowUserToAddRows = false;
            this.subjectList.AllowUserToDeleteRows = false;
            this.subjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subjname,
            this.prog,
            this.sect,
            this.days1,
            this.hours1});
            this.subjectList.Location = new System.Drawing.Point(39, 27);
            this.subjectList.Name = "subjectList";
            this.subjectList.ReadOnly = true;
            this.subjectList.RowHeadersVisible = false;
            this.subjectList.RowHeadersWidth = 51;
            this.subjectList.Size = new System.Drawing.Size(758, 278);
            this.subjectList.TabIndex = 0;
            this.subjectList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectList_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // subjname
            // 
            this.subjname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjname.DataPropertyName = "subjectname";
            this.subjname.HeaderText = "Subject";
            this.subjname.MinimumWidth = 6;
            this.subjname.Name = "subjname";
            this.subjname.ReadOnly = true;
            // 
            // prog
            // 
            this.prog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prog.DataPropertyName = "program";
            this.prog.HeaderText = "Program";
            this.prog.MinimumWidth = 6;
            this.prog.Name = "prog";
            this.prog.ReadOnly = true;
            // 
            // sect
            // 
            this.sect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sect.DataPropertyName = "section";
            this.sect.HeaderText = "Section";
            this.sect.MinimumWidth = 6;
            this.sect.Name = "sect";
            this.sect.ReadOnly = true;
            // 
            // days1
            // 
            this.days1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.days1.DataPropertyName = "days";
            this.days1.HeaderText = "Days";
            this.days1.Name = "days1";
            this.days1.ReadOnly = true;
            // 
            // hours1
            // 
            this.hours1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hours1.DataPropertyName = "hours";
            this.hours1.HeaderText = "Hours";
            this.hours1.Name = "hours1";
            this.hours1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(203, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Manage Subject";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hoursText);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.daysCB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.programCB);
            this.panel1.Controls.Add(this.sectionCB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.subjectText);
            this.panel1.Location = new System.Drawing.Point(174, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 276);
            this.panel1.TabIndex = 48;
            // 
            // hoursText
            // 
            this.hoursText.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursText.Location = new System.Drawing.Point(363, 199);
            this.hoursText.Multiline = true;
            this.hoursText.Name = "hoursText";
            this.hoursText.Size = new System.Drawing.Size(269, 32);
            this.hoursText.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(302, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "Hours:";
            // 
            // daysCB
            // 
            this.daysCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysCB.FormattingEnabled = true;
            this.daysCB.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesdays",
            "Thursday",
            "Friday"});
            this.daysCB.Location = new System.Drawing.Point(88, 200);
            this.daysCB.Margin = new System.Windows.Forms.Padding(2);
            this.daysCB.Name = "daysCB";
            this.daysCB.Size = new System.Drawing.Size(200, 34);
            this.daysCB.TabIndex = 63;
            this.daysCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.programCB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 21);
            this.label6.TabIndex = 62;
            this.label6.Text = "Days:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 61;
            this.label5.Text = "Schedule:";
            // 
            // programCB
            // 
            this.programCB.Font = new System.Drawing.Font("Montserrat", 14F);
            this.programCB.FormattingEnabled = true;
            this.programCB.Location = new System.Drawing.Point(39, 121);
            this.programCB.Margin = new System.Windows.Forms.Padding(2);
            this.programCB.Name = "programCB";
            this.programCB.Size = new System.Drawing.Size(517, 34);
            this.programCB.TabIndex = 60;
            this.programCB.Click += new System.EventHandler(this.programCB_Click);
            this.programCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.programCB_KeyPress);
            // 
            // sectionCB
            // 
            this.sectionCB.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionCB.FormattingEnabled = true;
            this.sectionCB.Location = new System.Drawing.Point(627, 48);
            this.sectionCB.Margin = new System.Windows.Forms.Padding(2);
            this.sectionCB.Name = "sectionCB";
            this.sectionCB.Size = new System.Drawing.Size(164, 34);
            this.sectionCB.TabIndex = 59;
            this.sectionCB.Click += new System.EventHandler(this.sectionCB_Click);
            this.sectionCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.programCB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(623, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 58;
            this.label4.Text = "Section:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Program:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject:";
            // 
            // subjectText
            // 
            this.subjectText.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectText.Location = new System.Drawing.Point(39, 50);
            this.subjectText.Multiline = true;
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(563, 32);
            this.subjectText.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // updateBTN
            // 
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBTN.Image = ((System.Drawing.Image)(resources.GetObject("updateBTN.Image")));
            this.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBTN.Location = new System.Drawing.Point(724, 711);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(142, 31);
            this.updateBTN.TabIndex = 53;
            this.updateBTN.Text = "        Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.Image")));
            this.deleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBTN.Location = new System.Drawing.Point(872, 711);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(142, 31);
            this.deleteBTN.TabIndex = 52;
            this.deleteBTN.Text = "    Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // addProgramBTN
            // 
            this.addProgramBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProgramBTN.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProgramBTN.Image = ((System.Drawing.Image)(resources.GetObject("addProgramBTN.Image")));
            this.addProgramBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProgramBTN.Location = new System.Drawing.Point(528, 711);
            this.addProgramBTN.Name = "addProgramBTN";
            this.addProgramBTN.Size = new System.Drawing.Size(178, 31);
            this.addProgramBTN.TabIndex = 51;
            this.addProgramBTN.Text = "     Add Subject";
            this.addProgramBTN.UseVisualStyleBackColor = true;
            this.addProgramBTN.Click += new System.EventHandler(this.addProgramBTN_Click);
            // 
            // ManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.addProgramBTN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageSubject";
            this.Size = new System.Drawing.Size(1188, 758);
            this.Load += new System.EventHandler(this.ManageSubject_Load);
            this.Click += new System.EventHandler(this.ManageSubject_Click);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subjectList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button addProgramBTN;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView subjectList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sectionCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox programCB;
        public System.Windows.Forms.TextBox hoursText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox daysCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjname;
        private System.Windows.Forms.DataGridViewTextBoxColumn prog;
        private System.Windows.Forms.DataGridViewTextBoxColumn sect;
        private System.Windows.Forms.DataGridViewTextBoxColumn days1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours1;
    }
}

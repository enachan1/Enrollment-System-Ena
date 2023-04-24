namespace Enrollment_System
{
    partial class PriceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.subjectsList = new System.Windows.Forms.DataGridView();
            this.subjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.subjtext = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sectionCB = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.addpriceBTN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.programCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.subjectsList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 758);
            this.panel1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(225, 459);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 92;
            this.label11.Text = "Subjects";
            // 
            // subjectsList
            // 
            this.subjectsList.AllowUserToAddRows = false;
            this.subjectsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectName,
            this.subjSection});
            this.subjectsList.Location = new System.Drawing.Point(228, 492);
            this.subjectsList.Name = "subjectsList";
            this.subjectsList.ReadOnly = true;
            this.subjectsList.RowHeadersVisible = false;
            this.subjectsList.Size = new System.Drawing.Size(721, 201);
            this.subjectsList.TabIndex = 5;
            this.subjectsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectsList_CellClick);
            // 
            // subjectName
            // 
            this.subjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjectName.DataPropertyName = "subjectname";
            this.subjectName.HeaderText = "Subject Name";
            this.subjectName.Name = "subjectName";
            this.subjectName.ReadOnly = true;
            // 
            // subjSection
            // 
            this.subjSection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subjSection.DataPropertyName = "section";
            this.subjSection.HeaderText = "Section";
            this.subjSection.Name = "subjSection";
            this.subjSection.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(259, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Financial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 24);
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
            this.panel2.Controls.Add(this.subjtext);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.sectionCB);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.addpriceBTN);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.priceText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.programCB);
            this.panel2.Location = new System.Drawing.Point(229, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 373);
            this.panel2.TabIndex = 1;
            // 
            // subjtext
            // 
            this.subjtext.Enabled = false;
            this.subjtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjtext.Location = new System.Drawing.Point(271, 206);
            this.subjtext.Margin = new System.Windows.Forms.Padding(2);
            this.subjtext.MaxLength = 50;
            this.subjtext.Multiline = true;
            this.subjtext.Name = "subjtext";
            this.subjtext.Size = new System.Drawing.Size(304, 27);
            this.subjtext.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 97;
            this.label7.Text = "Section";
            // 
            // sectionCB
            // 
            this.sectionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionCB.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionCB.FormattingEnabled = true;
            this.sectionCB.Items.AddRange(new object[] {
            "Information & Communications Technology. BS in Information Technology (BSIT)",
            "Business & Management. BS in Business Administration (BSBA)",
            "Hospitality Management. BS in Hospitality Management (BSHM)",
            "Tourism Management. BS in Tourism Management (BSTM)"});
            this.sectionCB.Location = new System.Drawing.Point(297, 106);
            this.sectionCB.Margin = new System.Windows.Forms.Padding(2);
            this.sectionCB.Name = "sectionCB";
            this.sectionCB.Size = new System.Drawing.Size(183, 28);
            this.sectionCB.TabIndex = 96;
            this.sectionCB.SelectedIndexChanged += new System.EventHandler(this.sectionCB_SelectedIndexChanged);
            this.sectionCB.Click += new System.EventHandler(this.sectionCB_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(200, 209);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 93;
            this.label15.Text = "Subject:";
            // 
            // addpriceBTN
            // 
            this.addpriceBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addpriceBTN.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpriceBTN.Image = ((System.Drawing.Image)(resources.GetObject("addpriceBTN.Image")));
            this.addpriceBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addpriceBTN.Location = new System.Drawing.Point(543, 309);
            this.addpriceBTN.Margin = new System.Windows.Forms.Padding(2);
            this.addpriceBTN.Name = "addpriceBTN";
            this.addpriceBTN.Size = new System.Drawing.Size(138, 34);
            this.addpriceBTN.TabIndex = 89;
            this.addpriceBTN.Text = "      Submit";
            this.addpriceBTN.UseVisualStyleBackColor = true;
            this.addpriceBTN.Click += new System.EventHandler(this.addpriceBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 88;
            this.label8.Text = "Program";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(218, 253);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 87;
            this.label14.Text = "Price:";
            // 
            // priceText
            // 
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.Location = new System.Drawing.Point(271, 244);
            this.priceText.Margin = new System.Windows.Forms.Padding(2);
            this.priceText.MaxLength = 5;
            this.priceText.Multiline = true;
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(144, 27);
            this.priceText.TabIndex = 85;
            this.priceText.TextChanged += new System.EventHandler(this.priceText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tuition Fee";
            // 
            // programCB
            // 
            this.programCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programCB.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programCB.FormattingEnabled = true;
            this.programCB.Items.AddRange(new object[] {
            "Information & Communications Technology. BS in Information Technology (BSIT)",
            "Business & Management. BS in Business Administration (BSBA)",
            "Hospitality Management. BS in Hospitality Management (BSHM)",
            "Tourism Management. BS in Tourism Management (BSTM)"});
            this.programCB.Location = new System.Drawing.Point(52, 42);
            this.programCB.Margin = new System.Windows.Forms.Padding(2);
            this.programCB.Name = "programCB";
            this.programCB.Size = new System.Drawing.Size(629, 28);
            this.programCB.TabIndex = 2;
            this.programCB.SelectedIndexChanged += new System.EventHandler(this.programCB_SelectedIndexChanged);
            this.programCB.Click += new System.EventHandler(this.programCB_Click);
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PriceList";
            this.Size = new System.Drawing.Size(1178, 758);
            this.Load += new System.EventHandler(this.PriceList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox programCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addpriceBTN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView subjectsList;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox subjtext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sectionCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjSection;
    }
}

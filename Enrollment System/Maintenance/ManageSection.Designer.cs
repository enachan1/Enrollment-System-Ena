namespace Enrollment_System
{
    partial class ManageSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSection));
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateBTN = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sectionDataList = new System.Windows.Forms.DataGridView();
            this.col0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSectionText = new System.Windows.Forms.TextBox();
            this.addDataBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.updateBTN);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.deleteBTN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.addSectionText);
            this.panel1.Controls.Add(this.addDataBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 758);
            this.panel1.TabIndex = 2;
            // 
            // updateBTN
            // 
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBTN.Image = ((System.Drawing.Image)(resources.GetObject("updateBTN.Image")));
            this.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBTN.Location = new System.Drawing.Point(725, 507);
            this.updateBTN.Margin = new System.Windows.Forms.Padding(2);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(138, 32);
            this.updateBTN.TabIndex = 48;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label22.Location = new System.Drawing.Point(167, 507);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 22);
            this.label22.TabIndex = 36;
            this.label22.Text = "Add Section";
            // 
            // deleteBTN
            // 
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.Image")));
            this.deleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBTN.Location = new System.Drawing.Point(867, 507);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(138, 32);
            this.deleteBTN.TabIndex = 40;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(199, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Sections";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 72);
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
            this.panel2.Controls.Add(this.sectionDataList);
            this.panel2.Location = new System.Drawing.Point(171, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 396);
            this.panel2.TabIndex = 1;
            // 
            // sectionDataList
            // 
            this.sectionDataList.AllowUserToAddRows = false;
            this.sectionDataList.AllowUserToDeleteRows = false;
            this.sectionDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectionDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col0,
            this.col1});
            this.sectionDataList.Location = new System.Drawing.Point(224, 35);
            this.sectionDataList.Name = "sectionDataList";
            this.sectionDataList.ReadOnly = true;
            this.sectionDataList.RowHeadersVisible = false;
            this.sectionDataList.Size = new System.Drawing.Size(407, 326);
            this.sectionDataList.TabIndex = 0;
            this.sectionDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sectionDataList_CellClick);
            // 
            // col0
            // 
            this.col0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col0.DataPropertyName = "id";
            this.col0.HeaderText = "id";
            this.col0.Name = "col0";
            this.col0.ReadOnly = true;
            this.col0.Visible = false;
            // 
            // col1
            // 
            this.col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1.DataPropertyName = "section";
            this.col1.HeaderText = "Section Name";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // addSectionText
            // 
            this.addSectionText.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSectionText.Location = new System.Drawing.Point(281, 506);
            this.addSectionText.Margin = new System.Windows.Forms.Padding(2);
            this.addSectionText.MaxLength = 10;
            this.addSectionText.Multiline = true;
            this.addSectionText.Name = "addSectionText";
            this.addSectionText.Size = new System.Drawing.Size(270, 32);
            this.addSectionText.TabIndex = 37;
            this.addSectionText.Text = "Add Section";
            this.addSectionText.Click += new System.EventHandler(this.addSectionText_Click);
            // 
            // addDataBTN
            // 
            this.addDataBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDataBTN.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataBTN.Image = ((System.Drawing.Image)(resources.GetObject("addDataBTN.Image")));
            this.addDataBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDataBTN.Location = new System.Drawing.Point(555, 507);
            this.addDataBTN.Margin = new System.Windows.Forms.Padding(2);
            this.addDataBTN.Name = "addDataBTN";
            this.addDataBTN.Size = new System.Drawing.Size(142, 32);
            this.addDataBTN.TabIndex = 44;
            this.addDataBTN.Text = "Add Data";
            this.addDataBTN.UseVisualStyleBackColor = true;
            this.addDataBTN.Click += new System.EventHandler(this.addDataBTN_Click);
            // 
            // ManageSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageSection";
            this.Size = new System.Drawing.Size(1178, 758);
            this.Load += new System.EventHandler(this.ManageSection_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sectionDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addDataBTN;
        private System.Windows.Forms.Button updateBTN;
        public System.Windows.Forms.TextBox addSectionText;
        public System.Windows.Forms.DataGridView sectionDataList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col0;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
    }
}

namespace Enrollment_System
{
    partial class UCManageProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCManageProgram));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.programText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.programdatalist = new System.Windows.Forms.DataGridView();
            this.idf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProgramBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programdatalist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.programText);
            this.panel1.Location = new System.Drawing.Point(161, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 109);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Program:";
            // 
            // programText
            // 
            this.programText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programText.Location = new System.Drawing.Point(39, 56);
            this.programText.Multiline = true;
            this.programText.Name = "programText";
            this.programText.Size = new System.Drawing.Size(758, 32);
            this.programText.TabIndex = 2;
            this.programText.Click += new System.EventHandler(this.programText_Click);
            this.programText.TextChanged += new System.EventHandler(this.programText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(190, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Program";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.programdatalist);
            this.panel2.Location = new System.Drawing.Point(161, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 335);
            this.panel2.TabIndex = 6;
            // 
            // programdatalist
            // 
            this.programdatalist.AllowUserToAddRows = false;
            this.programdatalist.AllowUserToDeleteRows = false;
            this.programdatalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programdatalist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idf,
            this.col1});
            this.programdatalist.Location = new System.Drawing.Point(39, 27);
            this.programdatalist.Name = "programdatalist";
            this.programdatalist.ReadOnly = true;
            this.programdatalist.RowHeadersVisible = false;
            this.programdatalist.Size = new System.Drawing.Size(758, 278);
            this.programdatalist.TabIndex = 0;
            this.programdatalist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.programdatalist_CellClick);
            // 
            // idf
            // 
            this.idf.DataPropertyName = "id";
            this.idf.HeaderText = "id";
            this.idf.Name = "idf";
            this.idf.ReadOnly = true;
            this.idf.Visible = false;
            // 
            // col1
            // 
            this.col1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col1.DataPropertyName = "ProgramName";
            this.col1.HeaderText = "Program Name";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // addProgramBTN
            // 
            this.addProgramBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProgramBTN.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProgramBTN.Image = ((System.Drawing.Image)(resources.GetObject("addProgramBTN.Image")));
            this.addProgramBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProgramBTN.Location = new System.Drawing.Point(515, 665);
            this.addProgramBTN.Name = "addProgramBTN";
            this.addProgramBTN.Size = new System.Drawing.Size(178, 31);
            this.addProgramBTN.TabIndex = 7;
            this.addProgramBTN.Text = "     Add Program";
            this.addProgramBTN.UseVisualStyleBackColor = true;
            this.addProgramBTN.Click += new System.EventHandler(this.addProgramBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.Image")));
            this.deleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBTN.Location = new System.Drawing.Point(859, 665);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(142, 31);
            this.deleteBTN.TabIndex = 8;
            this.deleteBTN.Text = "    Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBTN.Image = ((System.Drawing.Image)(resources.GetObject("updateBTN.Image")));
            this.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBTN.Location = new System.Drawing.Point(711, 665);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(142, 31);
            this.updateBTN.TabIndex = 9;
            this.updateBTN.Text = "        Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 116);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // UCManageProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.addProgramBTN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UCManageProgram";
            this.Size = new System.Drawing.Size(1188, 758);
            this.Load += new System.EventHandler(this.UCManageProgram_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.programdatalist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addProgramBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView programdatalist;
        private System.Windows.Forms.DataGridViewTextBoxColumn idf;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        public System.Windows.Forms.TextBox programText;
    }
}

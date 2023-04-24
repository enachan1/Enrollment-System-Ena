using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Enrollment_System
{
    public partial class ManageSection : UserControl
    {
        public ManageSection()
        {
            InitializeComponent();
        }
        int identity;
        int index = -1;

        private void ManageSection_Load(object sender, EventArgs e)
        {
            sectionDataList.AutoGenerateColumns = false;
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showSectionInfo, sc))
                {
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    sectionDataList.DataSource = tb;
                }
            }
        }

        private void addDataBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addSectionText.Text))
            {
                MessageBox.Show("Please Add Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string section = addSectionText.Text;
                manageSectionEncaps add = new manageSectionEncaps();
                add.addData(section);
                addSectionText.Text = "";
                BindGrid();
                index = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(addSectionText.Text))
            {
                MessageBox.Show("There is nothing to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (index < 0)
            {
                MessageBox.Show("There is nothing to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string section = addSectionText.Text;
                manageSectionEncaps update = new manageSectionEncaps();
                update.updateData(identity, section);
                BindGrid();
                addSectionText.Text = "";
                index = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addSectionText.Text))
            {
                MessageBox.Show("There is nothing to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (index < 0)
            {
                MessageBox.Show("There is nothing to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                manageSectionEncaps delete = new manageSectionEncaps();
                delete.deleteData(identity);
                addDataBTN.Enabled = true;
                BindGrid();
                addSectionText.Text = "";
                index = -1;
                
            }
        }

        private void sectionDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addDataBTN.Enabled = false;
            index = sectionDataList.CurrentCell.RowIndex;
            if (index > -1)
            {
                identity = Convert.ToInt32(sectionDataList.Rows[index].Cells["col0"].Value.ToString());
                addSectionText.Text = sectionDataList.Rows[index].Cells["col1"].Value.ToString();
            }
        }

        private void addSectionText_Click(object sender, EventArgs e)
        {
            addDataBTN.Enabled = true;
            addSectionText.Text = "";
        }

        void BindGrid()
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showSectionInfo, sc))
                {
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    sectionDataList.DataSource = tb;
                }
            }
        }
    }
}

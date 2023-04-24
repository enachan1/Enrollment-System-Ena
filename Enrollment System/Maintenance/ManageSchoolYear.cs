using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class ManageSchoolYear : UserControl
    {
        public ManageSchoolYear()
        {
            InitializeComponent();
        }
        int identity;
        int index = -1;
        private void ManageSchoolYear_Load(object sender, EventArgs e)
        {
            addSY.MaxLength = 9;
            dataschoolYear.AutoGenerateColumns = false;
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showSy, sc))
                {
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    dataschoolYear.DataSource = tb;
                }
            }
        }

        private void addDataBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addSY.Text))
            {
                MessageBox.Show("Please Add Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sy = addSY.Text;
                manageSYEncaps add = new manageSYEncaps();
                add.addData(sy);
                addSY.Text = "ex. 2022-2023";
                BindGrid();
                index = -1;
            }
    }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addSY.Text))
            {
                MessageBox.Show("There is nothing to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (index < 0)
            {
                MessageBox.Show("There is nothing to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sy = addSY.Text;
                manageSYEncaps update = new manageSYEncaps();
                update.updateData(identity, sy);
                addDataBTN.Enabled = true;
                BindGrid();
                addSY.Text = "ex. 2022-2023";
                index = -1;
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addSY.Text))
            {
                MessageBox.Show("There is nothing to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (index < 0)
            {
                MessageBox.Show("There is nothing to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                manageSYEncaps delete = new manageSYEncaps();
                delete.deleteData(identity);
                addDataBTN.Enabled = true;
                BindGrid();
                addSY.Text = "ex. 2022-2023";
                index = -1;

            }
        }

        private void dataschoolYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addDataBTN.Enabled = false;
            index = dataschoolYear.CurrentCell.RowIndex;
            if (index > -1)
            {
                identity = Convert.ToInt32(dataschoolYear.Rows[index].Cells["col0"].Value.ToString());
                addSY.Text = dataschoolYear.Rows[index].Cells["col1"].Value.ToString();
            }
        }
        void BindGrid()
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showSy, sc))
                {
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    dataschoolYear.DataSource = tb;
                }
            }
        }

        private void addSY_Click(object sender, EventArgs e)
        {
            addSY.Text = "";
            
        }
    }
}

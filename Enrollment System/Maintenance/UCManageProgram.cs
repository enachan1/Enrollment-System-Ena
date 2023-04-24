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
    public partial class UCManageProgram : UserControl
    {
        public UCManageProgram()
        {
            InitializeComponent();
        }
        //gets the identifier in the table
        int identify;
        int index = -1;
        private void UCManageProgram_Load(object sender, EventArgs e)
        {
            programdatalist.AutoGenerateColumns = false;
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showPrgInfo, sc))
                {
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    programdatalist.DataSource = tb;
                }
            }
        }

        private void addProgramBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(programText.Text))
            {
                MessageBox.Show("Please Add Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string program = programText.Text;
                manageProgramEncaps mge = new manageProgramEncaps();
                mge.addData(program);
                bindSource();
                programText.Text = "";
                index = -1;
            }

        }
        public void bindSource()
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showPrgInfo, sc))
                {
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    programdatalist.DataSource = tb;
                }
            }
        }

        private void programdatalist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addProgramBTN.Enabled = false;
            index = programdatalist.CurrentCell.RowIndex;

            if(index > -1)
            {
                identify = Convert.ToInt32(programdatalist.Rows[index].Cells["idf"].Value.ToString());
                programText.Text = programdatalist.Rows[index].Cells["col1"].Value.ToString();
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(programText.Text))
            {
                MessageBox.Show("There is nothing to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (index < 0)
            {
                MessageBox.Show("There is nothing to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                manageProgramEncaps delete = new manageProgramEncaps();
                delete.deleteData(identify);
                addProgramBTN.Enabled = true;
                programText.Text = "";
                bindSource();
                index = -1;
            }
        }

        private void programText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void programText_Click(object sender, EventArgs e)
        {
            addProgramBTN.Enabled = true;
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(programText.Text))
            {
                MessageBox.Show("There is nothing to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (index < 0)
            {
                MessageBox.Show("There is nothing to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string updateText = programText.Text;
                manageProgramEncaps update = new manageProgramEncaps();
                update.updateData(identify, updateText);
                programText.Text = "";
                bindSource();
                MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                index = -1;
            }
        }
    }
}

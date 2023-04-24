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
    public partial class ManageSubject : UserControl
    {
        int index = -1;
        int identity = 0;
        string subjjname;
        string program;
        string section;
        string days;
        string hours;
        public ManageSubject()
        {
            InitializeComponent();
        }
        private void ManageSubject_Load(object sender, EventArgs e)
        {
            BindSource();
        }
        private void programCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void addProgramBTN_Click(object sender, EventArgs e)
        {
            subjjname = subjectText.Text;
            program = programCB.Text;
            section = sectionCB.Text;
            days = daysCB.Text;
            hours = hoursText.Text;
            if (string.IsNullOrEmpty(subjjname)|| string.IsNullOrEmpty(program) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("Please Add Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                manageSubjectClass add = new manageSubjectClass();
                add.addData(subjjname, program, section, days, hours);
                Clear();
                BindSource();
                identity = 0;
            }
        }
        private void updateBTN_Click(object sender, EventArgs e)
        {
            subjjname = subjectText.Text;
            program = programCB.Text;
            section = sectionCB.Text;
            days = daysCB.Text;
            hours = hoursText.Text;

            if (string.IsNullOrEmpty(subjjname) || string.IsNullOrEmpty(program) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("There is nothing to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (index < 0)
            {
                MessageBox.Show("There is nothing to Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                manageSubjectClass update = new manageSubjectClass();
                update.updateData(identity, subjjname, program, section, days, hours);
                BindSource();
                Clear();
                addProgramBTN.Enabled = true;
                index = -1;
                identity = 0;
            }
        }
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            subjjname = subjectText.Text;
            program = programCB.Text;
            section = sectionCB.Text;

            if (string.IsNullOrEmpty(subjjname) || string.IsNullOrEmpty(program) || string.IsNullOrEmpty(section))
            {
                MessageBox.Show("There is nothing to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (index < 0)
            {
                MessageBox.Show("There is nothing to Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                manageSubjectClass delete = new manageSubjectClass();
                delete.deleteData(identity);
                index = -1;
                identity = 0;
                addProgramBTN.Enabled = true;
                Clear();
                BindSource();

            }
        }
        private void programCB_Click(object sender, EventArgs e)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda1 = new SqlDataAdapter(dbmscon.showPrgInfo, sc))
                {
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    programCB.DataSource = dt1;
                    programCB.DisplayMember = "ProgramName";
                    sc.Close();
                }
            }
        }
        private void sectionCB_Click(object sender, EventArgs e)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda2 = new SqlDataAdapter(dbmscon.showSectionInfo, sc))
                {
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    sectionCB.DataSource = dt2;
                    sectionCB.DisplayMember = "section";
                    sc.Close();
                }
            }
        }
        private void subjectList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = subjectList.CurrentCell.RowIndex;
            addProgramBTN.Enabled = false;
            if(index > -1)
            {
                subjectText.Text = subjectList.Rows[index].Cells["subjname"].Value.ToString();
                programCB.Text = subjectList.Rows[index].Cells["prog"].Value.ToString();
                sectionCB.Text = subjectList.Rows[index].Cells["sect"].Value.ToString();
                identity = Convert.ToInt32(subjectList.Rows[index].Cells["id"].Value.ToString());
                daysCB.Text = subjectList.Rows[index].Cells["days1"].Value.ToString();
                hoursText.Text = subjectList.Rows[index].Cells["hours1"].Value.ToString();
            }
        }
        private void ManageSubject_Click(object sender, EventArgs e)
        {
            addProgramBTN.Enabled = true;
            Clear();
        }
        void BindSource()
        {
            subjectList.AutoGenerateColumns = false;
            using (SqlConnection sconn = new SqlConnection(dbmscon.conString))
            {
                sconn.Open();
                if(sconn.State == System.Data.ConnectionState.Open)
                {
                    using (SqlDataAdapter sqladapt = new SqlDataAdapter(dbmscon.showsubject, sconn))
                    {
                        DataTable dt = new DataTable();
                        sqladapt.Fill(dt);
                        subjectList.DataSource = dt;
                    }
                }
            }
        }
        void Clear()
        {
            subjectText.Text = "";
            programCB.Text = "";
            sectionCB.Text = "";
        }
    }
}

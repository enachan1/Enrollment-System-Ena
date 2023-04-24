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
    public partial class EnrollStudent : UserControl
    {
        public EnrollStudent()
        {
            InitializeComponent();
        }
        int countenrolled = -1;
        int identity = 0;
        private void EnrollStudent_Load(object sender, EventArgs e)
        {
            
            StudentListBind();
            ExistingEnrolledBind();
            updateBTN.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(stdNumText.Text))
                {
                    string studentnum = stdNumText.Text;
                    string name = enrollNameText.Text;
                    int age = Convert.ToInt32(enrollAgeText.Text);
                    string sex = enrollSexText.Text;
                    string section = sectionCB.Text;
                    string schoolyear = schoolYear.Text;
                    string program = programCB.Text;
                    enrollStudentClass esc = new enrollStudentClass();
                    esc.enrolled(studentnum, name, age, sex, section, schoolyear, program, "Regular");
                    StudentListBind();
                    ExistingEnrolledBind();
                }
                else
                {
                    MessageBox.Show("Generate Student Number First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There is a missing field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(stdNumText.Text))
                {
                    Enable();
                    string schoolyear = schoolYear.Text;
                    string section = sectionCB.Text;
                    enrollStudentClass esc = new enrollStudentClass();
                    esc.updateEnrolled(identity, schoolyear, section);

                    Clear();
                    countenrolled = -1;
                    StudentListBind();
                    ExistingEnrolledBind();
                }
                else
                {
                    MessageBox.Show("There are missing fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private void generateBTN_Click(object sender, EventArgs e)
        {
            // getting date today
            DateTime dt = DateTime.Now;
            string datenow = dt.ToString("yyyyMMdd");

            // generating number 1000 to 5000
            Random rnd = new Random();
            int round = rnd.Next(1000, 9999);

            //set the combined date today and random number to the textbox
            stdNumText.Text = datenow + round.ToString();
           
        }

        private void stdListClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = enrolllistofStd.CurrentCell.RowIndex;

            if (count > -1)
            {
                enrollNameText.Text = enrolllistofStd.Rows[count].Cells["col0"].Value.ToString();
                enrollSexText.Text = enrolllistofStd.Rows[count].Cells["col2"].Value.ToString();
                enrollAgeText.Text = enrolllistofStd.Rows[count].Cells["col1"].Value.ToString();
            }
        }

        private void programCB_Click(object sender, EventArgs e)
        {
            using(SqlConnection sc = new SqlConnection(dbmscon.conString)) 
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

        private void schoolYear_Click(object sender, EventArgs e)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda2 = new SqlDataAdapter(dbmscon.showSy, sc))
                {
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    schoolYear.DataSource = dt2;
                    schoolYear.DisplayMember = "SchoolYear";
                    sc.Close();
                }
            }
        }
        private void enrolledStdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Disable();
            countenrolled = enrolledStdList.CurrentCell.RowIndex;
            if (countenrolled > -1)
            {
                
                stdNumText.Text = enrolledStdList.Rows[countenrolled].Cells["studentnum"].Value.ToString();
                enrollNameText.Text = enrolledStdList.Rows[countenrolled].Cells["name"].Value.ToString();
                enrollSexText.Text = enrolledStdList.Rows[countenrolled].Cells["sex"].Value.ToString();
                enrollAgeText.Text = enrolledStdList.Rows[countenrolled].Cells["age"].Value.ToString();
                sectionCB.Text = enrolledStdList.Rows[countenrolled].Cells["section"].Value.ToString();
                schoolYear.Text = enrolledStdList.Rows[countenrolled].Cells["sy"].Value.ToString();
                programCB.Text = enrolledStdList.Rows[countenrolled].Cells["program"].Value.ToString();
                identity = Convert.ToInt32(enrolledStdList.Rows[countenrolled].Cells["id1"].Value.ToString());
                showsubject();
            }
        }
        private void searchEnroll_TextChanged(object sender, EventArgs e)
        {
            EnrollSearh(searchEnroll.Text);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            Search(search.Text);
        }
        void StudentListBind()
        {
            enrolllistofStd.AutoGenerateColumns = false;
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                        using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showStdInfo, sc))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        enrolllistofStd.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        void ExistingEnrolledBind()
        {
            enrolledStdList.AutoGenerateColumns = false;
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM enrolledStudentsList WHERE studenttype = 'Regular'", sc))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        enrolledStdList.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        void Search(string search)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM StudentListTbl WHERE Full_Name = @stdName OR Full_Name LIKE @stdNm", sc))
                    {
                        command.Parameters.AddWithValue("stdName", search);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", search));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        enrolllistofStd.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        void Clear() 
        {
            stdNumText.Text = "";
            enrollNameText.Text = "";
            enrollSexText.Text = "";
            enrollAgeText.Text = "";
            sectionCB.Text = "";
            schoolYear.Text = "";
            programCB.Text = "";
        }
        void EnrollSearh(string search)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    string command1 = "SELECT * FROM enrolledStudentsList WHERE Name = @stdName OR Name LIKE @stdNm AND studenttype LIKE 'Regular'";
                    using (SqlCommand command = new SqlCommand(command1, sc))
                    {
                        command.Parameters.AddWithValue("stdName", search);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", search));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        enrolledStdList.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        void Disable() 
        {
            enrollNameText.Enabled = false;
            enrollSexText.Enabled = false;
            enrollAgeText.Enabled = false;
            generateBTN.Enabled = false;
            enrollBTN.Enabled = false;
            programCB.Enabled = false;
            enrolllistofStd.Enabled = false;
            updateBTN.Enabled = true;
        }
        void Enable() 
        {
            enrollNameText.Enabled = true;
            enrollSexText.Enabled = true;
            enrollAgeText.Enabled = true;
            generateBTN.Enabled = true;
            enrollBTN.Enabled = true;
            programCB.Enabled = true;
            enrolllistofStd.Enabled = true;
            updateBTN.Enabled = false;
        }

        private void sectionCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void schoolYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void programCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void sectionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            showsubject();
        }
        private void programCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            showsubject();
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            subjectList.DataSource = null;
            subjectList.Rows.Clear();
            Enable();
            Clear();
        }
        void showsubject()
        {
            subjectList.AutoGenerateColumns = false;
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlCommand sqlcom = new SqlCommand("SELECT * FROM subjectList WHERE program = '" + programCB.Text + "' AND section = '" + sectionCB.Text + "'", sc))
                {
                    using (SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom))
                    {
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        subjectList.DataSource = dt1;
                        sc.Close();
                    }
                }
            }
        }


    }
}

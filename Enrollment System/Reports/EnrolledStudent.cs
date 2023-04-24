using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Enrollment_System
{
    public partial class EnrolledStudent : UserControl
    {
        public EnrolledStudent()
        {
            InitializeComponent();
        }
        string searchme;
        string cb;
        private void EnrolledStudent_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedText = "Student Number";
            enrolledStdList.AutoGenerateColumns = false;
            bindSource();
        }

        private void searchTxt_Enter(object sender, EventArgs e)
        {
            searchTxt.Text = "";
            bindSource();
        }

        private void searchTxt_Leave(object sender, EventArgs e)
        {
            searchTxt.Text = "Search Student...";
            bindSource();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            searchme = searchTxt.Text;
            if (searchme == "")
            {
                bindSource();
            }
            else
            {
                cb = comboBox1.Text;
                searchValidity();
            }
            
        }
        void searchValidity()
        {
            switch(cb)
            {
                case "Student Number":
                    SearchStdNum(searchme);
                    break;

                case "Name":
                    SearchName(searchme);
                    break;

                case "Program":
                    SearchProgram(searchme);
                    break;

                case "School Year":
                    SearchYear(searchme);
                    break;
            }
        }
         void SearchStdNum(string stdnum)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    string command1 = "SELECT * FROM enrolledStudentsList WHERE studentNum = @stdNme OR studentNum LIKE @stdNm";
                    using (SqlCommand command = new SqlCommand(command1, sc))
                    {
                        command.Parameters.AddWithValue("stdNme", stdnum);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", stdnum));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        enrolledStdList.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        void SearchName(string search)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    string command1 = "SELECT * FROM enrolledStudentsList WHERE Name = @stdName OR Name LIKE @stdNm";
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
        void SearchProgram(string prog)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    string command1 = "SELECT * FROM enrolledStudentsList WHERE program = @stdNme OR program LIKE @stdNm";
                    using (SqlCommand command = new SqlCommand(command1, sc))
                    {
                        command.Parameters.AddWithValue("stdNme", prog);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", prog));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        enrolledStdList.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        public void SearchYear(string sy)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    string command1 = "SELECT * FROM enrolledStudentsList WHERE schoolyear = @stdNme OR schoolyear LIKE @stdNm";
                    using (SqlCommand command = new SqlCommand(command1, sc))
                    {
                        command.Parameters.AddWithValue("stdNme", sy);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", sy));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        enrolledStdList.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        void bindSource()
        {
            using (SqlConnection sqlconn = new SqlConnection(dbmscon.conString))
            {
                sqlconn.Open();
                if (sqlconn.State == System.Data.ConnectionState.Open)
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showEnrolledStd, sqlconn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        enrolledStdList.DataSource = dt;
                        sqlconn.Close();
                    }
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Enrolled Student";
            printer.TitleSpacing = 30;
            printer.SubTitle = string.Format("Date {0}", DateTime.Now.Date.ToString("yyyy-MM-dd"));
            printer.SubTitleSpacing = 20;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Enrollment System";
            printer.PrintDataGridView(enrolledStdList);
        }
    }
}

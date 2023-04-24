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
    public partial class BalanceReport : UserControl
    {
        public BalanceReport()
        {
            InitializeComponent();
        }
        string searchme;
        string cb;
        void BalanceReports()
        {
            balanceLst.AutoGenerateColumns = false;
            bindSource();
        }

        private void BalanceReport_Load(object sender, EventArgs e)
        {
            BalanceReports();
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
            switch (cb)
            {
                case "Student Number":
                    SearchStdNum(searchme);
                    break;

                case "Name":
                    SearchName(searchme);
                    break;

                case "Address":
                    SearchProgram(searchme);
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
                    string command1 = "SELECT * FROM balances WHERE stunum = @stdNme OR stunum LIKE @stdNm";
                    using (SqlCommand command = new SqlCommand(command1, sc))
                    {
                        command.Parameters.AddWithValue("stdNme", stdnum);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", stdnum));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        balanceLst.DataSource = dt;
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
                    string command1 = "SELECT * FROM balances WHERE name = @stdName OR name LIKE @stdNm";
                    using (SqlCommand command = new SqlCommand(command1, sc))
                    {
                        command.Parameters.AddWithValue("stdName", search);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", search));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        balanceLst.DataSource = dt;
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
                    string command1 = "SELECT * FROM balances WHERE program = @stdNme OR program LIKE @stdNm";
                    using (SqlCommand command = new SqlCommand(command1, sc))
                    {
                        command.Parameters.AddWithValue("stdNme", prog);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", prog));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        balanceLst.DataSource = dt;
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
                    using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showBalance, sqlconn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        balanceLst.DataSource = dt;
                        sqlconn.Close();
                    }
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
    }
}

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
using System.Diagnostics;

namespace Enrollment_System
{
    public partial class sampleUser : UserControl
    {
        
        public sampleUser()
        {
            InitializeComponent();
        }
        int maxDecimalPoints = 0;
        string cb;
        string searchme;
        private void sample_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Student Number";
            payText.Enabled = false;
            priceList1.Hide();
            balances1.Hide();
            bindSource();
            payText.MaxLength = 10;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priceList1.Hide();
            balances1.Hide();
        }

        private void priceListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            priceList1.Show();
            balances1.Hide();
        }
        private void balancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            priceList1.Hide();
            balances1.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchme = textBox1.Text;
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
                        enrolledLst.DataSource = dt;
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
                        enrolledLst.DataSource = dt;
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
                        enrolledLst.DataSource = dt;
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
                        enrolledLst.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        private void printBtn_Click(object sender, EventArgs e)
        {
            transactLogClass tlc = new transactLogClass();
            try
            {
                if (pstuNum.Text == "" || payText.Text == "")
                {
                    MessageBox.Show("There are missing fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string studentnum = pstuNum.Text;
                    string name = pName.Text;
                    string prog = pProg.Text;
                    string pay = payText.Text;
                    float bal = float.Parse(balanceText.Text);
                    balancesClass bc = new balancesClass();
                    bc.getBalances(studentnum, name, prog, bal, pay);
                    payText.Enabled = false;
                    
                    if(bal <= 0)
                    {
                        tlc.insertTransact("Full Payment");
                    }
                    else if (bal > 0)
                    {
                        tlc.insertTransact("Partially");
                    }
                    clear();
                }
            }
            catch (Exception)
            {

            }
        }
        private void pProg_TextChanged(object sender, EventArgs e)
        {
            tuitionText.Text = "";
            totalText.Text = "";
            getSubjectOverallPrice();
        }
        private void enrolledLst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            payText.Enabled = true;
            int index = enrolledLst.CurrentCell.RowIndex;
            if (index > -1)
            {
                pstuNum.Text = enrolledLst.Rows[index].Cells["col0"].Value.ToString();
                pName.Text = enrolledLst.Rows[index].Cells["col1"].Value.ToString();
                pSect.Text = enrolledLst.Rows[index].Cells["col3"].Value.ToString();
                pSy.Text = enrolledLst.Rows[index].Cells["col4"].Value.ToString();
                pProg.Text = enrolledLst.Rows[index].Cells["col2"].Value.ToString();
                getSubjectOverallPrice();
            }
        }
        private void payText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(payText.Text))
                {
                    balanceText.Text = "";
                }
                else if (float.Parse(payText.Text) > float.Parse(totalText.Text))
                {
                    balanceText.Text = "0";
                }
                else
                {
                    float subtract = float.Parse(totalText.Text) - float.Parse(payText.Text);
                    float.Parse(balanceText.Text = subtract.ToString());
                }
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            bindSource();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Search Student Number...";
            bindSource();
        }
        void bindSource()
        {
            enrolledLst.AutoGenerateColumns = false;
            using(SqlConnection sqlc = new SqlConnection(dbmscon.conString))
            {
                sqlc.Open();
                if(sqlc.State == System.Data.ConnectionState.Open)
                {
                    using(SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM enrolledStudentsList", sqlc))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        enrolledLst.DataSource = dt;
                        sqlc.Close();
                    }
                }
            }
        }

        void getSubjectOverallPrice()
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(dbmscon.conString))
                {
                    sc.Open();
                    if (sc.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand command = new SqlCommand("SELECT SUM(price) FROM subjectList WHERE Program = @program AND section = @sect", sc))
                        {
                            command.Parameters.AddWithValue("@program", pProg.Text);
                            command.Parameters.AddWithValue("@sect", pSect.Text);
                            object result = command.ExecuteScalar();
                            tuitionText.Text = Convert.ToString(result);
                            float amount = float.Parse(tuitionText.Text) + float.Parse(totalassesText.Text);
                            totalText.Text = Convert.ToString(amount);
                            sc.Close();
                        }
                    }
                }
            }
            catch
            {

            }
        }
        void clear()
        {
            pstuNum.Text = "";
            pName.Text = "";
            pProg.Text = "";
            pSect.Text = "";
            pSy.Text = "";
            tuitionText.Text = "";
            totalText.Text = "";
            payText.Text = "";
            balanceText.Text = "";
        }

        private void payText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Length == 0))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Split('.').Length - 1 > maxDecimalPoints))
            {
                e.Handled = true;
            }

        }

        private void refreshdata_Click(object sender, EventArgs e)
        {
            payText.Enabled = false;
            bindSource();
            clear();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

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
    public partial class Balances : UserControl
    {
        int identity = 0;
        int index = -1;
        string searchme;
        string cb;
        int maxDecimalPoints = 0;
        
        public Balances()
        {
            InitializeComponent();
        }
        
        private void Balances_Load(object sender, EventArgs e)
        {
            paymentText.Enabled = false;
            comboBox1.SelectedText = "Student Number";
            refreshData();
        }
        private void balanceLst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            paymentText.Enabled = true;
            index = balanceLst.CurrentCell.RowIndex;
            refreshData();
            if(index > -1)
            {
                pstuNum.Text = balanceLst.Rows[index].Cells["col0"].Value.ToString();
                pName.Text = balanceLst.Rows[index].Cells["col1"].Value.ToString();
                pProg.Text = balanceLst.Rows[index].Cells["col2"].Value.ToString();
                balanceText.Text = balanceLst.Rows[index].Cells["col3"].Value.ToString();
                identity = Convert.ToInt32(balanceLst.Rows[index].Cells["col4"].Value.ToString());
                
            }
        }
        private void printBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pstuNum.Text) || !string.IsNullOrEmpty(paymentText.Text))
            {
                transactLogClass tlc = new transactLogClass();
                float bal1 = float.Parse(bal.Text);
                float balance = float.Parse(balanceText.Text);
                if (balance <= 0.00)
                {

                    MessageBox.Show("You are fully paid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();
                }
                else
                {
                    string pay = paymentText.Text;
                    string stunum = pstuNum.Text;
                    string name = pName.Text;
                    string prog = pProg.Text;

                    float deductedBalance = balance - float.Parse(paymentText.Text);

                    balancesClass bc = new balancesClass();

                    bc.updateBalance(identity, stunum, name, prog, pay, deductedBalance);

                    index = -1;
                    if (bal1 <= 0.00)
                    {
                        tlc.insertTransact("Exisiting Balance Fully Paid");
                    }
                    else if (bal1 > 0.00)
                    {
                        tlc.insertTransact("Exisiting Balance Partially Paid");
                    }
                    clear();
                    refreshData();

                }
            }
            else
            {
                MessageBox.Show("There are missing fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            searchme = searchBar.Text;
            if (searchme == "")
            {
                refreshData();
            }
            else
            {
                cb = comboBox1.Text;
                searchValidity();
            }
        }
        private void searchBar_Enter(object sender, EventArgs e)
        {
            searchBar.Text = "";
            refreshData();
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            searchBar.Text = "Search...";
            refreshData();
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
        void refreshData()
        {
            balanceLst.AutoGenerateColumns = false;
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

        void clear()
        {
            pstuNum.Text = "";
            paymentText.Text = "";
            pName.Text = "";
            pProg.Text = "";
            balanceText.Text = "";
        }

        private void balanceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void paymentText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paymentText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(paymentText.Text))
                {
                    bal.Text = "";
                }
                else if (float.Parse(paymentText.Text) > float.Parse(balanceText.Text))
                {
                    bal.Text = "0";
                }
                else
                {
                    float subtract = float.Parse(balanceText.Text) - float.Parse(paymentText.Text);
                    float.Parse(bal.Text = subtract.ToString());
                }
            }
            catch (Exception)
            {

            }
        }
    }
}

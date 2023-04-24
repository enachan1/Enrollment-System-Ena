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
using DGVPrinterHelper;

namespace Enrollment_System
{
    public partial class ListofStudent : UserControl
    {
        public ListofStudent()
        {
            InitializeComponent();
        }
        string searchme;
        string cb;
        private void ListofStudent_Load(object sender, EventArgs e)
        {
            searchBy.SelectedText = "Name";
            listofStd.AutoGenerateColumns = false;
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showStdInfo, sc);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    listofStd.DataSource = dt;
                    sc.Close();
                }
            }
        }
        private void txtChange(object sender, EventArgs e)
        {
            searchme = txtSearch.Text;
            if (searchme == "")
            {
                bindGrid();
            }
            else
            {
                cb = searchBy.Text;
                searchValidity();
            }
        } 
        void searchValidity()
        {
            switch (cb)
            {
                case "Name":
                    searchname(searchme);
                    break;

                case "Birthday":
                    searchbday(searchme);
                    break;

                case "Address":
                    searchaddress(searchme);
                    break;
            }
        }
        void searchname(string search)
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
                        listofStd.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        void searchbday(string search)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM StudentListTbl WHERE Birthday = @stdName OR Birthday LIKE @stdNm", sc))
                    {
                        command.Parameters.AddWithValue("stdName", search);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", search));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        listofStd.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }
        void searchaddress(string search)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM StudentListTbl WHERE Address = @stdName OR Address LIKE @stdNm", sc))
                    {
                        command.Parameters.AddWithValue("stdName", search);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", search));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        listofStd.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand command = new SqlCommand("DELETE FROM StudentListTbl WHERE Full_Name = @stdName", sc))
                    {
                        command.Parameters.AddWithValue("stdName", nameDelete.Text);
                        
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        listofStd.DataSource = dt;
                        nameDelete.Text = "";
                        sc.Close();
                        bindGrid();
                    }
                }
            }
        }
        private void bindGrid()
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showStdInfo, sc))
                {
                    DataTable tb = new DataTable();
                    sda.Fill(tb);
                    listofStd.DataSource = tb;
                }
            }
        }

        private void dgvClick(object sender, DataGridViewCellEventArgs e)
        {
            int count = listofStd.CurrentCell.RowIndex;

            if (count > -1)
            {
                nameDelete.Text = listofStd.Rows[count].Cells[1].Value.ToString();
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Students List";
            printer.TitleSpacing = 30;
            printer.SubTitle = string.Format("Date {0}", DateTime.Now.Date);
            printer.SubTitleSpacing = 20;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Enrollment System";
            printer.PrintDataGridView(listofStd);

        }

        private void searchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            bindGrid();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Search Student...";
            bindGrid();
        }
    }
}

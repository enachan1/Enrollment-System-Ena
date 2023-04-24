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
    public partial class UCProgramList : UserControl
    {
        public UCProgramList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCProgramList_Load(object sender, EventArgs e)
        {
            listofProgram.AutoGenerateColumns = false;
            using (SqlConnection sqlconn = new SqlConnection(dbmscon.conString))
            {
                sqlconn.Open();
                if (sqlconn.State == System.Data.ConnectionState.Open)
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showPrgInfo, sqlconn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        listofProgram.DataSource = dt;
                        sqlconn.Close();
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search(txtSearch.Text);
        }
        void search(string search)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM programList WHERE ProgramName = @stdName OR ProgramName LIKE @stdNm", sc))
                    {
                        command.Parameters.AddWithValue("stdName", search);
                        command.Parameters.AddWithValue("stdNm", string.Format("%{0}%", search));
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        listofProgram.DataSource = dt;
                        sc.Close();
                    }
                }
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Program List";
            printer.TitleSpacing = 30;
            printer.SubTitle = string.Format("Date {0}", DateTime.Now.Date.ToString("YYYY-MM-dd"));
            printer.SubTitleSpacing = 20;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.Footer = "Enrollment System";
            printer.PrintDataGridView(listofProgram);
        }
    }
}

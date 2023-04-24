using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class Reciept : Form
    {
        string studentNumber;
        string name1;
        string program;
        string amountPaid;
        string balance;
        public Reciept(string studentNumber, string Name, string program, string amountPaid, string balance)
        {
            InitializeComponent();
            this.studentNumber = studentNumber;
            this.name1 = Name;
            this.program = program;
            this.amountPaid = amountPaid;
            this.balance = balance;

        }

        private void Reciept_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string date = dt.ToString("MM/dd/yyyy");

            ReportParameterCollection rp = new ReportParameterCollection();
            rp.Add(new ReportParameter("stunum", studentNumber));
            rp.Add(new ReportParameter("name", name1));
            rp.Add(new ReportParameter("date", date));
            rp.Add(new ReportParameter("program", program));
            rp.Add(new ReportParameter("amountpaid", amountPaid));
            rp.Add(new ReportParameter("balance", balance));
            rv.LocalReport.SetParameters(rp);
            this.rv.RefreshReport();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

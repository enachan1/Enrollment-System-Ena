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
    public partial class DashBoard : Form
    {
        //Collapsing Button
        bool isCollapse, isCollapse1, isCollapse2, isCollapse3, isCollapse4;
        //window movement
        bool mouse;

        public DashBoard()
        {
            InitializeComponent();
         
        }
        private void logout()
        {
            using (SqlConnection sqlcon = new SqlConnection(dbmscon.conString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM userTB WHERE isActive = 1", sqlcon);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        long userId = reader.GetInt64(0);
                        sqlcon.Close();

                        sqlcon.Open();
                        SqlCommand isActiveupdate = new SqlCommand("UPDATE userTB SET isActive = 0 WHERE id = @userID", sqlcon);
                        isActiveupdate.Parameters.AddWithValue("@userID", userId);
                        isActiveupdate.ExecuteNonQuery();

                        this.Hide();
                        Form1 fm = new Form1();
                        fm.ShowDialog();
                        this.Close();
                        sqlcon.Close();
                    }
                }
            }
        }
        
        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to log out??", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                logout();
            }
            else if (dg == DialogResult.No)
            {

            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void drpBtn_Click(object sender, EventArgs e)
        {
            tmrStd.Start();
        }

        private void tmrStd_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                dropStd.Height += 10;
                if (dropStd.Size == dropStd.MaximumSize)
                {
                    tmrStd.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                dropStd.Height -= 10;
                if (dropStd.Size == dropStd.MinimumSize)
                {
                    tmrStd.Stop();
                    isCollapse = true;

                }
            }
        }

        private void tmrEnroll_Tick(object sender, EventArgs e)
        {
            if (isCollapse1)
            {
                dropenroll.Height += 10;
                if (dropenroll.Size == dropenroll.MaximumSize)
                {
                    tmrEnroll.Stop();
                    isCollapse1 = false;
                }
            }
            else
            {
                dropenroll.Height -= 10;
                if (dropenroll.Size == dropenroll.MinimumSize)
                {
                    tmrEnroll.Stop();
                    isCollapse1 = true;

                }
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            tmrEnroll.Start();
        }

        private void tmrPayment_Tick(object sender, EventArgs e)
        {
            if (isCollapse2)
            {
                drpMaintenance.Height += 10;
                if (drpMaintenance.Size == drpMaintenance.MaximumSize)
                {
                    tmrMaintenance.Stop();
                    isCollapse2 = false;
                }
            }
            else
            {
                drpMaintenance.Height -= 10;
                if (drpMaintenance.Size == drpMaintenance.MinimumSize)
                {
                    tmrMaintenance.Stop();
                    isCollapse2 = true;

                }
            }
        }

        private void payBTN_Click(object sender, EventArgs e)
        {
            tmrMaintenance.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void msDown(object sender, MouseEventArgs e)
        {
            mouse = true;
        }

        private void msMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                int x = MousePosition.X - 700;
                int y = MousePosition.Y - 20;
                this.SetDesktopLocation(x, y);
            }
        }

        private void msUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void drpMaintenance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maintenanceBtn_Click(object sender, EventArgs e)
        {
            tmrMaintenance.Start();
        }

        private void tmrPayment_Tick_1(object sender, EventArgs e)
        {
            if (isCollapse3)
            {
                drpPayment.Height += 10;
                if (drpPayment.Size == drpPayment.MaximumSize)
                {
                    tmrPayment.Stop();
                    isCollapse3 = false;
                }
            }
            else
            {
                drpPayment.Height -= 10;
                if (drpPayment.Size == drpPayment.MinimumSize)
                {
                    tmrPayment.Stop();
                    isCollapse3 = true;

                }
            }
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            tmrPayment.Start();
        }

        private void tmrReports_Tick(object sender, EventArgs e)
        {
            if (isCollapse4)
            {
                drpReports.Height += 10;
                if (drpReports.Size == drpReports.MaximumSize)
                {
                    tmrReports.Stop();
                    isCollapse4 = false;
                }
            }
            else
            {
                drpReports.Height -= 10;
                if (drpReports.Size == drpReports.MinimumSize)
                {
                    tmrReports.Stop();
                    isCollapse4 = true;

                }
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tmrReports.Start();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            dashboardDisplay1.Show();
            ucProgramList1.Hide();
            listofStudent1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            sampleUser1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
        }
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardDisplay1.Show();
            ucProgramList1.Hide();
            listofStudent1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            sampleUser1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Dashboard";
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            
            listofStudent1.Hide();
            dashboardDisplay1.Hide();
            ucProgramList1.Hide();
            addStudent1.Show();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            sampleUser1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Add Student";
            
        }

        private void btnEnrollStd_Click(object sender, EventArgs e)
        {
            enrollStudent1.Show();
            dashboardDisplay1.Hide();
            listofStudent1.Hide();
            dashboardDisplay1.Hide();
            addStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            sampleUser1.Hide();
            ucProgramList1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Enroll Student";         
        }

        private void btnSection_Click(object sender, EventArgs e)
        {

            manageSection1.Show();
            dashboardDisplay1.Hide();
            listofStudent1.Hide();
            dashboardDisplay1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            sampleUser1.Hide();
            ucProgramList1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Manage Section";

        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            ucManageProgram1.Show();
            ucProgramList1.Hide();
            listofStudent1.Hide();
            addStudent1.Hide();
            dashboardDisplay1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            sampleUser1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Manage Program";
        }

        private void btnSchoolYear_Click(object sender, EventArgs e)
        {
            manageSchoolYear1.Show();
            dashboardDisplay1.Hide();
            ucProgramList1.Hide();
            listofStudent1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            ucManageProgram1.Hide();
            sampleUser1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Manage School Year";
        }

       

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            listofStudent1.Show();
            dashboardDisplay1.Hide();
            ucProgramList1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            sampleUser1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Student List";
        }

        private void EnrollBtnIrreg_Click(object sender, EventArgs e)
        {

        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            manageSubject1.Show();
            ucTransactionLog1.Hide();
            sampleUser1.Hide();
            dashboardDisplay1.Hide();
            ucProgramList1.Hide();
            listofStudent1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            balanceReport1.Hide();
            label3.Text = "Manage Subject";
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            balanceReport1.Show();
            manageSubject1.Hide();
            ucTransactionLog1.Hide();
            sampleUser1.Hide();
            dashboardDisplay1.Hide();
            ucProgramList1.Hide();
            listofStudent1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            label3.Text = "Balance List";
        }

        private void btnEnrolled_Click(object sender, EventArgs e)
        {
            dashboardDisplay1.Hide();
            ucProgramList1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Show();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            sampleUser1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Enrolled Student";
        }

        private void btnProgramList_Click(object sender, EventArgs e)
        {
            ucProgramList1.Show();
            listofStudent1.Hide();
            addStudent1.Hide();
            dashboardDisplay1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            sampleUser1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Program List";
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            sampleUser1.Show();
            dashboardDisplay1.Hide();
            ucProgramList1.Hide();
            listofStudent1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            ucTransactionLog1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Payment";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ucTransactionLog1.Show();
            sampleUser1.Hide();
            dashboardDisplay1.Hide();
            ucProgramList1.Hide();
            listofStudent1.Hide();
            addStudent1.Hide();
            enrollStudent1.Hide();
            manageSection1.Hide();
            enrolledStudent1.Hide();
            manageSchoolYear1.Hide();
            ucManageProgram1.Hide();
            manageSubject1.Hide();
            balanceReport1.Hide();
            label3.Text = "Transaction Log";
        }
    }
}

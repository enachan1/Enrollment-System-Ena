using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class DashboardDisplay : UserControl
    {
        public DashboardDisplay()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dateText.Text = dt.ToString("yyyy/MM/dd");
            timeText.Text = dt.ToString("hh:mm:ss:tt");
        }

        private void DashboardDisplay_Load(object sender, EventArgs e)
        {
            getActive();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateText_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }


        private void getActive()
        {
            using (SqlConnection sqlconn = new SqlConnection(dbmscon.conString))
            {
                sqlconn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM userTB WHERE isActive = 1", sqlconn);

                using (SqlDataReader sqlread = sqlCommand.ExecuteReader())
                {
                    if (sqlread.Read())
                    {
                        bool isActive = sqlread.GetBoolean(3);
                        string user1 = sqlread.GetString(1);
                        user.Text = user1;
                        sqlconn.Close();

                    }
                    else
                    {
                        MessageBox.Show("Erorr Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

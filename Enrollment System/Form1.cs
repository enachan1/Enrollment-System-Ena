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
    public partial class Form1 : Form
    {
        bool mouse;
        string username;
        string password;

        public Form1()
        {
            InitializeComponent();
        
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;

            try
            {
                if (!string.IsNullOrEmpty(username) || !string.IsNullOrEmpty(password))
                {
                    LogmeIn(username, password);
                } else
                {
                    MessageBox.Show("Please Enter Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            
        }
    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelClickDown(object sender, MouseEventArgs e)
        {
            this.mouse = true;
        }

        private void panelClickUp(object sender, MouseEventArgs e)
        {
            this.mouse = false; 
        }

        private void panelMoves(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                int x = MousePosition.X - 400;
                int y = MousePosition.Y - 20;
                this.SetDesktopLocation(x, y);
            }
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            RegisterForm rg = new RegisterForm();
            rg.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
           if(chk.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
           else
            {
                textBox2.PasswordChar = '*';
            }
        }
        void LogmeIn(string username, string password)
        {
            using(SqlConnection sqlcon = new SqlConnection(dbmscon.conString))
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM userTB WHERE username = @username AND password = @password", sqlcon);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using(SqlDataReader sqlread = cmd.ExecuteReader())
                {
                    if (sqlread.Read())
                    {
                        long userId = sqlread.GetInt64(0);
                        string user = sqlread.GetString(1);
                        sqlcon.Close();

                        //updating isActive to capture the active account
                        sqlcon.Open();
                        SqlCommand isActiveupdate = new SqlCommand("UPDATE userTB SET isActive = 1 WHERE id = @userID", sqlcon);
                        isActiveupdate.Parameters.AddWithValue("@userID", userId);
                        isActiveupdate.ExecuteNonQuery();

                        //Opens the Dashboard Form
                        this.Hide();
                        DashBoard db = new DashBoard();
                        db.ShowDialog();
                        this.Close();
                        sqlcon.Close();
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

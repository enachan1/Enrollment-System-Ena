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
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            contactParentText.MaxLength = 11;
            ageText.MaxLength = 2;
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
            // Student Information
            string firstname = fnameText.Text;
            string midname = mnameText.Text;
            string lastname = lnameText.Text;
            string sname = snameText.Text;
            string gender = genderCB.SelectedItem.ToString();
            string civil = civilCB.SelectedItem.ToString();
            string citizen = citizenText.Text;
            string bday = dateofBirth.Value.ToString("yyyy-MM-dd");
            string bplace = birthplaceText.Text;
            string religion = religionText.Text;
            int age = Convert.ToInt32(ageText.Text);

            // Student Address
            string address = addressText.Text;

            // Guardian Details
            string pfname = fnameParentText.Text;
            string contact = contactParentText.Text;
            string email = emailParentText.Text;

                SqlConnection sqlcon = new SqlConnection(dbmscon.conString);
                sqlcon.Open();

                if (sqlcon.State == System.Data.ConnectionState.Open)
                {
                    string query = "INSERT INTO StudentListTBL(Full_Name, Gender, Civil_Status, Citizenship, Birthday, Birthplace, Religion, Address, Guardian_Name, Contact, Email, Age)" +
                        "VALUES(@Full_Name, @Gender, @Civil_Status, @Citizenship, @Birthday, @Birthplace, @Religion, @Address, @Guardian_Name, @Contact, @Email, @Age)";
                    SqlCommand cmd = new SqlCommand(query, sqlcon);
                    cmd.Parameters.AddWithValue("@Full_Name", addstdEncaps.getFullName(firstname, midname, lastname, sname));
                    cmd.Parameters.AddWithValue("@Gender", addstdEncaps.getGender(gender));
                    cmd.Parameters.AddWithValue("@Civil_Status", addstdEncaps.getCivil(civil));
                    cmd.Parameters.AddWithValue("@Citizenship", addstdEncaps.getCitizen(citizen));
                    cmd.Parameters.AddWithValue("@Birthday", addstdEncaps.getBirthDay(bday));
                    cmd.Parameters.AddWithValue("@Birthplace", addstdEncaps.getBirthplace(bplace));
                    cmd.Parameters.AddWithValue("@Religion", addstdEncaps.getReligion(religion));
                    cmd.Parameters.AddWithValue("@address", addstdEncaps.getAddress(address));
                    cmd.Parameters.AddWithValue("@Guardian_Name", addstdEncaps.getGuardianName(pfname));
                    cmd.Parameters.AddWithValue("@Contact", addstdEncaps.getContact(contact));
                    cmd.Parameters.AddWithValue("@Email", addstdEncaps.getemail(email));
                    cmd.Parameters.AddWithValue("@Age", addstdEncaps.getage(age));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlcon.Close();
                    Clear();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("There's an Error " + "\n" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        public void Clear()
        {
            fnameText.Text = "";
            mnameText.Text = "";
            lnameText.Text = "";
            snameText.Text = "";
            citizenText.Text = "";
            birthplaceText.Text = "";
            religionText.Text = "";
            ageText.Text = "";
            addressText.Text = "";
            fnameParentText.Text = "";
            emailParentText.Text = "";

        }

        private void ageText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            } 
        }

        private void contactParentText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Enrollment_System
{
    class enrollStudentClass
    {

        public void enrolled(string stunum, string name, int age, string sex, string section, string sy, string program, string stdtype)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dbmscon.conString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand checker = new SqlCommand("SELECT studentNum FROM enrolledStudentsList WHERE studentNum = @stdnum", conn);
                        checker.Parameters.AddWithValue("@stdnum", stunum);
                        checker.Parameters.AddWithValue("@Name", name);
                        SqlDataReader sdr;
                        sdr = checker.ExecuteReader();
                        if (sdr.Read())
                        {
                            MessageBox.Show("Existing Student! Please generate another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();

                        }
                        else
                        {
                            conn.Close();
                            SqlCommand insert = new SqlCommand("INSERT INTO enrolledStudentsList(studentNum, Name, Age, Sex, Section, schoolyear, program, studenttype)" +
                            "VALUES(@studentNum, @Name, @Age, @Sex, @Section, @schoolyear, @program, @studenttype)", conn);
                            insert.Parameters.AddWithValue("@studentNum", stunum);
                            insert.Parameters.AddWithValue("@Name", name);
                            insert.Parameters.AddWithValue("@Age", age);
                            insert.Parameters.AddWithValue("@Sex", sex);
                            insert.Parameters.AddWithValue("@Section", section);
                            insert.Parameters.AddWithValue("@schoolyear", sy);
                            insert.Parameters.AddWithValue("@program", program);
                            insert.Parameters.AddWithValue("@studenttype", stdtype);
                            conn.Open();
                            insert.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Student is Enrolled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input" + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateEnrolled(int id, string schoolyear, string section)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dbmscon.conString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand update = new SqlCommand("UPDATE enrolledStudentsList SET schoolyear = @sy, Section = @Section WHERE id = @identity", conn))
                        {
                            update.Parameters.AddWithValue("@sy", schoolyear);
                            update.Parameters.AddWithValue("@Section", section);
                            update.Parameters.AddWithValue("@identity", id);
                            update.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Updated", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid Input" + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Enrollment_System
{
    internal class manageSubjectClass
    {
        public void addData(string subjname, string prog, string section, string days, string hours)
        {
           try
            {
                using (SqlConnection sc = new SqlConnection(dbmscon.conString))
                {
                    sc.Open();
                    if (sc.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO subjectList(subjectname, program, section, days, hours) VALUES(@subjectname, @program, @section, @days, @hours)", sc))
                        {
                            cmd.Parameters.AddWithValue("@subjectname", subjname);
                            cmd.Parameters.AddWithValue("@program", prog);
                            cmd.Parameters.AddWithValue("@section", section);
                            cmd.Parameters.AddWithValue("@days", days);
                            cmd.Parameters.AddWithValue("@hours", hours);
                            cmd.ExecuteNonQuery();
                            sc.Close();
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Input" + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updateData(int id, string subjname, string prog, string section, string days, string hours)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dbmscon.conString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand update = new SqlCommand("UPDATE subjectList SET subjectname = @subjectname, program = @program, section = @sect, days = @days, hours = @hours WHERE id = @identity", conn))
                        {
                            update.Parameters.AddWithValue("@subjectname", subjname);
                            update.Parameters.AddWithValue("@program", prog);
                            update.Parameters.AddWithValue("@sect", section);
                            update.Parameters.AddWithValue("@identity", id);
                            update.Parameters.AddWithValue("@days", days);
                            update.Parameters.AddWithValue("@hours", hours);
                            update.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Updated", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input" + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void deleteData(int id)
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(dbmscon.conString))
                {
                    sc.Open();
                    if (sc.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM subjectList where id = @id", sc))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            cmd.ExecuteNonQuery();
                            sc.Close();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input" + "\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

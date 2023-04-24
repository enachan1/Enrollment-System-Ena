using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    internal class manageSYEncaps : manageCRUD
    {
        ManageSchoolYear msy = new ManageSchoolYear();
        public override void addData(string data)
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(dbmscon.conString))
                {
                    sc.Open();
                    if (sc.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO schoolYearList(SchoolYear) VALUES(@SY)", sc))
                        {
                            cmd.Parameters.AddWithValue("@SY", data);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            msy.dataschoolYear.DataSource = dt;
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

        public override void deleteData(int id)
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(dbmscon.conString))
                {
                    sc.Open();
                    if (sc.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM schoolYearList where id = @id", sc))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            msy.dataschoolYear.DataSource = dt;
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

        public override void updateData(int id, string updatedata)
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(dbmscon.conString))
                {
                    sc.Open();
                    if (sc.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE schoolYearList set SchoolYear = @schoolyear where id = @id", sc))
                        {
                            cmd.Parameters.AddWithValue("@schoolyear", updatedata);
                            cmd.Parameters.AddWithValue("@id", id);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            msy.dataschoolYear.DataSource = dt;
                            sc.Close();
                            MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Invalid Input" + "\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

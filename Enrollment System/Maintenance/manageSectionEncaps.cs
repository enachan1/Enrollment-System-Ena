using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Enrollment_System
{
    internal class manageSectionEncaps : manageCRUD
    {
        ManageSection ms = new ManageSection();
        public override void addData(string data)
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(dbmscon.conString))
                {
                    sc.Open();
                    if (sc.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO sectionList(section) VALUES(@sectionName)", sc))
                        {
                            cmd.Parameters.AddWithValue("@sectionName", data);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            ms.sectionDataList.DataSource = dt;
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
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM sectionList where id = @id", sc))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            ms.sectionDataList.DataSource = dt;
                            sc.Close();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input" + "\n" + ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        using (SqlCommand cmd = new SqlCommand("UPDATE sectionList set section = @Name where id = @id", sc))
                        {
                            cmd.Parameters.AddWithValue("@name", updatedata);
                            cmd.Parameters.AddWithValue("@id", id);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);   
                            ms.sectionDataList.DataSource = dt;
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

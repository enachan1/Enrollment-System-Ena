using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Enrollment_System
{
    class manageProgramEncaps : manageCRUD
    {
        UCManageProgram uc = new UCManageProgram();

        public override void addData(string data)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO programList(ProgramName) VALUES(@Program)", sc))
                    {
                        cmd.Parameters.AddWithValue("@Program", data);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        uc.programdatalist.DataSource = dt;
                        sc.Close();
                    }

                }
            }
        }

        public override void deleteData(int id)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM programList where id = @id", sc))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        uc.programdatalist.DataSource = dt;
                        sc.Close();
                    }

                }
            }
        }

        public override void updateData(int id, string updatedata)
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                sc.Open();
                if (sc.State == System.Data.ConnectionState.Open)
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE programList set ProgramName = @Name where id = @id", sc))
                    {
                        cmd.Parameters.AddWithValue("@name", updatedata);
                        cmd.Parameters.AddWithValue("@id", id);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        uc.programdatalist.DataSource = dt;
                        sc.Close();
                    }

                }
            }
        }
    }
}

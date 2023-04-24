using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    class transactLogClass
    {
        public void insertTransact(string transactType)
        {
            DateTime dt = DateTime.Now;
            string time = dt.ToString("yyyyy/MM/dd - hh:mm:ss");
            string datenum = dt.ToString("yyyy");
            Random rand = new Random();
            int tnum = rand.Next(5000, 9999);
            string combined = datenum + tnum.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(dbmscon.conString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM userTB WHERE isActive = 1", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string user = reader.GetString(1);
                            conn.Close();
                            conn.Open();
                            SqlCommand insert = new SqlCommand("INSERT INTO transactionlog(transactnum, transacttype, transacttimedate, username) VALUES(@transactnum, @transacttype, @transacttimedate, @username)", conn);

                                insert.Parameters.AddWithValue("@transactnum", combined);
                                insert.Parameters.AddWithValue("@transacttype", transactType);
                                insert.Parameters.AddWithValue("@transacttimedate", time);
                                insert.Parameters.AddWithValue("@username", user);
                                insert.ExecuteNonQuery();

                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

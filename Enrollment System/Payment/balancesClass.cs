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
    internal class balancesClass
    {
        Balances bs = new Balances();
        public void getBalances(string stunum, string name, string program, float balance, string amount)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(dbmscon.conString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand checker = new SqlCommand("SELECT stunum FROM balances WHERE stunum = @stdnum", conn);
                        checker.Parameters.AddWithValue("@stdnum", stunum);
                        SqlDataReader sdr;
                        sdr = checker.ExecuteReader();
                        if (sdr.Read())
                        {
                            MessageBox.Show("Please go to balances to pay for the current balances", "Existing Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();

                        }
                        else
                        {
                            conn.Close();
                            SqlCommand insert = new SqlCommand("INSERT INTO balances(stunum, name, program, balance) VALUES(@studentNum, @Name, @program, @balance) ", conn);
                            insert.Parameters.AddWithValue("@studentNum", stunum);
                            insert.Parameters.AddWithValue("@Name", name);
                            insert.Parameters.AddWithValue("@program", program);
                            insert.Parameters.AddWithValue("@balance", balance);
                            conn.Open();
                            insert.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Payment Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           

                            //instantiate reciept
                            Reciept rp = new Reciept(stunum, name, program, amount, balance.ToString());
                            rp.ShowDialog();


                        }
                    }
                }
            }
            catch
            {

            }
        }
        public void updateBalance(int id, string stunum, string name, string program, string amount, float balance)
        {
            try
            {
                using (SqlConnection sc = new SqlConnection(dbmscon.conString))
                {
                    sc.Open();
                    if (sc.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE balances set balance = @bal where id = @id", sc))
                        {
                            cmd.Parameters.AddWithValue("@bal", balance);
                            cmd.Parameters.AddWithValue("@id", id);
                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            bs.balanceLst.DataSource = dt;
                            sc.Close();
                            MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                Reciept rp = new Reciept(stunum, name, program, amount, balance.ToString());
                rp.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Invalid Input" + "\n" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

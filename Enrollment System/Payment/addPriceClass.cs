using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Enrollment_System
{
    internal class addPriceClass
    {
       public void addProgramPrice(string subjectname, string subjectprog, string subjectsect, float price)
        {
            try { 
            using (SqlConnection conn = new SqlConnection(dbmscon.conString))
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                        SqlCommand insert = new SqlCommand("UPDATE subjectList SET price = @price WHERE subjectname = @subjectname AND program = @prg AND section = @sect", conn);
                        insert.Parameters.AddWithValue("@subjectname", subjectname);
                        insert.Parameters.AddWithValue("@prg", subjectprog);
                        insert.Parameters.AddWithValue("@sect", subjectsect);
                        insert.Parameters.AddWithValue("@price", price);
                        insert.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Price Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

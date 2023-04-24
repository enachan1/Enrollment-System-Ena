using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrollment_System
{
    public partial class UCTransactionLog : UserControl
    {
        public UCTransactionLog()
        {
            InitializeComponent();
        }

        private void UCTransactionLog_Load(object sender, EventArgs e)
        {
            bindSource();
        }
        void bindSource()
        {
            using(SqlConnection sqlconn = new SqlConnection(dbmscon.conString))
            {
                transactLst.AutoGenerateColumns = false;
                sqlconn.Open();
                if(sqlconn.State == System.Data.ConnectionState.Open)
                {
                    using(SqlDataAdapter sda = new SqlDataAdapter(dbmscon.showtransact, sqlconn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        transactLst.DataSource = dt;
                        sqlconn.Close();
                    }
                }
            }
        }

        private void transactLst_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindSource();
        }
    }
}

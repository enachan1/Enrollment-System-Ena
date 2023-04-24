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
    public partial class PriceList : UserControl
    {
        public PriceList()
        {
            InitializeComponent();
        }
        private void PriceList_Load(object sender, EventArgs e)
        {
            programData();
            sectionData();
        }
        private void programCB_Click(object sender, EventArgs e)
        {
            programData();
        }
        private void priceText_TextChanged(object sender, EventArgs e)
        {

        }
        private void addpriceBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(priceText.Text) || !string.IsNullOrEmpty(subjtext.Text))
            {
                string subjectName = subjtext.Text;
                string programName = programCB.Text;
                string section = sectionCB.Text;
                float subjectPrice = float.Parse(priceText.Text);

                addPriceClass apc = new addPriceClass();
                apc.addProgramPrice(subjectName, programName, section, subjectPrice);
                Clear();
            }
            else
            {
                MessageBox.Show("There are missing fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void programCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void sectionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            showData();
        }
        private void sectionCB_Click(object sender, EventArgs e)
        {
            sectionData();
        }

        private void subjectsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = subjectsList.CurrentCell.RowIndex;
            if (index > -1)
            {
                subjtext.Text = subjectsList.Rows[index].Cells["subjectName"].Value.ToString();
            }
        }
        void programData()
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda1 = new SqlDataAdapter(dbmscon.showPrgInfo, sc))
                {
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    programCB.DataSource = dt1;
                    programCB.DisplayMember = "ProgramName";
                    sc.Close();
                }
            }
        }
        void sectionData()
        {
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlDataAdapter sda1 = new SqlDataAdapter(dbmscon.showSectionInfo, sc))
                {
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    sectionCB.DataSource = dt1;
                    sectionCB.DisplayMember = "section";
                    sc.Close();
                }
            }
        }
        void showData()
        {
            subjectsList.AutoGenerateColumns = false;
            using (SqlConnection sc = new SqlConnection(dbmscon.conString))
            {
                using (SqlCommand sqlcom = new SqlCommand("SELECT * FROM subjectList WHERE program = '" + programCB.Text + "' AND section = '" + sectionCB.Text + "'", sc))
                {
                    using (SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom))
                    {
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        subjectsList.DataSource = dt1;
                        sc.Close();
                    }
                }
            }
        }
        void Clear()
        {
            subjtext.Text = "";
            priceText.Text = "";
        }


    }
}

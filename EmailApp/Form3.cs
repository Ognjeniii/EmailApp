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

namespace EmailApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("connectionString"); // connection to a database
        
        // filling the table 
        private void Form3_Load(object sender, EventArgs e)
        {
            this.log1TableAdapter.Fill(this.zaposleniDataSet9.Log1);

        }
        
        // mathod for deleting data from database
        private void btnObrisiBazu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nema nicega u logu!");
            }
            else
            {
                if (tbMatBr.Text == "")
                {
                    MessageBox.Show("Unesite maticni broj!");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Delete from Log1 where MaticniBroj = '" + int.Parse(tbMatBr.Text) + "'", con);
                    con.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Uspesno obrisano!");
                        this.log1TableAdapter.Fill(this.zaposleniDataSet9.Log1);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }
                    con.Close();
                }
            }
        }

        // method for getting the row by mouse clicking
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            tbMatBr.Text = row.Cells[1].Value.ToString();
        }
    }
}

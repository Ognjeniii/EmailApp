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

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-DETU8RQ\\SQLEXPRESS01;Initial Catalog=Zaposleni;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zaposleniDataSet9.Log1' table. You can move, or remove it, as needed.
            this.log1TableAdapter.Fill(this.zaposleniDataSet9.Log1);

        }

        private void btnObrisiBazu_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count == 0)
            //{
            //    MessageBox.Show("Nema nicega u logu!");
            //}
            //else
            //{
            //    if (dataGridView1.SelectedRows.Count == 0)
            //    {
            //        MessageBox.Show("Ni jedan red nije izabran!");
            //    }
            //    else
            //    {
            //        con.Open();
            //        SqlCommand cmd = new SqlCommand("DELETE FROM Log1 WHERE MaticniBroj = @MatBr", con);
            //        int selectedIndex = dataGridView1.SelectedRows[0].Index;
            //        int MatBr = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);
            //        cmd.Parameters.Add("@MatBr", SqlDbType.Int).Value = MatBr;
            //        try
            //        {
            //            cmd.ExecuteNonQuery();
            //            dataGridView1.Rows.RemoveAt(selectedIndex);
            //            MessageBox.Show("Uspesno obrisano!");
            //        }
            //        catch (Exception ee)
            //        {
            //            MessageBox.Show(ee.ToString());
            //        }

            //        con.Close();
            //    }
            //}

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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            tbMatBr.Text = row.Cells[1].Value.ToString();
        }
    }
}

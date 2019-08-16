using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace the_project
{
    public partial class Form15 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data source = سمللحاسبات-PC; initial catalog = Programmming_company ; integrated security = true;");
        SqlDataAdapter Da;
        DataSet Ds = new DataSet();
        public Form15()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from programs", cn);
            Da.Fill(Ds, "programs");
            dataGridView1.DataSource = Ds.Tables["programs"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to Buy this selected program ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                MessageBox.Show("the program who you select it is available for you:", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult We = MessageBox.Show("Do you not want to Buy the program which you select it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (We == DialogResult.Yes)
                {
                    MessageBox.Show("Merci for visiting to our Company website", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("the program who you select it is available for you:", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
    }

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
    public partial class Form14 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data source = سمللحاسبات-PC; initial catalog = Programmming_company ; integrated security = true;");
        SqlDataAdapter Da;
        DataSet Ds =new DataSet();
        public Form14()
        {
            InitializeComponent();
            Da = new SqlDataAdapter("select * from courses", cn);
            Da.Fill(Ds, "courses");
            dataGridView1.DataSource = Ds.Tables["courses"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
         DialogResult Result = MessageBox.Show("Do you want to study this selected Course ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (Result == DialogResult.Yes)
         {
             MessageBox.Show("you Will study this selected course:", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         else
         {
             DialogResult We= MessageBox.Show("Do you not want to study the course which you select it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
             if (We == DialogResult.Yes)
             {
                 MessageBox.Show("Merci for visiting to our Company website", "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
             else
             {
                 MessageBox.Show("you Will study this selected course:", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }

         }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}

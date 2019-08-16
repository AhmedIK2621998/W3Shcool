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
    public partial class Form8 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data source = سمللحاسبات-PC; initial catalog = Programmming_company ; integrated security = true;");
        SqlCommand cmd;
        private bool p;
        public Form8()
        {
            InitializeComponent();
        }

        public Form8(bool p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("insert into programs(gr_id , name ,size ,price) values(" + textBox1.Text + " , '" + textBox2.Text + "' , " + textBox3.Text + " ," + textBox4.Text + ")", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Some Errors Was Occured ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

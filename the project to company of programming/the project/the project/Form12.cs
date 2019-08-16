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
    public partial class Form12 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data source = سمللحاسبات-PC; initial catalog = Programmming_company ; integrated security = true;");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = new SqlCommand("select name ,price from courses where cs_id= " + textBox1.Text + "", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                textBox3.Text = dr["name"].ToString();
                textBox4.Text = dr["price"].ToString();
                this.Size = new Size(this.Width, 412);
            }
            catch
            {
                MessageBox.Show("No Data found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("update courses set  name='" + textBox3.Text + "' ,price=" + textBox4.Text + " where cs_id ="+textBox1.Text+"", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

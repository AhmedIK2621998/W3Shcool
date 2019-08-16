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
    public partial class Form9 : Form
    {

        SqlConnection cn = new SqlConnection(@"Data source = سمللحاسبات-PC; initial catalog = Programmming_company ; integrated security = true;");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form9()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = new SqlCommand("select name ,size ,price from programs where gr_id= " + textBox1.Text + "", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                textBox3.Text = dr["name"].ToString();
                textBox4.Text = dr["size"].ToString();
                textBox5.Text = dr["price"].ToString();
                this.Size = new Size(this.Width, 300);
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("update programs set  name='" + textBox3.Text + "' ,size=" + textBox4.Text + " , price="+ textBox5.Text+"where gr_id="+textBox1.Text+"", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

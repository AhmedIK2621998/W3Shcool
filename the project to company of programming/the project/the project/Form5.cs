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
    public partial class Form5 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data source = سمللحاسبات-PC; initial catalog = Programmming_company ; integrated security = true;");
        SqlCommand cmd;
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void text2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("insert into client_company(cl_id,name,pro_id) values(" + textBox1.Text + " , '" + textBox2.Text + "' , " + textBox3.Text + ")" ,cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Orphan Acceptation your Company to be Client Company for our Company", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

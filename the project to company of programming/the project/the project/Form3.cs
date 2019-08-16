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
    public partial class Form3 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data source = سمللحاسبات-PC; initial catalog = Programmming_company ; integrated security = true;");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
            cmd = new SqlCommand("select name from programs" , cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Programs.Items.Add(dr["name"].ToString());
            }
            dr.Close();
            cn.Close();
                text1.Enabled = false;
                text2.Enabled = false;
                text3.Enabled = false;
        }

        private void text4_Click(object sender, EventArgs e)
        {
            Form15 hk = new Form15();
            hk.Show();
        }

        private void text5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text6_Click(object sender, EventArgs e)
        {
            Form5 bt = new Form5();
            bt.Show();
        }
        private void text1_Click(object sender, EventArgs e)
        {
            Form8 fr = new Form8();
            fr.Show();
        }
        private void text2_Click(object sender, EventArgs e)
        {
            Form9 nh = new Form9();
            nh.Show();
        }

        private void text3_Click(object sender, EventArgs e)
        {
            Form10 rt = new Form10();
            rt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ahmed salah" || textBox1.Text == "Ahmed soliman" || textBox1.Text == "Ahmed Ibrahim" || textBox1.Text == "Ahmed Darwish")
            {
                text1.Enabled = true;
                text2.Enabled = true;
                text3.Enabled = true;
            }
            else
            {
                text1.Enabled = false;
                text2.Enabled = false;
                text3.Enabled = false;
            }
        }
    }
}

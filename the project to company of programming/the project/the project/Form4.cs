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
    public partial class Form4 : Form
    {
        SqlConnection c = new SqlConnection(@"Data source =""E:\FCI\projects\the project to company of programming\the project\the project""; initial catalog = Programmming_company ; integrated security = true;");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form4()
        {
            InitializeComponent();
            cmd = new SqlCommand("select name from courses", c);
            c.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Courses.Items.Add(dr["name"].ToString());
            }
            dr.Close();
            c.Close();
            text1.Enabled = false;
            text2.Enabled = false;
            text3.Enabled = false;
        }

        private void text5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text4_Click(object sender, EventArgs e)
        {
            Form7 hj = new Form7();
            hj.Show();
        }

        private void text1_Click(object sender, EventArgs e)
        {
            Form11 re = new Form11();
            re.Show();
        }

        private void text2_Click(object sender, EventArgs e)
        {
            Form12 hj = new Form12();
            hj.Show();
        }

        private void text3_Click(object sender, EventArgs e)
        {
            Form13 hg = new Form13();
            hg.Show();
        }

        private void text6_Click(object sender, EventArgs e)
        {
            Form14 rt = new Form14();
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

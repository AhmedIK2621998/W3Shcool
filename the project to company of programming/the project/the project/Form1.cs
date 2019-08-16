using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace the_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "EGYPT")
            {
                Form2 fr = new Form2();
                fr.Show();
                MessageBox.Show("Welcome to you in our Company : EGYPT 2050 ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DialogResult Result =    MessageBox.Show("Do you not recognize The Password?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                textBox2.Text = "EGYPT";
                MessageBox.Show(" The Password Will appear forward you Now", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (textBox1.Text == "EGYPT")
                {
                    Form2 fr = new Form2();
                    fr.Show();
                    MessageBox.Show("Welcome to you in our Company : EGYPT 2050 ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
                Form3 gr = new Form3();
                gr.Show();
                MessageBox.Show("This is department that be in it the all our programs", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
                Form4 ht = new Form4();
                ht.Show();
                MessageBox.Show("This is department that be in it the all our courses", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

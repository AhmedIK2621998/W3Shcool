namespace the_project
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Courses = new System.Windows.Forms.ListBox();
            this.text1 = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.Button();
            this.text3 = new System.Windows.Forms.Button();
            this.text4 = new System.Windows.Forms.Button();
            this.text5 = new System.Windows.Forms.Button();
            this.text6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses";
            // 
            // Courses
            // 
            this.Courses.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Courses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Courses.FormattingEnabled = true;
            this.Courses.Location = new System.Drawing.Point(12, 97);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(121, 225);
            this.Courses.TabIndex = 1;
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.Red;
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.text1.Location = new System.Drawing.Point(153, 113);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(177, 23);
            this.text1.TabIndex = 2;
            this.text1.Text = "Add";
            this.text1.UseVisualStyleBackColor = false;
            this.text1.Click += new System.EventHandler(this.text1_Click);
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.text2.ForeColor = System.Drawing.Color.Black;
            this.text2.Location = new System.Drawing.Point(153, 184);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(177, 23);
            this.text2.TabIndex = 3;
            this.text2.Text = "Update";
            this.text2.UseVisualStyleBackColor = false;
            this.text2.Click += new System.EventHandler(this.text2_Click);
            // 
            // text3
            // 
            this.text3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.text3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.text3.Location = new System.Drawing.Point(153, 250);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(177, 23);
            this.text3.TabIndex = 4;
            this.text3.Text = "Delete";
            this.text3.UseVisualStyleBackColor = false;
            this.text3.Click += new System.EventHandler(this.text3_Click);
            // 
            // text4
            // 
            this.text4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.text4.ForeColor = System.Drawing.Color.Maroon;
            this.text4.Location = new System.Drawing.Point(193, 288);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(80, 23);
            this.text4.TabIndex = 5;
            this.text4.Text = "Sign in";
            this.text4.UseVisualStyleBackColor = false;
            this.text4.Click += new System.EventHandler(this.text4_Click);
            // 
            // text5
            // 
            this.text5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.text5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.text5.Location = new System.Drawing.Point(12, 341);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(73, 23);
            this.text5.TabIndex = 6;
            this.text5.Text = "Exit";
            this.text5.UseVisualStyleBackColor = false;
            this.text5.Click += new System.EventHandler(this.text5_Click);
            // 
            // text6
            // 
            this.text6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.text6.ForeColor = System.Drawing.Color.Maroon;
            this.text6.Location = new System.Drawing.Point(104, 341);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(226, 23);
            this.text6.TabIndex = 7;
            this.text6.Text = "Complete for Select course for studing";
            this.text6.UseVisualStyleBackColor = false;
            this.text6.Click += new System.EventHandler(this.text6_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(137, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter your Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(222, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(342, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.text6);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Company of programming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Courses;
        private System.Windows.Forms.Button text1;
        private System.Windows.Forms.Button text2;
        private System.Windows.Forms.Button text3;
        private System.Windows.Forms.Button text4;
        private System.Windows.Forms.Button text5;
        private System.Windows.Forms.Button text6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
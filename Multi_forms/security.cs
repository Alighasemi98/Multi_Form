using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class security : Form
    {
        public security()
        {
            InitializeComponent();
        }

        Form1 f = new Form1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("admin") & textBox2.Text.Contains("admin"))
            {
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است ", "اختار");
            }
        }

        private void security_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("ایا میخواهید خارج شوید", "اختار", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) 
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}

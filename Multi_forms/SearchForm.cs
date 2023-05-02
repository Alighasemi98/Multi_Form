using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class SearchForm : Form
    {
        public PayForm pf;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        public string[] name = { "دانیال", "اینوالله باخرزاده", "ابدااله", "ممد", "علی", "رضا", "عباس بوعزار", "کوروش" };
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text== name[0])
            {
                pf.textBox1.Text = "14001037";
                this.Hide();
            }
            else if (textBox1.Text == name[1])
            {
                pf.textBox1.Text = "14001036";
                this.Hide();
            }
            else if (textBox1.Text == name[2])
            {
                pf.textBox1.Text = "14001087";
                this.Hide();
            }
            else if (textBox1.Text == name[3])
            {
                pf.textBox1.Text = "14001054";
                this.Hide();
            }
            else if (textBox1.Text == name[4])
            {
                pf.textBox1.Text = "14001078";
                this.Hide();
            }
            else if (textBox1.Text == name[5])
            {
                pf.textBox1.Text = "14001088";
                this.Hide();
            }
            else if (textBox1.Text == name[6])
            {
                pf.textBox1.Text = "14001055";
                this.Hide();
            }
            else if (textBox1.Text == name[0])
            {
                pf.textBox1.Text = "14001099";
                this.Hide();
            }
            
        }
    }
}

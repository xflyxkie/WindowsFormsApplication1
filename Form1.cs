using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nama.Text = "";
            pss.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = pss.Text;
            if (a.Equals("hotel"))
            {
                MessageBox.Show("Selamat login succes");
                hotel h = new hotel();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("maaf password salah ");
            }

        }

        private void nama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

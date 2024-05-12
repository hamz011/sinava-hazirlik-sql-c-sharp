using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav_hazirlik1
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = textBox1.Text;
            string tp = textBox2.Text;

            if(tk=="as"&&tp=="sa")
            {
                MessageBox.Show("Hoş Geldiniz!");
                Form2 fr2 = new Form2();
                this.Hide();
                fr2.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                textBox1.Text = "as";
                textBox2.Text = "sa";
            }
        }
    }
}

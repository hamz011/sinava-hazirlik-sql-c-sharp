using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinavHazirlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Defusername = "default", Defpassword = "12345";
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TXT_password.UseSystemPasswordChar)
            {
                TXT_password.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide Password";
            }
            else
            {
                TXT_password.UseSystemPasswordChar = true
                    ;
                checkBox1.Text = "Show Password";
            }
        }
        void Clear()
        {
            TXT_password.Clear();
            TXT_username.Clear();
        }
        Random rnd = new Random();
        int ppp = 0;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clear();
           int p= rnd.Next(0, 9999);
            ppp = p;
            string usr = "random";
            MessageBox.Show("Merhaba sizin tek seferlik:\nKullanıcı Adınız: '"+usr+"' Şifreniz: "+p.ToString());
        }

        private void BUT_login_Click(object sender, EventArgs e)
        {
            string us = TXT_username.Text;
            string ps = TXT_password.Text;
            if (us == Defusername && ps == Defpassword)
            {
                Clear();
                MessageBox.Show("Hoş geldin! - " + us.ToUpper());
                Form2 fr2 = new Form2();
                this.Hide();
                fr2.Show();
            }
            else
            {
                if (us == "random" && ps == ppp.ToString())
                {
                    Clear();
                    MessageBox.Show("Hoş geldin! - Gizemli Kullanıcı");
                    Form2 fr2 = new Form2();
                    this.Hide();
                    fr2.Show();
                }
                
                else { 
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
               
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            TXT_password.Text = Defpassword;
            TXT_username.Text = Defusername;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXT_password.UseSystemPasswordChar = true;
        }
    }
}

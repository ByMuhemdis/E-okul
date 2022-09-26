using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_okul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string kullanici1 = "1";
            string kullanici2 = "tugay aydın";
            string kullanici3 = "rükiye eren";
            string kullanici4 = "aysena özcan";
            string kullanici5 = "yasin sezer";
            int şifre1 = 1;
            int şifre2 = 2222;
            int şifre3 = 3333;
            int şifre4 = 4444;
            int şifre5 = 5555;





            if (textBox1.Text == kullanici1 && textBox2.Text == şifre1.ToString())
            {
                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
                MessageBox.Show("giriş basarili lütfen bilgileri giriniz ");
            

            }
            else if (textBox1.Text == kullanici2 && textBox2.Text == şifre2.ToString())
            {

                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
                MessageBox.Show("giriş basarili lütfen bilgileri giriniz ");
               
            }

            else if (textBox1.Text == kullanici3 && textBox2.Text == şifre3.ToString())
            {

                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
                MessageBox.Show("giriş basarili lütfen bilgileri giriniz ");
            }
            else if (textBox1.Text == kullanici4 && textBox2.Text == şifre4.ToString())
            {

                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
                MessageBox.Show("giriş basarili lütfen bilgileri giriniz ");
            }

            else if (textBox1.Text == kullanici5 && textBox2.Text == şifre5.ToString())
            {

                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
                MessageBox.Show("giriş basarili lütfen bilgileri giriniz ");
            }

            else
            {
                MessageBox.Show("giriş basarili lütfen bilgileri giriniz ");

            }
        }
    }
}


//private void Form1_Load(object sender, EventArgs e)
//{

//}

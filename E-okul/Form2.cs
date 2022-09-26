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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        int mevcut;
        double ortalama;
        int s1, s2;
        string gecti = "gecti", kaldı = "kaldı";
        
      
        private void button2_Click(object sender, EventArgs e)
        {
            kaydet();
           
        }

      
        private void Form2_Load(object sender, EventArgs e)
        {

            tablo.Columns.Add("İsim", typeof(string));
            tablo.Columns.Add("Soyisim", typeof(string));
            tablo.Columns.Add("1.Sınav", typeof(int));
            tablo.Columns.Add("2.Sınav", typeof(int));
            tablo.Columns.Add("Ortalama", typeof(int));
            tablo.Columns.Add("Durum", typeof(string));

        }
        public void kaydet()
        {
            s1 = Convert.ToInt32(txtsnv1.Text);
            s2 = Convert.ToInt32(txtsnv2.Text);


            if (mevcut != 15)
            {
                ortalama = (s2 + s1) / 2;
                
              

                if(ortalama >= 50)
                {
                    tablo.Rows.Add(txtad.Text, txtsoyad.Text, txtsnv1.Text, txtsnv2.Text, ortalama,gecti);
                    dataGridView1.DataSource = tablo;
                }
                else
                {
                    tablo.Rows.Add(txtad.Text, txtsoyad.Text, txtsnv1.Text, txtsnv2.Text, ortalama, kaldı);
                    dataGridView1.DataSource = tablo;
                }
               

            }
          
            else
            {
                MessageBox.Show("Sınıv mevcudunun üstüne çıkılamaz");
            }
           

        }
    }
}

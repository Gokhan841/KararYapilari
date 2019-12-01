using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElseOrnekleri_2
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
            int sifre = int.Parse(textBox2.Text);

            if (textBox1.Text == "admin")
            {
                if (sifre==123)
                {
                    MessageBox.Show("Giriş Yyapıldı");
                }
                else
                {
                    MessageBox.Show("Hatalı şifre");
                    textBox1.Clear();
                    textBox2.Clear();
                }

            }
            else
                MessageBox.Show("Hatalı Kullanıcı Adı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sifre = Convert.ToInt32(textBox2.Text);
            if(textBox1.Text=="admin" && sifre==123)

            {
                MessageBox.Show("Hoşgeldiniz");
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Bilgileri");
                textBox1.Clear();
                textBox2.Clear();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            string urun = textBox3.Text;

            if(urun=="domates" || urun=="biber" || urun=="patlican")
            {
                MessageBox.Show("Sebze Reyonuna Gidiniz");
            }
            else if (urun=="diş macunu", urun=="parfum", urun=="sampuan")
            {
                MessageBox.Show("Kozmetik Reyonuna Gidiniz");
            }
            else
            {
                MessageBox.Show("Aradığınız Ürün Bulunamadı");
            }
            */
           
            
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(textBox4.Text);
            int s2 = int.Parse(textBox5.Text);
            int ort;
            ort = (s1 + s2) / 2;
            label10.Text = ort.ToString();

            if (ort < 0 || ort > 100)
            {
                MessageBox.Show("Lütfen geçerli sınva sonucu giriniz.");
            }
            else if (0 < ort && ort < 30)
            {
                label11.Text = "FF";
                label11.ForeColor = Color.Red;

            }
            else if (30 <= ort && ort <= 70)
            {
                label11.Text = "CC";
                label11.ForeColor = Color.Yellow;
            }
            else
            {
                label11.Text = "AA";
                label11.BackColor = Color.Green;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}

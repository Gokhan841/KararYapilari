using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ıf_uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "domates" || textBox1.Text == "biber" || textBox1.Text == "patlıcan")
            {
                MessageBox.Show("Sebze Reyonu");
            }
            else if (textBox1.Text == "parfum" || textBox1.Text == "sabun" || textBox1.Text == "deodorant")
            {
                MessageBox.Show("Kozmetik Reyonu");
            }
            else
                MessageBox.Show("Ürün Bulunamadı");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fiyat;
            fiyat = 5;
            int miktar = Convert.ToInt32(textBox2.Text);
            if (miktar < 20)
            {
                label7.Text = (fiyat * miktar - fiyat * miktar * 0.05).ToString();
            }
            if (miktar >= 20 && miktar <= 50)
            {
                label7.Text = ("Tutar:" +(fiyat * miktar - fiyat * miktar * 0.1).ToString());

            }
            if(miktar<=0)
            {
                MessageBox.Show("Lütfen tutar giriniz");
            }
            else
            {
                label7.Text =( "Tutar:" + (fiyat * miktar - fiyat * miktar * 0.2).ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

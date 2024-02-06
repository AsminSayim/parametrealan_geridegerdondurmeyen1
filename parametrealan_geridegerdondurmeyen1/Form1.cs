using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parametrealan_geridegerdondurmeyen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Yazdir(string numara , string ad , string soyad , string telefon)
        {
            //label5.Text = "Numara:" + numara + "\n" + "Ad:" + ad + "\n" + "Soyad:" + soyad + "\n" + "Telefon" + telefon;
            label5.Text = String.Format("Numara:{0}\n Ad:{1}\nSoyad:{2}\nTelefon{3}", numara, ad, soyad, telefon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yazdir(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Kullanıcı adı ve şifre kontrol etme

            if(txtad.Text == "mustafa" && txtsifre.Text == "12345")
            {
                //kullanıcı adı ve şifrenin dogru girilme durumu
                Frmanasayfa fr = new Frmanasayfa();
                fr.Show();
            }
            else if(txtad.Text == "" || txtsifre.Text == "")
            {
                //kullanıcı adı veya şifrenin girilmemesi durumu
                MessageBox.Show("Hatalı giriş yeniden deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //kullanıcı adı veya şifrenin yanlıs girilmesi durumu
                MessageBox.Show("Kullanıcı adı veya şifre hatalı yeniden deneyiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            //sifreyi acik yapma
            txtsifre.UseSystemPasswordChar = false;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //sifreyi kapali yapma
            txtsifre.UseSystemPasswordChar = true;

        }
    }
}

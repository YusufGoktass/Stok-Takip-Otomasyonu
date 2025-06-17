using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class FrmKullaniciGiris : Form
    {
        public FrmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_KullaniciAdi.Text;
            string sifre = Txt_Sifre.Text;
            StokTakipEntities vt = new StokTakipEntities();
            Kullanici girisKullanici = vt.Kullanici.SingleOrDefault(p => p.KullaniciAdi == kullaniciAdi && p.Sifre == sifre);
            if (girisKullanici != null)
            {
               
                if (girisKullanici.YetkiTürü == "Admin")
                {

                    //MessageBox.Show("Admin olarak giriş yaptınız.");

                    
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    
                }
                else if (girisKullanici.YetkiTürü == "Müsteri")
                {
                   
                    //MessageBox.Show("Müşteri olarak giriş yaptınız.");

                   
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                   
                    MessageBox.Show("Geçersiz yetki.");
                }
            }
            else
            {
               
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
            }
        }
    }
}

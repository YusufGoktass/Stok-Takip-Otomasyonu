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
    public partial class MüsteriEkleme : Form
    {
        public MüsteriEkleme()
        {
            InitializeComponent();
        }

        private void MüsteriEkleme_Load(object sender, EventArgs e)
        {

        }
   

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            StokTakipEntities vt = new StokTakipEntities();
            Müsteri aa = new Müsteri();
            aa.TC = txt_Tc.Text;
            aa.Ad = txt_Adi.Text;
            aa.Soyad = txt_soyadi.Text;
            aa.Telefon = txt_telefon.Text;
            aa.Adres = txt_Adres.Text;
            aa.Email = txt_email.Text;

            vt.Müsteri.Add(aa);
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                label9.Text = "Müşteri Eklendi";
            }
            else
            {
                label9.Text = "Hata";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StokTakipEntities vt = new StokTakipEntities();
            string silinecekTC = Convert.ToString(textBox1.Text);
            var silinevekkisi = vt.Müsteri.FirstOrDefault(p => p.TC == silinecekTC);
            vt.Müsteri.Remove(silinevekkisi);
            var sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                label9.Text = "Silme işlemi Başarılı";
            }
            else
            {
                label9.Text = "Silme işlemi Başarısız";
            }
        }
    }
}

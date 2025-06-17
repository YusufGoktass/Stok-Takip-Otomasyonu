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
    public partial class MüsteriBilgileri : Form
    {
        public MüsteriBilgileri()
        {
            InitializeComponent();
        }

        private void MüsteriBilgileri_Load(object sender, EventArgs e)
        {

        }
        

        

        private void button2_Click_1(object sender, EventArgs e)
        {

            StokTakipEntities vt = new StokTakipEntities();
            dataGridView1.DataSource = vt.Müsteri.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StokTakipEntities vt = new StokTakipEntities();
            int güncellenecekID = Convert.ToInt32(textBox1.Text);
            var güncellenecekisi = vt.Müsteri.FirstOrDefault(p => p.ID == güncellenecekID);
            güncellenecekisi.TC = txt_Tc.Text;
            güncellenecekisi.Ad = txt_Adi.Text;
            güncellenecekisi.Soyad = txt_soyadi.Text;
            güncellenecekisi.Telefon = txt_telefon.Text;
            güncellenecekisi.Adres = txt_Adres.Text;
            güncellenecekisi.Email = txt_email.Text;
            int sonuc = vt.SaveChanges();
            if (sonuc > 0)
            {
                label8.Text = "Güncelleme Başarılı";
            }
            else
            {
                label8.Text = "Güncelleme Başarısız !!!";
            }
        }
    }
}

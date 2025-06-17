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
    public partial class UrunEkleme : Form
    {
        public UrunEkleme()
        {
            InitializeComponent();
        }

        private void UrunEkleme_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            StokTakipEntities vt = new StokTakipEntities();
            Urun aa = new Urun();
            aa.BarkodNo = txt_barkodNo.Text;
            aa.UrunAdi = comboBox2.SelectedItem.ToString(); 
            aa.Marka = txt_Marka.Text;
            aa.Kategori = comboBox1.SelectedItem.ToString();
            aa.Stok = txt_Stok.Text;
            aa.SatisFiyati = txt_SatisFiyati.Text;
          
            var urunKontrol = vt.Urun.FirstOrDefault(u => u.UrunAdi == aa.UrunAdi);
            if (urunKontrol != null)
            {
                MessageBox.Show( "Bu isimde bir ürün zaten kayıtlı!");
            }
            else
            {
                vt.Urun.Add(aa);
                var sonuc = vt.SaveChanges();
                if (sonuc > 0)
                {
                    label4.Text = "Ürün Ekleme Başarılı";
                }
                else
                {
                    label4.Text = "Ürün Ekleme Başarısız !!!!";
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            StokTakipEntities vt = new StokTakipEntities();
            string silinecekBarkod = Convert.ToString(txt_SatisBarkodNo.Text);
            var silinecekUrun = vt.Urun.FirstOrDefault(p => p.BarkodNo == silinecekBarkod);
            vt.Urun.Remove(silinecekUrun);
            var snuc = vt.SaveChanges();
            if (snuc > 0)
            {
                label4.Text = "Ürün Başarıyla Silindi";
                txt_SatisBarkodNo.Text = " ";
            }
            else
            {
                label4.Text = "Ürün Silinmedi !!!";
            }
        }

      
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
       

       

       
       

        private void kullanıcıİşlemleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Kullaniciislemleri aa = new Kullaniciislemleri();
            aa.MdiParent = this;
            aa.Show();
        }

       

       

        private void ürünEklemeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UrunEkleme vt = new UrunEkleme();
            vt.MdiParent = this;
            vt.Show();
        }

        private void ürünBilgileriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ÜrünBilgi aa = new ÜrünBilgi();
            aa.MdiParent = this;
            aa.Show();
        }

        private void satışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKullaniciGiris vt = new FrmKullaniciGiris();
            vt.Show();
        }
    }
}

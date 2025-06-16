
namespace Proje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.ürünEklemeToolStripMenuItem,
            this.ürünBilgileriToolStripMenuItem,
            this.satışRaporuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıİşlemleriToolStripMenuItem_Click_1);
            // 
            // ürünEklemeToolStripMenuItem
            // 
            this.ürünEklemeToolStripMenuItem.Name = "ürünEklemeToolStripMenuItem";
            this.ürünEklemeToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.ürünEklemeToolStripMenuItem.Text = "Ürün Ekleme";
            this.ürünEklemeToolStripMenuItem.Click += new System.EventHandler(this.ürünEklemeToolStripMenuItem_Click_1);
            // 
            // ürünBilgileriToolStripMenuItem
            // 
            this.ürünBilgileriToolStripMenuItem.Name = "ürünBilgileriToolStripMenuItem";
            this.ürünBilgileriToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.ürünBilgileriToolStripMenuItem.Text = "Ürün Bilgileri";
            this.ürünBilgileriToolStripMenuItem.Click += new System.EventHandler(this.ürünBilgileriToolStripMenuItem_Click_1);
            // 
            // satışRaporuToolStripMenuItem
            // 
            this.satışRaporuToolStripMenuItem.Name = "satışRaporuToolStripMenuItem";
            this.satışRaporuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.satışRaporuToolStripMenuItem.Text = "Satış Raporu";
            this.satışRaporuToolStripMenuItem.Click += new System.EventHandler(this.satışRaporuToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışRaporuToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}


using Ayısıgı1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace ayisigi_otel
{


   


    public partial class anaform : Form
    {


        private Button btnHoşgeldiniz;
        private Button btnHoşgeldinizz;


        public anaform()
        {
            InitializeComponent();
            btnHosgeldiniz = new Button();
            btnHosgeldiniz.Text = "Hoşgeldiniz Mesajı Göster";
            btnHosgeldiniz.Click += button1_Click;
            //İletişim Butonu (Soyutlama)
            Controls.Add(btnHosgeldiniz);
            //Adres Butonu (Kapsülleme)
            Controls.Add(btnHosgeldinizz);

            //Bu butonlşar Polimorfizm Kullanılarak Oluşturulmuştur.

            // Oda Servisi Butonu
            Button btnOdaServisi = new Button();
            btnOdaServisi.Text = "Oda Servisi";
            btnOdaServisi.Location = new System.Drawing.Point(50, 50);
            btnOdaServisi.Click += BtnOdaServisi_Click;
            
            // Resepsiyon Butonu
            Button btnResepsiyon = new Button();
            btnResepsiyon.Text = "Resepsiyon";
            btnResepsiyon.Location = new System.Drawing.Point(50, 100);
            btnResepsiyon.Click += BtnResepsiyon_Click;
           
            // Temizlik Hizmeti Butonu
            Button btnTemizlik = new Button();
            btnTemizlik.Text = "Temizlik Hizmeti";
            btnTemizlik.Location = new System.Drawing.Point(50, 150);
            btnTemizlik.Click += BtnTemizlik_Click;
            





        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaform));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.oopButton = new System.Windows.Forms.Button();
            this.btnHosgeldiniz = new System.Windows.Forms.Button();
            this.btnHosgeldinizz = new System.Windows.Forms.Button();
            this.BtnOdaServisi = new System.Windows.Forms.Button();
            this.BtnResepsiyon = new System.Windows.Forms.Button();
            this.BtnTemizlik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 97);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yeni Müşteri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(323, 97);
            this.button3.TabIndex = 2;
            this.button3.Text = "Odalar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 421);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(323, 97);
            this.button4.TabIndex = 3;
            this.button4.Text = "Müşteri Listesi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(35, 555);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(323, 97);
            this.button5.TabIndex = 1;
            this.button5.Text = "Yeni Müşteri";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(35, 292);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(323, 97);
            this.button6.TabIndex = 2;
            this.button6.Text = "Odalar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(35, 421);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(323, 97);
            this.button7.TabIndex = 3;
            this.button7.Text = "Müşteri Listesi";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(484, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(967, 131);
            this.label1.TabIndex = 5;
            this.label1.Text = "AY IŞIĞI OTEL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(438, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1572, 400);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 65);
            this.label3.TabIndex = 7;
            this.label3.Text = "HAKKIMIZDA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ayisigi_otel.Properties.Resources.city_36593_1280;
            this.pictureBox2.Location = new System.Drawing.Point(995, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(425, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ayisigi_otel.Properties.Resources.full_moon_308007_1280;
            this.pictureBox1.Location = new System.Drawing.Point(575, 577);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1216, 1277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // oopButton
            // 
            this.oopButton.Location = new System.Drawing.Point(0, 0);
            this.oopButton.Name = "oopButton";
            this.oopButton.Size = new System.Drawing.Size(75, 23);
            this.oopButton.TabIndex = 0;
            this.oopButton.Click += new System.EventHandler(this.oopButton_Click);
            // 
            // btnHosgeldiniz
            // 
            this.btnHosgeldiniz.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHosgeldiniz.Location = new System.Drawing.Point(35, 798);
            this.btnHosgeldiniz.Name = "btnHosgeldiniz";
            this.btnHosgeldiniz.Size = new System.Drawing.Size(197, 57);
            this.btnHosgeldiniz.TabIndex = 9;
            this.btnHosgeldiniz.Text = "İletişim";
            this.btnHosgeldiniz.UseVisualStyleBackColor = true;
            this.btnHosgeldiniz.Click += new System.EventHandler(this.btnHosgeldiniz_Click);
            // 
            // btnHosgeldinizz
            // 
            this.btnHosgeldinizz.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHosgeldinizz.Location = new System.Drawing.Point(268, 798);
            this.btnHosgeldinizz.Name = "btnHosgeldinizz";
            this.btnHosgeldinizz.Size = new System.Drawing.Size(200, 57);
            this.btnHosgeldinizz.TabIndex = 10;
            this.btnHosgeldinizz.Text = "Adres";
            this.btnHosgeldinizz.UseVisualStyleBackColor = true;
            this.btnHosgeldinizz.Click += new System.EventHandler(this.btnHosgeldinizz_Click);
            // 
            // BtnOdaServisi
            // 
            this.BtnOdaServisi.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOdaServisi.Location = new System.Drawing.Point(1243, 749);
            this.BtnOdaServisi.Name = "BtnOdaServisi";
            this.BtnOdaServisi.Size = new System.Drawing.Size(152, 38);
            this.BtnOdaServisi.TabIndex = 11;
            this.BtnOdaServisi.Text = "Oda Servisi";
            this.BtnOdaServisi.UseVisualStyleBackColor = true;
            this.BtnOdaServisi.Click += new System.EventHandler(this.BtnOdaServisi_Click);
            // 
            // BtnResepsiyon
            // 
            this.BtnResepsiyon.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnResepsiyon.Location = new System.Drawing.Point(1243, 793);
            this.BtnResepsiyon.Name = "BtnResepsiyon";
            this.BtnResepsiyon.Size = new System.Drawing.Size(152, 36);
            this.BtnResepsiyon.TabIndex = 12;
            this.BtnResepsiyon.Text = "Resepsiyon";
            this.BtnResepsiyon.UseVisualStyleBackColor = true;
            this.BtnResepsiyon.Click += new System.EventHandler(this.BtnResepsiyon_Click);
            // 
            // BtnTemizlik
            // 
            this.BtnTemizlik.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTemizlik.Location = new System.Drawing.Point(1243, 835);
            this.BtnTemizlik.Name = "BtnTemizlik";
            this.BtnTemizlik.Size = new System.Drawing.Size(152, 32);
            this.BtnTemizlik.TabIndex = 13;
            this.BtnTemizlik.Text = "Temizlik ";
            this.BtnTemizlik.UseVisualStyleBackColor = true;
            this.BtnTemizlik.Click += new System.EventHandler(this.BtnTemizlik_Click);
            // 
            // anaform
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1607, 1018);
            this.Controls.Add(this.BtnTemizlik);
            this.Controls.Add(this.BtnResepsiyon);
            this.Controls.Add(this.BtnOdaServisi);
            this.Controls.Add(this.btnHosgeldinizz);
            this.Controls.Add(this.btnHosgeldiniz);
            this.Controls.Add(this.oopButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "anaform";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.anaform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //buton1e bastığımızda admin giriş sayfasına gönderiyor bizi//
        private void button1_Click(object sender, EventArgs e)
        {

            frmadmingiris fr = new frmadmingiris();
            fr.Show();
            this.Hide();

        }

        //buton2e bastığımızda yeni müşteri sayfasına gönderiyor bizi//
        private void button2_Click(object sender, EventArgs e)
        {
            YeniMusterı fr = new YeniMusterı();
            fr.Show();
            this.Hide();
        }

        //buton1e bastığımızda odalar sayfasına gönderiyor bizi//
        private void button3_Click(object sender, EventArgs e)
        {

            //odalar fr = new odalar();
            //fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        //buton1e bastığımızda müşteri bilgi sayfasına gönderiyor bizi
        private void button4_Click_1(object sender, EventArgs e)
        {
            MusteriBilgi fr = new MusteriBilgi();
            fr.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 20;
            pictureBox1.Height = 20;

        }

        //buton1e bastığımızda odaSecim sayfasına gönderiyor bizi
        private void button3_Click_1(object sender, EventArgs e)
        {
            odasecim fr = new odasecim();
            fr.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void anaform_Load(object sender, EventArgs e)
        {

        }

        private void oopButton_Click(object sender, EventArgs e)
        {

        }

        //buton1e bastığımızda iletişim bilgilerini gösteriyor
        private void btnHosgeldiniz_Click(object sender, EventArgs e)
        {
            OtelMesajı mesaj = new HoşgeldinizMesajı();
            mesaj.MesajGoster();
        }


        //buton1e bastığımızda Adres bilgilerini gösteriyor
        private void btnHosgeldinizz_Click(object sender, EventArgs e)
        {
           
            HosgeldinizMesajı mesaj = new HosgeldinizMesajı();
            mesaj.Mesaj = "ADRES: Korucuk Mah. Akçe Sokak No:16 Avrupa/İSTANBUL"; // Kapsülleme ile mesajı değiştirme
            mesaj.MesajGoster();
        }


        //buton1e bastığımızda oda servisi bilgilerini gösteriyor
        private void BtnOdaServisi_Click(object sender, EventArgs e)
        {
            Hizmet hizmet = new OdaServisi();
            hizmet.HizmetBilgisi();
        }

        //buton1e bastığımızda resepsiyon bilgilerini gösteriyor
        private void BtnResepsiyon_Click(object sender, EventArgs e)
        {
            Hizmet hizmet = new Resepsiyon();
            hizmet.HizmetBilgisi();
        }

        //buton1e bastığımızda temizlik hizmeti bilgilerini gösteriyor
        private void BtnTemizlik_Click(object sender, EventArgs e)
        {
            Hizmet hizmet = new TemizlikHizmeti();
            hizmet.HizmetBilgisi();
        }


        // Üst Sınıf (Base Class)
        public abstract class Hizmet
        {
            public abstract void HizmetBilgisi();
        }

        // Oda Servisi Sınıfı
        public class OdaServisi : Hizmet
        {
            public override void HizmetBilgisi()
            {
                MessageBox.Show("Oda servisi hizmetimiz 24 saat boyunca hizmetinizdedir.", "Oda Servisi");
            }
        }

        // Resepsiyon Sınıfı
        public class Resepsiyon : Hizmet
        {
            public override void HizmetBilgisi()
            {
                MessageBox.Show("Resepsiyon 7/24 hizmetinizdedir.", "Resepsiyon");
            }
        }

        // Temizlik Hizmeti Sınıfı
        public class TemizlikHizmeti : Hizmet
        {
            public override void HizmetBilgisi()
            {
                MessageBox.Show("Temizlik hizmetimiz sabah 9'dan akşam 5'e kadar hizmet vermektedir.", "Temizlik Hizmeti");
            }
        }
    }
}

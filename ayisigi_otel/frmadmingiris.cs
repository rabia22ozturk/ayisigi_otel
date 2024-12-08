using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayisigi_otel
{
    public partial class frmadmingiris : Form
    {

        // Veritabanı bağlantısı için AyotelEntity nesnesi oluşturuluyor.
        AyotelEntity db = new AyotelEntity();




        // Formun yapıcı (constructor) metodu. Form yüklendiğinde çalışır.
        public frmadmingiris()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde tetiklenen olay.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // label2 bileşenine tıklandığında tetiklenen olay (boş bırakılmış).
        private void label2_Click(object sender, EventArgs e)
        {

        }
        // label2 bileşenine ikinci kez tıklandığında tetiklenen olay (boş bırakılmış).
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        // "button1" isimli butona tıklandığında çalışır.
        // Yeni bir anaform penceresi açar ve mevcut giriş formunu gizler.
        private void button1_Click(object sender, EventArgs e)
        {
            anaform fr = new anaform();
            fr.Show();
            this.Hide();
        }

        // txtsifre adlı TextBox'a tıklandığında tetiklenen olay (boş bırakılmış).
        private void txtsifre_Click(object sender, EventArgs e)
        {

        }

        // txtsifre adlı TextBox'a tıklandığında tetiklenen olay (boş bırakılmış).
        private void txtadı_Click(object sender, EventArgs e)
        {

        }
        // "btngirisyap" butonuna tıklandığında çalışır.
        // Kullanıcı adı ve şifre bilgilerini kontrol eder.
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            // Veritabanında kullanıcı adı ve şifre eşleşmesini kontrol eder.
            var kullaniciSayi = db.Kullanicilar.Where(x => x.KullaniciAdi == txtadı.Text.ToString() && x.Sifre == txtsifre.Text.ToString()).Count();

            // Eşleşme varsa giriş başarılı.
            if (kullaniciSayi > 0)
            {

                // kullanıcı girişini kaydet

                // Kullanıcı girişini kaydetmek için buraya kod ekleyebilirsiniz.

                // Anaform penceresini aç ve giriş formunu gizle.

                anaform anaform = new anaform();
                anaform.Show();
                this.Hide();
            }
            else
            {
                // Giriş bilgileri hatalıysa hata mesajı göster.
                MessageBox.Show("Kullanıcı bulunamadı Giriş bilgilerini kontrol ediniz", "Hata!");
            }
        }

        // label1 bileşenine tıklandığında tetiklenen olay (boş bırakılmış).
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

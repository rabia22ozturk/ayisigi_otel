using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using ayisigi_otel;


namespace Ayısıgı1
{

    public partial class YeniMusterı : Form
    {
        // Veritabanı işlemleri için AyotelEntity nesnesi.
        AyotelEntity db = new AyotelEntity();
        // Seçilen oda numarasını tutan değişken.
        int selectedOdaNo = 0;
        // Yapıcı (constructor) metod. Form başlatıldığında çalışır.
        public YeniMusterı()
        {
            InitializeComponent();
        }


        // Oda 101 butonuna tıklandığında çalışır ve oda numarasını yazdırır.
        private void btn101_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "101";
        }
        // Oda 102 butonuna tıklandığında çalışır ve oda numarasını yazdırır.
        private void btn102_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "102";
        }
        // Oda 103 butonuna tıklandığında çalışır ve oda numarasını yazdırır.
        private void btn103_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "103";
        }
        // Oda 104 butonuna tıklandığında çalışır ve oda numarasını yazdırır.
        private void btn104_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "104";
        }
        // Oda 105 butonuna tıklandığında çalışır ve oda numarasını yazdırır.
        private void btn105_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "105";

        }
        // Oda 106 butonuna tıklandığında çalışır ve oda numarasını yazdırır.
        private void btn106_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "106";

        }
        // Oda 107 butonuna tıklandığında çalışır ve oda numarasını yazdırır.
        private void btn107_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "107";

        }
        // Oda 108 butonuna tıklandığında çalışır ve oda numarasını yazdırır.
        private void btn108_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "108";

        }
        // Oda 109 butonuna tıklandığında çalışır ve oda numarasını yazdırır.
        private void btn109_Click(object sender, EventArgs e)
        {
            TxtOdano.Text = "109";

        }
        // Dolu odaların renginin kırmızı olduğunu belirten mesajı gösterir.
        private void btndolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }
        // Boş odaların renginin yeşil olduğunu belirten mesajı gösterir.
        private void btnbos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");

        }

        // Çıkış tarihi değiştiğinde kalan gün sayısını ve ücreti hesaplar.
        private void DtpCıkısTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            // Giris ve çıkış tarihleri arasındaki fark hesaplanır.
            DateTime kucuktarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime buyuktarih = Convert.ToDateTime(DtpCıkısTarihi.Text);

            // Tarihler arasındaki farkı alır ve toplam gün sayısını gösterir.
            TimeSpan sonuc = buyuktarih - kucuktarih;

            label11.Text = sonuc.TotalDays.ToString();
            // Gün sayısını 50 ile çarparak ücret hesaplanır.
            ucret = Convert.ToInt32(label11.Text) * 50;
            Txtucret.Text = ucret.ToString();
            //label11 tasarımda var ama görünmez yaptım daha güzel gözüksün diye visible//

        }
        // Kaydet butonuna tıklanarak yeni müşteri kaydını veritabanına ekler.

        private void Kaydet_Click(object sender, EventArgs e)
        {

            // Yeni müşteri nesnesi oluşturulur ve formdaki verilerle doldurulur.
            Musteriler musteri = new Musteriler();

            musteri.Adi = TxtAdi.Text.ToString();
            musteri.Soyadi = TxtSoyadi.Text.ToString();
            musteri.TC = TxtTc.Text.ToString();
            musteri.OdaNo = TxtOdano.Text.ToString();
            musteri.Mail = TxtMail.Text.ToString();
            musteri.Telefon = MskTxtTel.Text.ToString();
            musteri.Ucret = Convert.ToInt32(Txtucret.Text.ToString());
            musteri.Cinsiyet = ComoboxCinsiyet.Text.ToString();
            musteri.GirisTarihi = DtpGirisTarihi.Value;
            musteri.CikisTarihi = DtpCıkısTarihi.Value;

            // Yeni müşteri veritabanına kaydedilir.
            db.Musteriler.Add(musteri);
            db.SaveChanges();

            // Oda durumu kaydedilir.
            OdaDurumlari odaDurumlari = new OdaDurumlari();
            odaDurumlari.OdaId = Convert.ToInt32(TxtOdano.Text.ToString());
            odaDurumlari.MusteriId = musteri.MusteriId;
            // Oda durumu veritabanına kaydedilir.
            db.OdaDurumlari.Add(odaDurumlari);
            db.SaveChanges();

        }



        // ComboBox'ta seçim değiştiğinde tetiklenen olay (şu an için boş bırakılmış).

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Ana forma geri dönmek için kullanılan buton.
        private void button1_Click(object sender, EventArgs e)
        {
            anaform fr = new anaform();
            fr.Show();
            this.Hide();
        }

        // Yeni müşteri formu yüklendiğinde çalışacak metod.
        private void YeniMusterı_Load(object sender, EventArgs e)
        {
            // Veritabanından odalar listelenir.
            var odalar = db.Odalar.ToList();
            // Her oda için bir buton oluşturuluyor.
            foreach (var oda in odalar)
            {
                Button button = new Button();
                button.Text = oda.OdaNo.ToString();  // Butonun metni oda numarası olacak.
                button.Height = 68;
                button.Width = 100;

                // Odanın doluluk durumu kontrol edilir.
                bool odaDolu = false;
                var odaDurum = db.OdaDurumlari.Where(x => x.OdaId == oda.Id).Count();
                if (odaDurum > 0)
                {
                    odaDolu = true;    // Oda dolu ise kırmızı yapılır.
                    button.BackColor = Color.Red;
                }
                else
                {
                    odaDolu = false;   // Oda boş ise yeşil yapılır.
                    button.BackColor = Color.Green;
                }
                // Butona tıklanarak odanın seçilmesi sağlanır.
                button.Click += (s, args) =>
                {
                    if (odaDolu)
                    {
                        // Oda dolu ise hata mesajı gösterilir.
                        MessageBox.Show("Dolu oda seçilemez baka bir oda seçiniz", "Hata!");
                    }
                    else
                    {
                        // Oda boş ise seçilen oda numarası yazdırılır.
                        selectedOdaNo = oda.Id;
                        TxtOdano.Text = selectedOdaNo.ToString();
                    }
                };


                // Oluşturulan buton, flowLayoutPanel1 içine eklenir.

                flowLayoutPanel1.Controls.Add(button);
            }


        }
        // PictureBox tıklanma olayı (şu an boş).
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}






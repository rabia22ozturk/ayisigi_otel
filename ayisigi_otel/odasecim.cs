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
{  // odasecim formu, odaların listelenmesi ve seçilmesi işlemini yapar.
    public partial class odasecim : Form
    {
        // Veritabanı bağlantısı için AyotelEntity nesnesi oluşturuluyor.
        AyotelEntity db = new AyotelEntity();


        // Yapıcı (constructor) metod. Form başlatıldığında çalışır
        public odasecim()
        {
            InitializeComponent();
        }
        // Form yüklendiğinde çalışacak olay metodudur.
        private void odasecim_Load(object sender, EventArgs e)
        {
            // Veritabanından tüm odaları liste olarak alır.
            var odalar = db.Odalar.ToList();
            // Odaların bilgilerini tutacak liste oluşturuluyor.
            var odaList = new List<OdalarListesi>();
            // Tüm odalar üzerinde döngü yaparak bilgileri doldurur.
            foreach (var oda in odalar)
            {
                // Her bir oda için OdalarListesi nesnesi oluşturuluyor.
                OdalarListesi odaListItem = new OdalarListesi();   
                odaListItem.OdaAdi = oda.OdaNo.ToString();          // Oda numarasını alır.
                odaListItem.OdaResim = "";                          // Resim alanı boş bırakılmış.
                odaListItem.OdaOzellik =  "Özellik 1, 2, 3";        // Sabit bir özellik metni atanıyor.


                // Oda doluluk durumunu kontrol eder.
                var odaDurum = db.OdaDurumlari.Where(x => x.OdaId == oda.Id).Count();

                // Eğer odanın durumu varsa (doluluk bilgisi varsa), oda dolu kabul edilir.
                if (odaDurum > 0)
                {
                    odaListItem.OdaDoluMu = true;
                }
                else
                {
                    odaListItem.OdaDoluMu = false;
                }

                // Oluşturulan oda nesnesini listeye ekler.
                odaList.Add(odaListItem);
            }

            // Oluşturulan oda listesindeki her oda için bir buton oluşturur.
            foreach (var odaItem in odaList)
            {
                Button button = new Button();                // Yeni bir buton oluşturulur.
                button.Text = odaItem.OdaAdi.ToString();     // Butonun metni oda adı olur.
                button.Height = 68;                           // Butonun yüksekliği ayarlanır.
                button.Width = 100;                            // Butonun genişliği ayarlanır.

                // Oda doluysa butonun arka plan rengi kırmızı yapılır.
                if (odaItem.OdaDoluMu)
                {
                    button.BackColor = Color.Red;
                }
                else // Oda boşsa butonun arka plan rengi yeşil yapılır.
                {
                    button.BackColor = Color.Green;
                }

                // Butona tıklandığında çalışacak olay tanımlanır.
                button.Click += (s, args) =>
                {
                    // Yeni bir odaEkrani formu açılır ve seçilen oda bilgisi gönderilir.
                    odaEkrani fr = new odaEkrani(odaItem);
                    fr.Show();    // Yeni oda ekranını göster.
                    this.Hide();  // Mevcut odasecim formunu gizle.
                };

                // Oluşturulan buton, flowLayoutPanel1 içine eklenir.
                flowLayoutPanel1.Controls.Add(button);
            }
        }
    }
}

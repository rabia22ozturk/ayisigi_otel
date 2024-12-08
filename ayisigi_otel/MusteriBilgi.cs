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
    public partial class MusteriBilgi : Form
    {
        // Veritabanı bağlantısı için AyotelEntity nesnesi oluşturuluyor.
        AyotelEntity db = new AyotelEntity();

        // Formun yapıcı (constructor) metodu. Form yüklendiğinde çalışır.
        public MusteriBilgi()
        {
            InitializeComponent();
        }
        // listView1 bileşeninde bir öğe seçildiğinde tetiklenen olay (boş bırakılmış).
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Form yüklendiğinde tetiklenen olay (boş bırakılmış).
        private void MusteriBilgi_Load(object sender, EventArgs e)
        {

        }
        // "button1" butonuna tıklandığında çalışır.
        // Veritabanındaki müşteri bilgilerini getirip DataGridView'e yükler.
        private void button1_Click(object sender, EventArgs e)
        {
            // Veritabanından müşteri bilgilerini liste olarak alır.
            var musteriler = db.Musteriler.ToList();

            // Alınan müşteri bilgilerini dataGridView1'e veri kaynağı olarak atar.
            dataGridView1.DataSource = musteriler;
        }

        // "button2" butonuna tıklandığında çalışır.
        // Ana formu açar ve mevcut formu gizler.
        private void button2_Click(object sender, EventArgs e)
        {
            anaform fr = new anaform();  // Yeni bir anaform nesnesi oluşturuluyor.
            fr.Show();                   // Anaformu göster.
            this.Hide();                 // Mevcut müşteri bilgi formunu gizle.
        }
    }
}

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
    // odaEkrani formu, belirli bir odanın bilgilerini görüntülemek için kullanılır.
    public partial class odaEkrani : Form
    {

        // OdalarListesi türünden bir nesne tanımlanıyor.
        // Bu nesne, odanın bilgilerini taşır.
        private OdalarListesi odalarListesi;

        // Yapıcı (constructor) metod. Form oluşturulurken bir OdalarListesi nesnesi alır.
        public odaEkrani(OdalarListesi oda)
        {
            InitializeComponent(); // Form bileşenlerini başlatır.

            // Parametre olarak gelen oda nesnesini sınıf değişkenine atar.
            odalarListesi = oda;

            // label1'e odanın adını yazar.
            label1.Text = oda.OdaAdi;

            // Eğer oda doluysa label4'e "Dolu", boşsa "Boş" yazar.
            if (oda.OdaDoluMu)
            {
                label4.Text = "Dolu";

            }
            else
            {
                label4.Text = "Boş";

            }

            // label2'ye odanın özelliklerini yazar.
            label2.Text = oda.OdaOzellik;
            
        }

        // Form yüklendiğinde tetiklenen olay (boş bırakılmış).
        private void oda101_Load(object sender, EventArgs e)
        {

        }
    }
}

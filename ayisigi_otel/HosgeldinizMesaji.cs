using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayisigi_otel
{
    public class HosgeldinizMesajı : OtelMesaji
    {
        // Kapsülleme ile özel bir alan (private field)
        private string _mesaj;

        // Public özellik (property) ile kontrollü erişim
        public string Mesaj
        {
            get { return _mesaj; }
            set { _mesaj = value; }
        }

        // Yapıcı metot ile varsayılan mesaj atanabilir
        public HosgeldinizMesajı()
        {
            _mesaj = "Hoşgeldiniz!";
        }

        public override void MesajGoster()
        {
            MessageBox.Show(_mesaj);
        }
    }
}

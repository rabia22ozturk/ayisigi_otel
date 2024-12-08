using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayisigi_otel
{
    public class HoşgeldinizMesajı : OtelMesajı
    {
        // Soyut metodu implement ediyoruz
        public override void MesajGoster()
        {
            MessageBox.Show("E-posta: ayisigi@gmail.com \n\nGSM: 0555 555 55 55");
        }
    }
}

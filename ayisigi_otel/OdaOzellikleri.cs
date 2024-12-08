using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ayisigi_otel
{
    
    public class OdalarListesi : OdaOzellikleri
    {
        public string OdaAdi { get; set; }
        public string OdaResim { get; set; }
    }
    public class OdaOzellikleri
    {
        public bool OdaDoluMu { get; set; }
        public string OdaOzellik { get; set; }

    }
}

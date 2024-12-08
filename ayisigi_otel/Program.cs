using Ayısıgı1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayisigi_otel
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //new kısmına hangi sayfayı yazarsak çalıştırdığımızda ilk o sayfa çalışıyor //
            Application.Run (new anaform());
        }
    }
}

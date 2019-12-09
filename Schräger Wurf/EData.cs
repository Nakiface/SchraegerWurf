using System;
using System.Windows.Forms;

namespace Schräger_Wurf
{
    class EData
    {
        public double eV0 { get; set; }
        public double eWinkel { get; set; }
        public double eZeit { get; set; }
        public bool ifZeit { get; set; }

        public EData (string eV0, string eWinkel, string eZeit, bool ifZeit)
        {
            try
            {
                this.eV0 = Convert.ToDouble(eV0);
                this.eWinkel = Convert.ToDouble(eWinkel);
                this.ifZeit = ifZeit;
                if (ifZeit)
                {
                    this.eZeit = Convert.ToDouble(eZeit);
                }                           
            }
            catch
            {
                MessageBox.Show("Bitte keinen text eingeben und nur Zahlen");
                return;
            }
        }
    }
}

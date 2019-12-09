using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schräger_Wurf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            EData eData = new EData(ev0textBox.Text, eaWinkeltextBox.Text, eZeittextBox.Text, eZeitcheckBox.Checked);
            AData aData = new AData(eData);
            awurfweitetextBox.Text = aData.aWurfweite;
            amaxhoehetextBox.Text = aData.aMaxHoehe;
            azeittextBox.Text = aData.aZeit;
            if (eData.ifZeit)
            {
                ageschwindigkeittextBox.Text = aData.aGeschwindigkeit;
                ahoehetextBox.Text = aData.aHoehe;
                aentfehrnungtextBox.Text = aData.aEntfehrnung;
            }

        }
    }

    class AData
    {
        public string aWurfweite { get; set; }
        public string aMaxHoehe { get; set; }
        public string aZeit { get; set; }
        public string aGeschwindigkeit { get; set; }
        public string aEntfehrnung { get; set; }
        public string aHoehe { get; set; }

        public AData(EData eData)
        {
            Rechnen rechnen = new Rechnen();
            this.aWurfweite = rechnen.WurfWeite(eData.eV0, eData.eWinkel).ToString();
            this.aMaxHoehe = rechnen.MaxHoehe(eData.eV0, eData.eWinkel).ToString();
            this.aZeit = rechnen.Zeit(eData.eV0, eData.eWinkel).ToString();
            this.aGeschwindigkeit = rechnen.Geschwindigkeit(eData.eV0, eData.eWinkel, eData.eZeit).ToString();
            this.aEntfehrnung = rechnen.Entfehrnung(eData.eV0, eData.eWinkel, eData.eZeit).ToString();
            this.aHoehe = rechnen.Hoehe(eData.eV0, eData.eWinkel, eData.eZeit).ToString();
        }
    }

    class Rechnen 
    {
        public double WurfWeite (int v0, int winkel)
        {
            return 5;
        }

        public double MaxHoehe (int v0, int winkel)
        {
            return 5;
        }

        public double Zeit (int v0, int winkel)
        {
            return 5.53230;
        }

        public double Entfehrnung(int v0, int winkel, int zeit)
        {
            return 5;
        }

        public double Geschwindigkeit(int v0, int winkel, int zeit)
        {
            return 5;
        }

        public double Hoehe(int v0, int winkel, int zeit)
        {
            return 5;
        }
    }

    class EData
    {
        public int eV0 { get; set; }
        public int eWinkel { get; set; }
        public int eZeit { get; set; }
        public bool ifZeit { get; set; }

        public EData (string eV0, string eWinkel, string eZeit, bool ifZeit)
        {
            try
            {
                this.eV0 = Convert.ToInt32(eV0);
                this.eWinkel = Convert.ToInt32(eWinkel);
                this.ifZeit = ifZeit;
                if (ifZeit)
                {
                    this.eZeit = Convert.ToInt32(eZeit);
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

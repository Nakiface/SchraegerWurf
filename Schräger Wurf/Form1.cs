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
}

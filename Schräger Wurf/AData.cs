namespace Schräger_Wurf
{
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
}

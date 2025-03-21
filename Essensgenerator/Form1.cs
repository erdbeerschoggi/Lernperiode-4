using static smthNew.Gericht;

namespace smthNew
{

    public partial class Gericht : Form
    {
        private List<string> benutzerEingaben = new List<string>();
        private string dateiPfad = "eingaben.txt";
        private Dictionary<string, List<string>> gerichte = new Dictionary<string, List<string>>();

        public Gericht()
        {
            InitializeComponent();
            InitialisiereGerichte();
        }



        private void InitialisiereGerichte()
        {
            gerichte = new Dictionary<string, List<string>>()
            {
                { "Asiatisch-Vegan-Scharf", new List<string> { "Veganer Tofu-Curry", "Scharfes Gem�sewok" } },
                { "Europ�isch-Vegetarisch-30 min", new List<string> { "Pasta mit Tomatensauce", "Griechischer Salat" } },
                { "Amerikanisch-Egal-Fleisch-Egal", new List<string> { "Burger mit Pommes", "BBQ-Ribs" } }
                
            };
        }


        private void button2_Click(object sender, EventArgs e)
        {
            benutzerEingaben.Clear();

            // Abfrage Kulinarische Richtung
            if (checkboxAsiatisch.Checked)
                benutzerEingaben.Add("Asiatisch");
            if (checkboxAmerikanisch.Checked)
                benutzerEingaben.Add("Amerikanisch");
            if (checkboxEurop�isch.Checked)
                benutzerEingaben.Add("Europ�isch");
            if (checkboxAfrikanisch.Checked)
                benutzerEingaben.Add("Afrikanisch");
            if (checkboxIndisch.Checked)
                benutzerEingaben.Add("Indisch");
            if (checkboxKRegal.Checked)
                benutzerEingaben.Add("Egal");

            // Abfrage Optionen
            if (checkboxFleisch.Checked)
                benutzerEingaben.Add("Fleisch");
            if (checkboxVegetarisch.Checked)
                benutzerEingaben.Add("Vegetarisch");
            if (checkboxVegan.Checked)
                benutzerEingaben.Add("Vegan");

            // Abfrage Zeit
            if (checkboxFr�hst�ck.Checked)
                benutzerEingaben.Add("Fr�hst�ck");
            if (checkboxMittagessen.Checked)
                benutzerEingaben.Add("Mittagessen");
            if (checkboxAbendessen.Checked)
                benutzerEingaben.Add("Abendessen");

            // Abfrage Hauptzutat
            if (checkboxReis.Checked)
                benutzerEingaben.Add("Reis");
            if (checkboxKartoffeln.Checked)
                benutzerEingaben.Add("Kartoffeln");
            if (checkboxGem�se.Checked)
                benutzerEingaben.Add("Gem�se");
            if (checkboxPasta.Checked)
                benutzerEingaben.Add("Pasta");
            if (checkboxAnderes.Checked)
                benutzerEingaben.Add("Anderes");

            // Abfrage Art
            if (checkboxGebacken.Checked)
                benutzerEingaben.Add("Gebacken");
            if (checkboxGebraten.Checked)
                benutzerEingaben.Add("Gebraten");
            if (checkboxGekocht.Checked)
                benutzerEingaben.Add("Gekocht");
            if (checkboxRaw.Checked)
                benutzerEingaben.Add("Raw");

            //Abfrage Geschmack
            if (checkboxScharf.Checked)
                benutzerEingaben.Add("Scharf");
            if (checkboxS�ss.Checked)
                benutzerEingaben.Add("S�ss");
            if (checkboxSauer.Checked)
                benutzerEingaben.Add("Sauer");
            if (checkboxEgal.Checked)
                benutzerEingaben.Add("Egal");

            // Abfrage Zubereitungszeit
            if (checkbox15min.Checked)
                benutzerEingaben.Add("15 min");
            if (checkbox30min.Checked)
                benutzerEingaben.Add("30 min");
            if (checkbox45min.Checked)
                benutzerEingaben.Add("45 min");
            if (checkbox1h.Checked)
                benutzerEingaben.Add(">1h");



            File.WriteAllLines(dateiPfad, benutzerEingaben);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            if (File.Exists(dateiPfad))
            {

                var gespeicherteEingaben = File.ReadAllLines(dateiPfad);
                foreach (var eingabe in gespeicherteEingaben)
                {
                    if (eingabe == "Asiatisch") checkboxAsiatisch.Checked = true;
                    if (eingabe == "Amerikanisch") checkboxAmerikanisch.Checked = true;
                    if (eingabe == "Europ�isch") checkboxEurop�isch.Checked = true;
                    if (eingabe == "Afrikanisch") checkboxAfrikanisch.Checked = true;
                    if (eingabe == "Indisch") checkboxIndisch.Checked = true;
                    if (eingabe == "Egal") checkboxKRegal.Checked = true;

                    if (eingabe == "Fleisch") checkboxFleisch.Checked = true;
                    if (eingabe == "Vegetarisch") checkboxVegetarisch.Checked = true;
                    if (eingabe == "Vegan") checkboxVegan.Checked = true;

                    if (eingabe == "Fr�hst�ck") checkboxFr�hst�ck.Checked = true;
                    if (eingabe == "Mittagessen") checkboxMittagessen.Checked = true;
                    if (eingabe == "Abendessen") checkboxAbendessen.Checked = true;

                    if (eingabe == "Reis") checkboxReis.Checked = true;
                    if (eingabe == "Kartoffeln") checkboxKartoffeln.Checked = true;
                    if (eingabe == "Gem�se") checkboxGem�se.Checked = true;
                    if (eingabe == "Pasta") checkboxPasta.Checked = true;
                    if (eingabe == "Anderes") checkboxAnderes.Checked = true;

                    if (eingabe == "Gebacken") checkboxGebacken.Checked = true;
                    if (eingabe == "Gebraten") checkboxGebraten.Checked = true;
                    if (eingabe == "Gekocht") checkboxGekocht.Checked = true;
                    if (eingabe == "Raw") checkboxRaw.Checked = true;

                    if (eingabe == "Scharf") checkboxScharf.Checked = true;
                    if (eingabe == "S�ss") checkboxS�ss.Checked = true;
                    if (eingabe == "Sauer") checkboxSauer.Checked = true;
                    if (eingabe == "Egal") checkboxEgal.Checked = true;

                    if (eingabe == "15 min") checkbox15min.Checked = true;
                    if (eingabe == "30 min") checkbox30min.Checked = true;
                    if (eingabe == "45 min") checkbox45min.Checked = true;
                    if (eingabe == ">1h") checkbox1h.Checked = true;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            benutzerEingaben.Clear();

            
            List<string> reihenfolge = new List<string> { "Asiatisch", "Amerikanisch", "Europ�isch", "Afrikanisch", "Indisch", "Egal",
                                                  "Fleisch", "Vegetarisch", "Vegan",
                                                  "Fr�hst�ck", "Mittagessen", "Abendessen",
                                                  "Reis", "Kartoffeln", "Gem�se", "Pasta", "Anderes",
                                                  "Gebacken", "Gebraten", "Gekocht", "Raw",
                                                  "Scharf", "S�ss", "Sauer", "Egal",
                                                  "15 min", "30 min", "45 min", ">1h" };

            
            foreach (string kategorie in reihenfolge)
            {
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is CheckBox cb && cb.Checked && cb.Text == kategorie)
                    {
                        benutzerEingaben.Add(kategorie);
                    }
                }
            }

            
            string key = string.Join("-", benutzerEingaben);

            
            MessageBox.Show($"Generierter Schl�ssel: {key}", "Debugging", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string vorschlag = "Kein passendes Gericht gefunden.";

            
            if (gerichte.ContainsKey(key))
            {
                vorschlag = string.Join(", ", gerichte[key]);
            }
            else
            {
                
                foreach (var gerichtKey in gerichte.Keys)
                {
                    if (key.Contains(gerichtKey))
                    {
                        vorschlag = string.Join(", ", gerichte[gerichtKey]);
                        break;
                    }
                }
            }

            
            MessageBox.Show($"Vorschlag: {vorschlag}", "Gerichtsvorschlag", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

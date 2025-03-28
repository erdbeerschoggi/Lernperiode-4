using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

        // Initialisiert die Gerichtsdaten
        private void InitialisiereGerichte()
        {
            gerichte = new Dictionary<string, List<string>>()
            {
                { "Asiatisch-Vegan-Reis", new List<string> { "Veganer Sushi-Roll", "Gebratener Reis mit Gem�se" } },
                { "Europ�isch-Fleisch-S�ss", new List<string> { "Schweinebraten mit �pfeln", "Lammbraten mit Honigglasur" } },
                { "Amerikanisch-Vegetarisch-Fr�hst�ck", new List<string> { "Veganer Pancake-Turm", "Veggie-Bagel mit Avocado" } },
                { "Indisch-Fleisch-S�ss", new List<string> { "S��es Butter-H�hnchen", "Lamm-Curry mit Pflaumen" } },
                { "Afrikanisch-Vegan-Reis", new List<string> { "Jollof Rice mit Gem�se", "Afrikanischer Reis-Eintopf" } },
                { "Fr�hst�ck-Indisch-S�ss", new List<string> { "Indisches Joghurt-Parfait", "S��e Lassi mit Mangop�ree" } },
                { "Mittagessen-Asiatisch-Fleisch", new List<string> { "H�hnchen Teriyaki mit Reis", "Gebratene Ente mit Reis und Gem�se" } },
                { "Abendessen-Europ�isch-Scharf", new List<string> { "Spaghetti Arrabbiata", "Scharfe Wurst mit Paprika" } },
                { "Vegetarisch-Indisch-Scharf", new List<string> { "Scharfe Linsen-Dal", "Gew�rztes Gem�se-Curry" } },
                { "Amerikanisch-Fleisch-Egal", new List<string> { "Pulled Pork Sandwich", "Gegrillte Rindersteaks" } },
                { "Asiatisch-Vegetarisch-Reis", new List<string> { "Veganer Nasi Goreng", "Tofu mit Reis und Gem�se" } },
                { "Europ�isch-Vegan-S�ss", new List<string> { "Veganer Apfelstrudel", "Obstsalat mit Vanillesauce" } },
                { "Afrikanisch-Fleisch-Scharf", new List<string> { "Scharfer Afrikanischer Eintopf mit Fleisch", "Piri-Piri-H�hnchen" } },
                { "Indisch-Vegan-Scharf", new List<string> { "Tofu-Curry mit Chili", "Scharfes Chana Masala" } },
                { "Fr�hst�ck-Vegan-Herzhaft", new List<string> { "Veganer Avocado-Toast", "Veganer Chia-Pudding mit Tomaten" } },
                { "Mittagessen-Indisch-S�ss", new List<string> { "Mango-Lassi", "S��es Kichererbsen-Curry" } },
                { "Abendessen-Amerikanisch-Vegan", new List<string> { "Veganer Mac 'n' Cheese", "Veganer BBQ-Burger" } },
                { "Europ�isch-Vegetarisch-S�ss", new List<string> { "Zuckerr�ben-Salat mit Ziegenk�se", "Schokoladen-Mousse" } },
                { "Afrikanisch-Vegan-S�ss", new List<string> { "S��e Mango-Desserts", "Gebackene Bananen mit Honig" } },
                { "Asiatisch-Fleisch-Scharf", new List<string> { "Scharfes Rindfleisch mit Gem�se", "Chili-H�hnchen" } },
                { "Indisch-Vegetarisch-Reis", new List<string> { "Biryani mit Gem�se", "Reis mit Gew�rzen und Linsen" } },
                { "Fr�hst�ck-Europ�isch-Egal", new List<string> { "Veggie-Omelette", "Frisches Roggenbrot mit K�se" } },
                { "Mittagessen-Europ�isch-Scharf", new List<string> { "Spaghetti Arrabbiata", "W�rzige Kartoffelsuppe" } }

            };
        }

        // Speichert die Auswahl des Benutzers
        private void button2_Click(object sender, EventArgs e)
        {
            benutzerEingaben.Clear();
            foreach (Control ctrl in Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    benutzerEingaben.Add(cb.Text);
                }
            }
            File.WriteAllLines(dateiPfad, benutzerEingaben);
        }

        // L�dt die gespeicherten Eingaben beim Starten der Anwendung
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(dateiPfad))
            {
                var gespeicherteEingaben = File.ReadAllLines(dateiPfad);
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is CheckBox cb && gespeicherteEingaben.Contains(cb.Text))
                    {
                        cb.Checked = true;
                    }
                }
            }
        }

        // Verarbeitet die Eingaben und schl�gt Gerichte vor
        private void button1_Click(object sender, EventArgs e)
        {
            benutzerEingaben.Clear();

            // Kategorienliste in der gew�nschten Reihenfolge
            List<string> kategorieReihenfolge = new List<string> {
                "Asiatisch", "Amerikanisch", "Europ�isch", "Afrikanisch", "Indisch",
                "Fleisch", "Vegetarisch", "Vegan",
                "Fr�hst�ck", "Mittagessen", "Abendessen",
                "Reis", "Kartoffeln", "Gem�se", "Pasta", "Anderes",
                "Scharf", "S�ss", "Sauer", "Egal"
            };

            // Eingaben des Benutzers in die benutzerEingaben-Liste �bernehmen
            foreach (string kategorie in kategorieReihenfolge)
            {
                foreach (Control ctrl in Controls)
                {
                    if (ctrl is CheckBox cb && cb.Checked && cb.Text == kategorie)
                    {
                        benutzerEingaben.Add(kategorie);
                    }
                }
            }

            // Generieren des Schl�ssels und �berpr�fung
            string key = string.Join("-", benutzerEingaben);
            MessageBox.Show($"Generierter Schl�ssel: {key}", "Debugging", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Wenn ein Gericht gefunden wird
            string vorschlag = "Kein passendes Gericht gefunden.";

            if (gerichte.ContainsKey(key))
            {
                vorschlag = string.Join(" und ", gerichte[key]);
            }
            else
            {
                // Wenn kein exakter Treffer vorhanden ist, versuche �hnliche Kategorien zu finden
                foreach (var gerichtKey in gerichte.Keys)
                {
                    if (key.Contains(gerichtKey))
                    {
                        vorschlag = string.Join(" und ", gerichte[gerichtKey]);
                        break;
                    }
                }
            }

            // Anzeige des Gerichtvorschlags
            MessageBox.Show($"Vorschlag: {vorschlag}", "Gerichtsvorschlag", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Setzt alle CheckBoxen zur�ck
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }
        }
    }
}
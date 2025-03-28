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
                { "Asiatisch-Vegan-Reis", new List<string> { "Veganer Sushi-Roll", "Gebratener Reis mit Gemüse" } },
                { "Europäisch-Fleisch-Süss", new List<string> { "Schweinebraten mit Äpfeln", "Lammbraten mit Honigglasur" } },
                { "Amerikanisch-Vegetarisch-Frühstück", new List<string> { "Veganer Pancake-Turm", "Veggie-Bagel mit Avocado" } },
                { "Indisch-Fleisch-Süss", new List<string> { "Süßes Butter-Hähnchen", "Lamm-Curry mit Pflaumen" } },
                { "Afrikanisch-Vegan-Reis", new List<string> { "Jollof Rice mit Gemüse", "Afrikanischer Reis-Eintopf" } },
                { "Frühstück-Indisch-Süss", new List<string> { "Indisches Joghurt-Parfait", "Süße Lassi mit Mangopüree" } },
                { "Mittagessen-Asiatisch-Fleisch", new List<string> { "Hähnchen Teriyaki mit Reis", "Gebratene Ente mit Reis und Gemüse" } },
                { "Abendessen-Europäisch-Scharf", new List<string> { "Spaghetti Arrabbiata", "Scharfe Wurst mit Paprika" } },
                { "Vegetarisch-Indisch-Scharf", new List<string> { "Scharfe Linsen-Dal", "Gewürztes Gemüse-Curry" } },
                { "Amerikanisch-Fleisch-Egal", new List<string> { "Pulled Pork Sandwich", "Gegrillte Rindersteaks" } },
                { "Asiatisch-Vegetarisch-Reis", new List<string> { "Veganer Nasi Goreng", "Tofu mit Reis und Gemüse" } },
                { "Europäisch-Vegan-Süss", new List<string> { "Veganer Apfelstrudel", "Obstsalat mit Vanillesauce" } },
                { "Afrikanisch-Fleisch-Scharf", new List<string> { "Scharfer Afrikanischer Eintopf mit Fleisch", "Piri-Piri-Hähnchen" } },
                { "Indisch-Vegan-Scharf", new List<string> { "Tofu-Curry mit Chili", "Scharfes Chana Masala" } },
                { "Frühstück-Vegan-Herzhaft", new List<string> { "Veganer Avocado-Toast", "Veganer Chia-Pudding mit Tomaten" } },
                { "Mittagessen-Indisch-Süss", new List<string> { "Mango-Lassi", "Süßes Kichererbsen-Curry" } },
                { "Abendessen-Amerikanisch-Vegan", new List<string> { "Veganer Mac 'n' Cheese", "Veganer BBQ-Burger" } },
                { "Europäisch-Vegetarisch-Süss", new List<string> { "Zuckerrüben-Salat mit Ziegenkäse", "Schokoladen-Mousse" } },
                { "Afrikanisch-Vegan-Süss", new List<string> { "Süße Mango-Desserts", "Gebackene Bananen mit Honig" } },
                { "Asiatisch-Fleisch-Scharf", new List<string> { "Scharfes Rindfleisch mit Gemüse", "Chili-Hähnchen" } },
                { "Indisch-Vegetarisch-Reis", new List<string> { "Biryani mit Gemüse", "Reis mit Gewürzen und Linsen" } },
                { "Frühstück-Europäisch-Egal", new List<string> { "Veggie-Omelette", "Frisches Roggenbrot mit Käse" } },
                { "Mittagessen-Europäisch-Scharf", new List<string> { "Spaghetti Arrabbiata", "Würzige Kartoffelsuppe" } }

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

        // Lädt die gespeicherten Eingaben beim Starten der Anwendung
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

        // Verarbeitet die Eingaben und schlägt Gerichte vor
        private void button1_Click(object sender, EventArgs e)
        {
            benutzerEingaben.Clear();

            // Kategorienliste in der gewünschten Reihenfolge
            List<string> kategorieReihenfolge = new List<string> {
                "Asiatisch", "Amerikanisch", "Europäisch", "Afrikanisch", "Indisch",
                "Fleisch", "Vegetarisch", "Vegan",
                "Frühstück", "Mittagessen", "Abendessen",
                "Reis", "Kartoffeln", "Gemüse", "Pasta", "Anderes",
                "Scharf", "Süss", "Sauer", "Egal"
            };

            // Eingaben des Benutzers in die benutzerEingaben-Liste übernehmen
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

            // Generieren des Schlüssels und Überprüfung
            string key = string.Join("-", benutzerEingaben);
            MessageBox.Show($"Generierter Schlüssel: {key}", "Debugging", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Wenn ein Gericht gefunden wird
            string vorschlag = "Kein passendes Gericht gefunden.";

            if (gerichte.ContainsKey(key))
            {
                vorschlag = string.Join(" und ", gerichte[key]);
            }
            else
            {
                // Wenn kein exakter Treffer vorhanden ist, versuche ähnliche Kategorien zu finden
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

        // Setzt alle CheckBoxen zurück
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
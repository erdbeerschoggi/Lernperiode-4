namespace smthNew
{
    public partial class Form1 : Form
    {
        private List<string> benutzerEingaben = new List<string>();
        private string dateiPfad = "eingaben.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            benutzerEingaben.Clear();

            // Abfrage Kulinarische Richtung
            if (checkboxAsiatisch.Checked)
                benutzerEingaben.Add("Asiatisch");
            if (checkboxAmerikanisch.Checked)
                benutzerEingaben.Add("Amerikanisch");
            if (checkboxEuropäisch.Checked)
                benutzerEingaben.Add("Europäisch");
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
            if (checkboxFrühstück.Checked)
                benutzerEingaben.Add("Frühstück");
            if (checkboxMittagessen.Checked)
                benutzerEingaben.Add("Mittagessen");
            if (checkboxAbendessen.Checked)
                benutzerEingaben.Add("Abendessen");

            // Abfrage Hauptzutat
            if (checkboxReis.Checked)
                benutzerEingaben.Add("Reis");
            if (checkboxKartoffeln.Checked)
                benutzerEingaben.Add("Kartoffeln");
            if (checkboxGemüse.Checked)
                benutzerEingaben.Add("Gemüse");
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
            if (checkboxSüss.Checked)
                benutzerEingaben.Add("Süss");
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


            new Form2().Show();
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
                    if (eingabe == "Europäisch") checkboxEuropäisch.Checked = true;
                    if (eingabe == "Afrikanisch") checkboxAfrikanisch.Checked = true;
                    if (eingabe == "Indisch") checkboxIndisch.Checked = true;
                    if (eingabe == "Egal") checkboxKRegal.Checked = true;

                    if (eingabe == "Fleisch") checkboxFleisch.Checked = true;
                    if (eingabe == "Vegetarisch") checkboxVegetarisch.Checked = true;
                    if (eingabe == "Vegan") checkboxVegan.Checked = true;

                    if (eingabe == "Frühstück") checkboxFrühstück.Checked = true;
                    if (eingabe == "Mittagessen") checkboxMittagessen.Checked = true;
                    if (eingabe == "Abendessen") checkboxAbendessen.Checked = true;

                    if (eingabe == "Reis") checkboxReis.Checked = true;
                    if (eingabe == "Kartoffeln") checkboxKartoffeln.Checked = true;
                    if (eingabe == "Gemüse") checkboxGemüse.Checked = true;
                    if (eingabe == "Pasta") checkboxPasta.Checked = true;
                    if (eingabe == "Anderes") checkboxAnderes.Checked = true;

                    if (eingabe == "Gebacken") checkboxGebacken.Checked = true;
                    if (eingabe == "Gebraten") checkboxGebraten.Checked = true;
                    if (eingabe == "Gekocht") checkboxGekocht.Checked = true;
                    if (eingabe == "Raw") checkboxRaw.Checked = true;

                    if (eingabe == "Scharf") checkboxScharf.Checked = true;
                    if (eingabe == "Süss") checkboxSüss.Checked = true;
                    if (eingabe == "Sauer") checkboxSauer.Checked = true;
                    if (eingabe == "Egal") checkboxEgal.Checked = true;

                    if (eingabe == "15 min") checkbox15min.Checked = true;
                    if (eingabe == "30 min") checkbox30min.Checked = true;
                    if (eingabe == "45 min") checkbox45min.Checked = true;
                    if (eingabe == ">1h") checkbox1h.Checked = true;

                }
            }
        }
    }
}

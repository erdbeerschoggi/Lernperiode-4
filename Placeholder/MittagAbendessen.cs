using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EssensGenerator
{
    public partial class MittagAbendessen : Form
    {
        public MittagAbendessen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (auswahl == "Vegetarisch" == "Mittagessen" == "") vorschlag = "Gemüsepfanne?";
            else if (auswahl == "Fleisch") vorschlag = "Steak?";
            else if (auswahl == "Vegan") vorschlag = "Avocado-Salat!";
        }
    }
}

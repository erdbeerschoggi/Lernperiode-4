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
    public partial class Zutaten : Form
    {
        public Zutaten()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonZU2.Tag == null || buttonZU2.Tag.ToString() == "false")
            {
                buttonZU2.Tag = "true";
            }
            else
            {
                buttonZU2.Tag = "false";
            }

            new MittagAbendessen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MittagAbendessen().Show();
        }
    }
}

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
    public partial class Allergy : Form
    {
        public Allergy()
        {
            InitializeComponent();
        }

        private void Allergy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonA1.Tag == null || buttonA1.Tag.ToString() == "false")
            {
                buttonA1.Tag = "true";
            }
            else
            {
                buttonA1.Tag = "false";
            }
            new Option().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Option().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

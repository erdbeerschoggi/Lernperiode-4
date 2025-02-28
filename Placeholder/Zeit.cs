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
    public partial class Zeit : Form
    {
        public Zeit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonZ2.Tag == null || buttonZ2.Tag.ToString() == "false")
            {
                buttonZ2.Tag = "true";
            }
            else
            {
                buttonZ2.Tag = "false";
            }

            new FrühstückOptionen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonZ1.Tag == null || buttonZ1.Tag.ToString() == "false")
            {
                buttonZ1.Tag = "true";
            }
            else
            {
                buttonZ1.Tag = "false";
            }
            
            new Zutaten().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (buttonZ3.Tag == null || buttonZ3.Tag.ToString() == "false")
            {
                buttonZ3.Tag = "true";
            }
            else
            {
                buttonZ3.Tag = "false";
            }

            new Zutaten().Show();
        }
    }
}

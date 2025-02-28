namespace EssensGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonF1.Tag == null || buttonF1.Tag.ToString() == "false")
            {
                buttonF1.Tag = "true";
            }
            else
            {
                buttonF1.Tag = "false";
            }
            new Allergy().Show();
        }
    }
}

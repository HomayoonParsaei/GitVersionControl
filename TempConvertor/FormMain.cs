namespace GitVersionControl
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            textBoxTempC.Text = ((float.Parse(textBoxTempF.Text) - 32) * 5 / 9).ToString();
            labelTempInF.Text = "Temperature °F";
        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            textBoxTempF.Text = ((float.Parse(textBoxTempC.Text) * 9 / 5) + 32).ToString();
            labelTempInF.Text = "Temperature °F";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTempF.Text = string.Empty;
            textBoxTempC.Text = string.Empty;
            labelTempInF.Text = "Temperature °F";

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            labelTempInF.Text = "Temperature °K";
            textBoxTempF.Text = (float.Parse(textBoxTempC.Text) +273.15).ToString();
            
        }
    }
}


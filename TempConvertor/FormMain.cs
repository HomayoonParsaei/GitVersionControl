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
        }

        private void buttonCtoF_Click(object sender, EventArgs e)
        {
            textBoxTempF.Text = ((float.Parse(textBoxTempC.Text) * 9 / 5) + 32).ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTempF.Text = string.Empty;
            textBoxTempC.Text = string.Empty;
            
        }
    }
}


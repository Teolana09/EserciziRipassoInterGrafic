namespace EserciziRipassoInterGrafic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Inversione_Click(object sender, EventArgs e)
        {
            double GradiCelsiuse = double.Parse(GradiC.Text);
            

            double Conversione = (GradiCelsiuse * (1.8) ) + 32;
            RisultatoC.Text = Conversione.ToString();
        }

        private void InverisioneF_Click(object sender, EventArgs e)
        {
            double GradiFarenite = double.Parse(GradiF.Text);

            double Conversione = (GradiFarenite - 32) / 1.8 ;
            RisultatoF.Text = Conversione.ToString();
        }
    }
}

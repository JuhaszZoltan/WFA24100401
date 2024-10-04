namespace WFA24100401
{
    public partial class FrmIntervallum : Form
    {
        public FrmIntervallum()
        {
            InitializeComponent();

            btnMegallapit.Click += BtnMegallapit_Click;
        }

        private void BtnMegallapit_Click(object? sender, EventArgs e)
        {
            lblSzoveg.Text =
                nudAlso.Value <= nudSzam.Value && nudSzam.Value <= nudFelso.Value
                ? "a sz�m benne van aintervallumban"
                : "a sz�m nincs benne az intervallumban";
        }
    }
}

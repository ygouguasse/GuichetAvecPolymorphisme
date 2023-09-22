using guichet.controleurs;
using guichet.vues;

namespace guichet
{
    public partial class FormConnexion : Form
    {
        ControleurGuichet _controleurGuichet = new ControleurGuichet();

        public FormConnexion()
        {
            InitializeComponent();
            InitialiserChamp();
        }

        private void InitialiserChamp()
        {
            txtNip.Text = "";
            numNumeroCarte.Value = numNumeroCarte.Minimum;
        }

        private void AfficherMenu()
        {
            FormMenu formMenu = new FormMenu(_controleurGuichet);
            formMenu.Show(this);
            Hide();
            InitialiserChamp();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            AfficherMenu();
        }
    }
}
using guichet.controleurs;
using guichet.vues;

namespace guichet
{
    public partial class FormConnexion : Form
    {
        ControleurConnexion _controleurConnexion = new ControleurConnexion();

        public FormConnexion()
        {
            InitializeComponent();
            InitialiserChamps();
            AbonnerEvenements();
        }

        private void AbonnerEvenements()
        {
            _controleurConnexion.ConnexionInvalide += ControleurGuichet_ConnexionInvalide;
            _controleurConnexion.ConnexionValide += ControleurGuichet_ConnexionValide;
        }

        private void ControleurGuichet_ConnexionValide(object? sender, EventArgs e)
        {
            AfficherMenu();
        }

        private void ControleurGuichet_ConnexionInvalide(object? sender, EventArgs e)
        {
            AfficherMessageIdentifiantsInvalides();
        }

        private void InitialiserChamps()
        {
            txtNip.Text = "";
            txtNumeroCarte.Text = "";
        }

        private void AfficherMenu()
        {
            FormMenu formMenu = new FormMenu(_controleurConnexion.UtilisateurConnecte);
            formMenu.Show(this);
            Hide();
            InitialiserChamps();
        }

        private void AfficherMessageIdentifiantsInvalides()
        {
            MessageBox.Show("Identifiants invalides.");
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            int numeroCarte = Convert.ToInt32(txtNumeroCarte.Text);
            int nip = Convert.ToInt32(txtNip.Text);
            _controleurConnexion.Connecter(numeroCarte, nip);
        }
    }
}
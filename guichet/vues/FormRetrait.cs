using guichet.controleurs;
using guichet.modeles;
using guichet.modeles.comptes;

namespace guichet.vues
{
    public partial class FormRetrait : Form
    {
        private ControleurRetrait _controleurRetrait;

        public FormRetrait(Utilisateur utilisateur)
        {
            InitializeComponent();
            _controleurRetrait = new ControleurRetrait(utilisateur);
            AbonnerEvenements();
        }

        private void AbonnerEvenements()
        {
            _controleurRetrait.Utilisateur.CompteCheque.RetraitEffectue += CompteCourant_RetraitEffectue;
            _controleurRetrait.Utilisateur.CompteCheque.RetraitErreur += CompteCourant_RetraitErreur;
        }

        private void FormRetrait_FormClosed(object sender, FormClosedEventArgs e)
        {
            DesabonnerEvenements();
        }

        private void DesabonnerEvenements()
        {
            _controleurRetrait.Utilisateur.CompteCheque.RetraitEffectue -= CompteCourant_RetraitEffectue;
            _controleurRetrait.Utilisateur.CompteCheque.RetraitErreur -= CompteCourant_RetraitErreur;
        }

        private void CompteCourant_RetraitErreur(object? sender, MessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void CompteCourant_RetraitEffectue(object? sender, TransactionEventArgs e)
        {
            MessageBox.Show("Veuillez prendre votre argent!");
            Close();
        }

        private void Retirer(decimal montant)
        {
            _controleurRetrait.Retirer(montant);
        }

        private void btnRetraitAutre_Click(object sender, EventArgs e)
        {
            Retirer(numRetraitAutre.Value);
        }

        private void btnRetrait20_Click(object sender, EventArgs e)
        {
            Retirer(20);
        }

        private void btnRetrait40_Click(object sender, EventArgs e)
        {
            Retirer(40);
        }

        private void btnRetrait60_Click(object sender, EventArgs e)
        {
            Retirer(60);
        }

        private void btnRetrait80_Click(object sender, EventArgs e)
        {
            Retirer(80);
        }

        private void btnRetrait100_Click(object sender, EventArgs e)
        {
            Retirer(100);
        }

        private void btnRetrait200_Click(object sender, EventArgs e)
        {
            Retirer(200);
        }
    }
}

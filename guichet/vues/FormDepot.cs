using guichet.controleurs;
using guichet.modeles;
using guichet.modeles.comptes;

namespace guichet.vues
{
    public partial class FormDepot : Form
    {
        private ControleurDepot _controleurDepot;

        public FormDepot(Utilisateur utilisateur)
        {
            InitializeComponent();
            _controleurDepot = new ControleurDepot(utilisateur);
            InitialiserChamps();
            AbonnerEvenements();
        }

        private void AbonnerEvenements()
        {

            foreach (Compte compte in _controleurDepot.Utilisateur.Comptes)
            {
                compte.DepotEffectue += Compte_DepotEffectue; 
                compte.DepotErreur += Compte_DepotErreur;
            }


            //_controleurDepot.Utilisateur.CompteCheque.DepotEffectue += Compte_DepotEffectue;
           // _controleurDepot.Utilisateur.CompteCheque.DepotErreur += Compte_DepotErreur;

           // if (_controleurDepot.Utilisateur.CompteEpargne is null) { return; }

           // _controleurDepot.Utilisateur.CompteEpargne.DepotEffectue += Compte_DepotEffectue;
          //  _controleurDepot.Utilisateur.CompteEpargne.DepotErreur += Compte_DepotErreur;
        }

        private void FormDepot_FormClosed(object sender, FormClosedEventArgs e)
        {
            DesabonnerEvenements();
        }

        private void DesabonnerEvenements()
        {
            // Si on ne se désabonne pas, ces évènements seront appelés même après que la Form
            // ait été Close();.


            foreach (Compte compte in _controleurDepot.Utilisateur.Comptes)
            {
                compte.DepotEffectue -= Compte_DepotEffectue;
                compte.DepotErreur -= Compte_DepotErreur;
            }



        /*    _controleurDepot.Utilisateur.CompteCheque.DepotEffectue -= Compte_DepotEffectue;
            _controleurDepot.Utilisateur.CompteCheque.DepotErreur -= Compte_DepotErreur;

            if (_controleurDepot.Utilisateur.CompteEpargne is null) { return; }

            _controleurDepot.Utilisateur.CompteEpargne.DepotEffectue -= Compte_DepotEffectue;
            _controleurDepot.Utilisateur.CompteEpargne.DepotErreur -= Compte_DepotErreur;*/
        }

        private void Compte_DepotErreur(object? sender, MessageEventArgs e)
        {
            MessageBox.Show(e.Message);

        }

        private void Compte_DepotEffectue(object? sender, TransactionEventArgs e)
        {
            MessageBox.Show($"Vous avez déposé {e.Transaction.Montant.ToString("C")} avec succès.");
            Close();
        }

        private void InitialiserChamps()
        {
            /*  rdoCheque.Checked = _controleurDepot.CompteSelectionne == modeles.comptes.TypeCompte.CompteCheque;
              rdoEpargne.Checked = _controleurDepot.CompteSelectionne == modeles.comptes.TypeCompte.CompteEpargne;
              numMontant.Value = 0;

              if (_controleurDepot.Utilisateur.CompteEpargne is null)
              {
                  rdoEpargne.Enabled = false;
              }*/
            foreach (Compte item in _controleurDepot.Utilisateur.Comptes)
            {
                listBox1.Items.Add(item);

            }

        }

        private void btnDeposer_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex!=-1)
            {
                Compte compte = (Compte)listBox1.SelectedItem;

                if (compte != null)
                {

                    _controleurDepot.SelectionnerCompte(compte);

                    _controleurDepot.Deposer(numMontant.Value);

                    return;

                    

                }


            }

          //  _controleurDepot.Deposer(numMontant.Value);
        }

        private void rdoCheque_CheckedChanged(object sender, EventArgs e)
        {
           /* if (rdoCheque.Checked)
            {
                _controleurDepot.SelectionnerCompteCheque();
            }*/
        }

        private void rdoEpargne_CheckedChanged(object sender, EventArgs e)
        {
           /* if (rdoEpargne.Checked)
            {
                _controleurDepot.SelectionnerCompteEpargne();
            }*/
        }

        private void FormDepot_Load(object sender, EventArgs e)
        {

        }
    }
}

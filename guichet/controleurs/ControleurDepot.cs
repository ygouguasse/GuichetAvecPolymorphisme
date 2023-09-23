using guichet.modeles;
using guichet.modeles.comptes;

namespace guichet.controleurs
{
    public class ControleurDepot
    {
        public Utilisateur Utilisateur { get; private set; }
        public TypeCompte CompteSelectionne { get; private set; }

        public ControleurDepot(Utilisateur utilisateur)
        {
            Utilisateur = utilisateur;
            CompteSelectionne = TypeCompte.CompteCheque;
        }

        public void SelectionnerCompteCheque()
        {
            CompteSelectionne = TypeCompte.CompteCheque;
        }

        public void SelectionnerCompteEpargne()
        {
            CompteSelectionne = TypeCompte.CompteEpargne;
        }

        public void Deposer(decimal montant)
        {
            if (CompteSelectionne == TypeCompte.CompteCheque)
            {
                Utilisateur.CompteCheque.Deposer(montant);
            }
            else if (CompteSelectionne == TypeCompte.CompteEpargne)
            {
                // On ne peut pas sélectionner le compte épargne si l'utilisateur connecté n'en a pas.
                // Donc Utilisateur.CompteEpargne ne devrait jamais être null ici.
                Utilisateur.CompteEpargne.Deposer(montant);
            }
        }
    }
}

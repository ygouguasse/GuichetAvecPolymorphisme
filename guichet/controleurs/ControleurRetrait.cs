using guichet.modeles;

namespace guichet.controleurs
{
    public class ControleurRetrait
    {
        public Utilisateur Utilisateur { get; private set; }

        public ControleurRetrait(Utilisateur utilisateur)
        {
            Utilisateur = utilisateur;
        }

        public void Retirer(decimal montant)
        {
            Utilisateur.CompteCheque.Retirer(montant);
        }
    }
}

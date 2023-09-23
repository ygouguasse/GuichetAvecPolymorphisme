using guichet.modeles;

namespace guichet.controleurs
{
    public class ControleurMenu
    {
        public Utilisateur Utilisateur { get; private set; }

        public ControleurMenu(Utilisateur utilisateur)
        {
            Utilisateur = utilisateur;
        }
    }
}

using guichet.modeles;

namespace guichet.controleurs
{
    public class ControleurConnexion
    {
        private List<Utilisateur> _utilisateurs = new List<Utilisateur>();

        public Utilisateur? UtilisateurConnecte { get; private set; }

        public event EventHandler? ConnexionValide;
        public event EventHandler? ConnexionInvalide;

        public ControleurConnexion()
        {
            CreerUtilisateurs();
            AbonnerEvenements();
        }

        private void CreerUtilisateurs()
        {
            _utilisateurs.Add(new Utilisateur(12345, 54321, 1000M, 1000M));
            _utilisateurs.Add(new Utilisateur(11111, 11111, 1111M, 0M));
            _utilisateurs.Add(new Utilisateur(22222, 22222, 1000M));
        }

        private void AbonnerEvenements()
        {
            foreach (Utilisateur utilisateur in _utilisateurs)
            {
                utilisateur.ConnexionInvalide += Utilisateur_ConnexionInvalide;
                utilisateur.ConnexionValide += Utilisateur_ConnexionValide;
            }
        }

        private void Utilisateur_ConnexionValide(object? sender, EventArgs e)
        {
            UtilisateurConnecte = sender as Utilisateur;
            ConnexionValide?.Invoke(this, EventArgs.Empty);
        }

        private void Utilisateur_ConnexionInvalide(object? sender, EventArgs e)
        {
            UtilisateurConnecte = null;
            ConnexionInvalide?.Invoke(this, EventArgs.Empty);
        }

        public void Connecter(int numeroCarte, int nip)
        {
            Utilisateur? utilisateur = ObtenirUtilisateur(numeroCarte);

            if (utilisateur is null)
            {
                ConnexionInvalide?.Invoke(this, EventArgs.Empty);
                return;
            }

            utilisateur?.Connecter(nip);
        }

        private Utilisateur? ObtenirUtilisateur(int numeroCarte)
        {
            foreach (Utilisateur utilisateur in _utilisateurs)
            {
                if (utilisateur.NumeroCarte == numeroCarte)
                {
                    return utilisateur;
                }
            }

            return null;
        }
    }
}

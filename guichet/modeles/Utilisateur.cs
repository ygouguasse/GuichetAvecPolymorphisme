using guichet.modeles.comptes;

namespace guichet.modeles
{
    public class Utilisateur
    {
        private int _nip;

        public int NumeroCarte { get; private set; }
        public CompteCheque CompteCheque { get; private set; }
        public CompteEpargne? CompteEpargne { get; private set; }
        public List<Compte> Comptes { get; private set; }=new List<Compte>();

        public event EventHandler? ConnexionInvalide;
        public event EventHandler? ConnexionValide;

        public Utilisateur(int numeroCarte, int nip, decimal montantCompteCheque)
        {
            NumeroCarte = numeroCarte;
            _nip = nip;
            Comptes.Add(new CompteCheque(montantCompteCheque));
           // CompteCheque = new CompteCheque(montantCompteCheque);
        }

        public Utilisateur(int numeroCarte, int nip, decimal montantCompteCheque, decimal montantCompteEpargne)
        {
            NumeroCarte = numeroCarte;
            _nip = nip;
             Comptes.Add(new CompteCheque(montantCompteCheque));
            Comptes.Add(new CompteEpargne(montantCompteEpargne));

           // CompteCheque = new CompteCheque(montantCompteCheque);
           // CompteEpargne = new CompteEpargne(montantCompteEpargne);
        }

        public void Connecter(int nip)
        {
            if (_nip == nip)
            {
                ConnexionValide?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                ConnexionInvalide?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

using guichet.modeles.transactions;

namespace guichet.modeles.comptes
{
    public class CompteCheque : Compte
    {
        protected static decimal MaxDepotParJour = 2000;
        protected static decimal MaxRetraitParJour = 1000;
        protected static decimal MaxRetraitDUnCoup = 500;

        public CompteCheque(decimal solde)
            : base(solde)
        { }

        public override void Deposer(decimal montant)
        {
            List<Transaction> transactions = ObtenirTransactions(TypeTransaction.Depot, DateTime.Today);
            decimal totalTransaction = ObtenirTotalTransactions(transactions);

            if (totalTransaction + montant > MaxDepotParJour)
            {
                InvoquerDepotErreur("Vous ne pouvez pas déposer plus de " + MaxDepotParJour.ToString("C") + " par jour.");
                return;
            }

            Transaction transaction = AjouterTransaction(TypeTransaction.Depot, montant);
            Solde += montant;
            InvoquerDepotEffectue(transaction);
        }

        public override void Retirer(decimal montant)
        {
            List<Transaction> transactions = ObtenirTransactions(TypeTransaction.Retrait, DateTime.Today);
            decimal totalTransaction = ObtenirTotalTransactions(transactions);

            if (totalTransaction + montant > MaxRetraitParJour)
            {
                InvoquerRetraitErreur("Vous ne pouvez pas retirer plus de " + MaxRetraitParJour.ToString("C") + " par jour.");
                return;
            }
            if (montant > MaxRetraitDUnCoup)
            {
                InvoquerRetraitErreur("Vous ne pouvez pas retirer plus de " + MaxRetraitDUnCoup.ToString("C") + " en une seule transaction.");
                return;
            }
            if (montant % 20 != 0)
            {
                InvoquerRetraitErreur("Le montant du retrait doit être un multiple de 20.");
                return;
            }
            if (montant <= 0)
            {
                InvoquerRetraitErreur("Le montant du retrait doit être supérieur à 0.");
                return;
            }

            Transaction transaction = AjouterTransaction(TypeTransaction.Retrait, montant);
            Solde -= montant;
            InvoquerRetraitEffectue(transaction);
        }


        public override string? ToString()
        {
            return "Compte cheque, Votre solde : " + Solde.ToString();
        }
    }
}

using guichet.modeles.transactions;

namespace guichet.modeles.comptes
{
    public class CompteEpargne : Compte
    {
        protected static decimal MaxDepotParJour = 5000;

        public CompteEpargne(decimal solde)
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
    }
}

using guichet.modeles.transactions;

namespace guichet.modeles.comptes
{
    public abstract class Compte
    {
        public decimal Solde { get; protected set; }
        public List<Transaction> Transactions { get; private set; }

        public event EventHandler<TransactionEventArgs>? DepotEffectue;
        public event EventHandler<MessageEventArgs>? DepotErreur;
        public event EventHandler<TransactionEventArgs>? RetraitEffectue;
        public event EventHandler<MessageEventArgs>? RetraitErreur;

        public Compte()
        {
            Solde = 0M;
            Transactions = new List<Transaction>();
        }

        public Compte(decimal solde)
        {
            Solde = solde;
            Transactions = new List<Transaction>();
        }

        protected List<Transaction> ObtenirTransactions(TypeTransaction typeTransaction, DateTime date)
        {
            List<Transaction> transactions = new List<Transaction>();
            
            foreach (var transaction in Transactions)
            {
                if (transaction.Date == date &&
                    transaction.Type == typeTransaction)
                {
                    transactions.Add(transaction);
                }
            }

            return transactions;
        }

        protected decimal ObtenirTotalTransactions(List<Transaction> transactions)
        {
            decimal total = 0;

            foreach (var transaction in transactions)
            {
                total += transaction.Montant;
            }

            return total;
        }

        protected Transaction AjouterTransaction(TypeTransaction type, decimal montant)
        {
            Transaction transaction = new Transaction(montant, DateTime.Today, type);
            Transactions.Add(transaction);
            return transaction;
        }

        public abstract void Deposer(decimal montant);

        protected void InvoquerDepotEffectue(Transaction transaction)
        {
            DepotEffectue?.Invoke(this, new TransactionEventArgs(transaction));
        }

        protected void InvoquerDepotErreur(string message)
        {
            DepotErreur?.Invoke(this, new MessageEventArgs(message));
        }

        public virtual void Retirer(decimal montant)
        {
            throw new NotImplementedException();
        }

        protected void InvoquerRetraitEffectue(Transaction transaction)
        {
            RetraitEffectue?.Invoke(this, new TransactionEventArgs(transaction));
        }

        protected void InvoquerRetraitErreur(string message)
        {
            RetraitErreur?.Invoke(this, new MessageEventArgs(message));
        }

        
    }

    public class TransactionEventArgs: EventArgs
    {
        public Transaction Transaction { get; private set; }

        public TransactionEventArgs(Transaction transaction)
        {
            Transaction = transaction;
        }
    }

    public class MessageEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public MessageEventArgs(string message)
        {
            Message = message;
        }
    }
}

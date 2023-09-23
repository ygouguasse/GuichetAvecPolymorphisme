namespace guichet.modeles.transactions
{
    public class Transaction
    {
        public decimal Montant { get; private set; }
        public DateTime Date { get; private set; }
        public TypeTransaction Type { get; private set; }

        public Transaction(decimal montant, DateTime date, TypeTransaction type)
        {
            Montant = montant;
            Date = date;
            Type = type;
        }
    }
}

namespace SimpleBlockchain
{
    class Block
    {
        private int previousHash { get; }

        public Transaction[] transactions { get; }

        public int blockhash { get; }

        public Block(int previousHash, Transaction[] transactions)
        {
            this.previousHash = previousHash;
            this.transactions = transactions;

            object[] contents = { transactions, GetHashCode(), previousHash };
            this.blockhash = contents.GetHashCode();
        }
    }
}
namespace SimpleBlockchain
{
    class Block
    {
        private int previousHash { get; }

        public string[] transactions { get; }

        public int blockhash { get; }

        public Block(int previousHash, string[] transactions)
        {
            this.previousHash = previousHash;
            this.transactions = transactions;

            object[] contents = { transactions, GetHashCode(), previousHash };
            this.blockhash = contents.GetHashCode();
        }
    }
}
using static System.Console;

namespace SimpleBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] genesisTransactions = { "satoshi nakamoto sent ivan 100000000 bitcoin", "Avinash sent 1 bitcoins to Ashish" };
            var genesisBlock = new Block(0, genesisTransactions);
            WriteLine("Hash of genesis block:");
            WriteLine(genesisBlock.blockhash);

            string[] block2Transactions = { "Ashish sent 50 bitcoin to satoshi", "satoshi sent 50 bitcoin to Reliance" };
            var block2 = new Block(genesisBlock.blockhash, block2Transactions);
            WriteLine("Hash of block 2:");
            WriteLine(block2.blockhash);

            string[] block3Transactions = { "Ashish sent 20000 bitcoin to RBI" };
            var block3 = new Block(block2.blockhash, block3Transactions);
            WriteLine("Hash of block 3:");
            WriteLine(block3.blockhash);
        }
    }
}
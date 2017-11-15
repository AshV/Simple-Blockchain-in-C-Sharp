using static System.Console;

namespace SimpleBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction[] genesisTransactions = {
                new Transaction{ From="Satoshi", To="Ashish", Value=100000000 },
                new Transaction{ From="Avinash", To="Ashish", Value=1 }
            };
            var genesisBlock = new Block(0, genesisTransactions);
            WriteLine("Hash of genesis block:");
            WriteLine(genesisBlock.blockhash);

            Transaction[] block2Transactions = {
                new Transaction{ From="Ashish", To="Satoshi", Value=50 },
                new Transaction{ From="Satoshi", To="Relaince", Value=50 }
            };
            var block2 = new Block(genesisBlock.blockhash, block2Transactions);
            WriteLine("Hash of block 2:");
            WriteLine(block2.blockhash);

            Transaction[] block3Transactions =            {
                new Transaction{ From="Ashish", To="RBI", Value=20000 }
            };
            var block3 = new Block(block2.blockhash, block3Transactions);
            WriteLine("Hash of block 3:");
            WriteLine(block3.blockhash);
        }
    }
}
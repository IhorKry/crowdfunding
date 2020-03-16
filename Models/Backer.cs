using System.Collections.Generic;

namespace crowdfunding.Models
{
    public class Backer
    {
        public int Id { get; set; }
        public List<Transaction> TransactionHistory { get; set; }

        public Backer()
        {
            TransactionHistory = new List<Transaction>();
        }
    }
}